using Microsoft.Owin.Cors;
using NLog;
using Owin;
using System.Timers;
using System.Web.Http;

namespace WebOwinHosting
{
    public class Startup
    {
        Logger log = LogManager.GetCurrentClassLogger();
        public void Configuration(IAppBuilder appbuilder)
        {
            appbuilder.UseCors(CorsOptions.AllowAll);
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute (
                name: "DefaultApi",
                 routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional } 
                );

            appbuilder.UseWebApi(config);
            
            Timer t = new Timer(30000); // 1 sec = 1000, 60 sec = 60000
            t.AutoReset = true;
            t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);
            t.Start();

        }

        private void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

           // log.Info("Number of Devices, Device Type,Device Firmware Version,Device Connected Receiver / Transmitter: "+DateTime.Now);

        }
    }
    
}
