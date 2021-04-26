using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public Class1()
        {
            LoggerConfiguration loggerConfig = new LoggerConfiguration().MinimumLevel.Information();


            loggerConfig.WriteTo.Sentry(o =>
            {
                o.Dsn = "YOUR_DSN_HERE";
                o.Debug = true;
                o.Environment = "test";
            });

            Log.Logger = loggerConfig.CreateLogger();

            Log.Logger.Error("error");
        }
           
    }
}
