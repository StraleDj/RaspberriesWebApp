namespace RaspberryWebApp.Base
{
    using System.Configuration;

    public class Configuration
    {
        /// <summary>
        /// Method used for obtaining server host address.
        /// </summary>
        /// <returns>Server host address as a string.</returns>
        public static string ReadServerBaseAddress()
        {
            return ConfigurationManager.AppSettings["ServerHostAddress"];
        }
    }
}
