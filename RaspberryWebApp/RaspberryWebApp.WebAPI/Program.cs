namespace RaspberryWebApp.WebAPI
{
    using Microsoft.Owin.Hosting;
    using System;
    using RaspberryWebApp.Base.Exceptions;
    using RaspberryWebApp.Base;

    class Program
    {
        /// <summary>
        /// Main system entrance point.
        /// </summary>
        static void Main()
        {
            //Main info.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("*****-----Maline-----****\nRazvio - Strahinja Đurković - 2017.");

            //App startup.
            try
            {
                string baseAddress = Configuration.ReadServerBaseAddress();
                if(baseAddress == null)
                {
                    Console.WriteLine("Nemoguće pribaviti adresu na kojoj je potrebno pokrenuti server, pritisnite bilo koji taster za nastavak.");
                    Console.ReadLine();
                    return;
                }

                //Application server startup.
                using (WebApp.Start<Startup>(url: baseAddress))
                {
                    Console.WriteLine(
                        String.Format("Server pokrenut na adresi --> {0}",
                        baseAddress)
                    );

                    string stopSign = String.Empty;
                    while (!String.Equals("D", stopSign) && !String.Equals("d", stopSign))
                    {
                        Console.Write("Pritisnite bilo koji taster kako biste zaustavili server.");
                        Console.ReadLine();
                        Console.Write("Da li ste sigurni da želite da zaustavite server?[D/N] ");
                        stopSign = Console.ReadLine();
                    }
                }
            }
            catch (BaseException ex)
            {
                Console.WriteLine(ex.FormatException());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine();
            }
        }
    }
}
