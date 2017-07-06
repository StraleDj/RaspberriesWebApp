namespace RaspberryWebApp.Base.Exceptions
{
    using System;

    public class BaseException : Exception
    {
        /// <summary>
        /// Rasspberry Web Application Basic Exception Class
        /// </summary>
        /// <param name="message"></param>
        public BaseException(string message) : base(message) { }

        /// <summary>
        /// Format all exceptions according to the specific template.
        /// </summary>
        /// <returns></returns>
        public string FormatException()
        {
            return String.Format("Došlo je do greške!\nPoruka - {0}\nStek - {1},\nUnutrašnja greška - {2}.", Message, StackTrace, InnerException.Message);
        }
    }
}
