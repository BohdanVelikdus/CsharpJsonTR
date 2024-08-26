using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Net.Security;
using System.Text.Json;

namespace TRCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new GameDataParserApp();
            var logger = new Logger("log.txt");

            try {
                app.Run();
            }
            catch(Exception e) {
                Console.WriteLine("Error happend:\n" + e.Message);
                logger.Log(e);
            }
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
