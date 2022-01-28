using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Layout;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductsAPI
{
    public class Program
    {
        //private static ILog Logger
        //{
        //    get { return _Logger ?? (_Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType)); }
        //}
        //private static ILog _Logger;

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //private static void ConfigureLog4Net()
        //{
        //    var appender = new FileAppender()
        //    {
        //        Layout = new SimpleLayout(),
        //        File = Assembly.GetExecutingAssembly().Location + ".log",
        //        Encoding = Encoding.UTF8,
        //        AppendToFile = true,
        //        LockingModel = new FileAppender.MinimalLock()
        //    };
        //    appender.ActivateOptions();
        //    BasicConfigurator.Configure(appender);
        //}
    }
}
