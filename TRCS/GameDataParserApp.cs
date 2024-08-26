using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TRCS
{
    internal class GameDataParserApp
    {
        public void Run() {
            bool isFileReaded = false;
            string fileContents = default;
            string? filename = default;
            do
            {
                Console.WriteLine("Enter the name of file you want to read:");
                filename = Console.ReadLine();
                try
                {
                    fileContents = File.ReadAllText(filename);
                    isFileReaded = true;
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("This file does not exist");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Empty file name");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error happpend");
                }
            } while (!isFileReaded);



            List<VideoGame> games = default;
            try
            {
                games = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
            }
            catch (JsonException e)
            {
                ConsoleColor originalColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"JSON in {filename} file was not " + $"valid format. JSON body: ");
                Console.WriteLine(fileContents);
                Console.ForegroundColor = originalColor;

                throw new Exception($"{e.Message} THe file is: {filename}", e);
            }




            if (games.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Loaded games are:");
                foreach (VideoGame game in games)
                {
                    Console.WriteLine(game.ToString());
                }
            }
            else
            {
                Console.WriteLine("No games are presented inside a file!");
            }

            Console.ReadKey();
        }
    }
    
}
