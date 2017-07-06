namespace RaspberryWebApp.WebAPI
{
    using Microsoft.Owin.FileSystems;
    using Microsoft.Owin.StaticFiles;
    using Owin;
    using System.Web.Http;

    public class Startup
    {
        /// <summary>
        /// WebAPI and File Server configuration.
        /// </summary>
        /// <param name="appBuilder"></param>
        public void Configuration(IAppBuilder appBuilder)
        {
            //WebAPI configuration.
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultRoute",
                routeTemplate: "api/{controller}/{action}/{param}",
                defaults: new
                {
                    param = RouteParameter.Optional,
                    action = RouteParameter.Optional
                }
            );

            //File Server configuration
            PhysicalFileSystem pfs = new PhysicalFileSystem("..\\..\\WebJQuery");
            FileServerOptions fso = new FileServerOptions {
                EnableDefaultFiles = true,
                FileSystem = pfs                
            };
            fso.StaticFileOptions.FileSystem = pfs;
            fso.StaticFileOptions.ServeUnknownFileTypes = true;
            fso.DefaultFilesOptions.DefaultFileNames = new[] { "index.html" };
            
            appBuilder.UseWebApi(config);
            appBuilder.UseFileServer(fso);
        }
    }
}
