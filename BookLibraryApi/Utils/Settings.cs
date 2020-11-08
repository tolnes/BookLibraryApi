using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Utils
{
    public class Settings
    {
        public static IConfigurationBuilder Getbuilder()
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json");
            return builder;
        }


        public static string GetAppSetting(string key)
        {
            //return Convert.ToString(ConfigurationManager.AppSettings[key]);
            var builder = Getbuilder();
            var GetAppStringData = builder.Build().GetValue<string>("AppSettings:" + key);
            return GetAppStringData;
        }

        public static string GetConnectionString(string key = "DefaultName")
        {
            var builder = Getbuilder();
            var ConnectionString = builder.Build().GetValue<string>("ConnectionStrings:" + key);
            return ConnectionString;
        }
    }
}
