using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    public class Command
    {
        private string _Request;
        private bool _UseProcedure;
        internal bool IsProcedure { get { return _UseProcedure; } }
        private Dictionary<string, object> _Parameters;

        public Command(string request, bool useProcedure) : this(request)
        {
            _UseProcedure = useProcedure;
        }
        public Command(string request)
        {
            _Parameters = new Dictionary<string, object>();
            _Request = request;
        }

        public void AddParameters(string name, object value)
        {
            _Parameters.Add(name, value);
        }

        public string GetRequest()
        {
            return _Request;
        }

        internal void AddParameters(DbCommand dbCommand, DbProviderFactory Factory)
        {
            foreach (KeyValuePair<string, object> item in _Parameters)
            {
                DbParameter par = Factory.CreateParameter();
                par.ParameterName = item.Key;
                par.Value = item.Value;

                dbCommand.Parameters.Add(par);
            }
        }

    }
}
