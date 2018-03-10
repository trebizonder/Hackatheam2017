using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using static Hackatheam2017.Models.GoogleMaps.GmClass;

namespace Hackatheam2017.Models.GoogleMaps
{
    public static class Directions
    {
        private static double GetDistance(double startLatitude, double endLatitude, double startLongitude, double endLongitude)
        {
            try
            {
                string apiUrl = "http://maps.googleapis.com/maps/api/directions/json?origin={0},{1}&destination={2},{3}&sensor=false";
                apiUrl = string.Format(apiUrl,
                startLatitude, startLongitude,
                endLatitude.ToString(),
                endLongitude.ToString()
                );
                WebRequest request = HttpWebRequest.Create(apiUrl);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                System.Web.Script.Serialization.JavaScriptSerializer parser = new System.Web.Script.Serialization.JavaScriptSerializer();
                string responseStringData = reader.ReadToEnd();
                RootObject responseData = parser.Deserialize<RootObject>(responseStringData);
                if (responseData != null)
                {
                    double distance = responseData.routes.Sum(r => r.legs.Sum(l => l.distance.value));
                    if (distance == 0)
                    {
                        throw new Exception("Google cannot find road route");
                    }
                    return distance;
                }
                else
                {
                    throw new Exception("Unable to get location from google");
                }

            }
            catch (Exception ex)
            {
                int R = 6371;
                double dLat = (endLatitude - startLatitude).ToRadian();
                double dLon = (endLongitude - startLongitude).ToRadian();
                var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                        Math.Cos(startLatitude.ToRadian()) * Math.Cos(endLatitude.ToRadian()) *
                        Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
                var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
                var d = R * c;
                return d * 1000;
            }

        }

        public static double ToRadian(this double number)
        {
            return (number * Math.PI / 180);
        }
    }
}