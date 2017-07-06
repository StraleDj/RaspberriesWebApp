namespace RaspberryWebApp.Base
{
    using System;

    public class EventLogger
    {
        /// <summary>
        /// Simple event logging.
        /// </summary>
        /// <param name="method">Method from wich logger is called.</param>
        /// <param name="param">Parameter to log.</param>
        public static void LogEventSimple(string method, string param)
        {
            Console.WriteLine(String.Format("Poziv metode \"{0}\", sa parametrom \"{1}\".", method, param));
        }
    }
}
