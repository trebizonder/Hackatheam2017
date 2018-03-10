using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    public class Connection
    {
        private string _DbAuthConnectionString;
        private DbProviderFactory _Factory;

        public Connection(string DbAuthConnectionString, DbProviderFactory Factory)
        {
            _DbAuthConnectionString = DbAuthConnectionString;
            _Factory = Factory;
            using (DbConnection c = CreateConnexion())
            {
                c.Open();
            }
        }

        internal DbConnection CreateConnexion()
        {
            DbConnection con = _Factory.CreateConnection();
            con.ConnectionString = _DbAuthConnectionString;
            return con;
        }
        internal DbCommand CreateCommand(Command com, DbConnection c)
        {
            DbCommand dbCmd = c.CreateCommand();
            dbCmd.CommandText = com.GetRequest();
            dbCmd.CommandType = com.IsProcedure ? CommandType.StoredProcedure : CommandType.Text;
            com.AddParameters(dbCmd, _Factory);
            return dbCmd;
        }
        public object ExecuteScalar(Command command)
        {
            using (DbConnection c = CreateConnexion())
            {
                using (DbCommand dbCommand = CreateCommand(command, c))
                {
                    c.Open();
                    return dbCommand.ExecuteScalar();
                }
            }
        }

        public IEnumerable<T> ExecuteReader<T>(Command cmd, Func<IDataRecord, T> Mapper)
        {
            if (Mapper == null)
                throw new ArgumentNullException(nameof(Mapper));

            using (DbConnection c = CreateConnexion())
            {
                using (DbCommand dbCmd = CreateCommand(cmd, c))
                {
                    c.Open();
                    using (DbDataReader reader = dbCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return Mapper(reader);
                        }
                    }
                }
            }
        }

        public int ExecuteNonQuery(Command command)
        {
            using (DbConnection c = CreateConnexion())
            {
                using (DbCommand dbCommand = CreateCommand(command, c))
                {
                    c.Open();
                    return dbCommand.ExecuteNonQuery();
                }
            }

        }

        public DataTable GetDataTable(Command command)
        {
            using (DbConnection c = CreateConnexion())
            {
                using (DbCommand cmd = CreateCommand(command, c))
                {
                    using (DbDataAdapter da = _Factory.CreateDataAdapter())
                    {
                        da.SelectCommand = cmd;

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        return dt;
                    }
                }
            }
        }

    }
}
