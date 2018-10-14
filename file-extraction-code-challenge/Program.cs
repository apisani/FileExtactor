using JsonExtractor;
using System;
using System.IO;
using System.Reflection;
using HorseHandler.Models;
using XML_Extractor;
using System.Collections.Generic;

namespace file_extraction_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //One extractor per file format
            JsonExtractor.JsonExtractor jsonExtractor = new JsonExtractor.JsonExtractor();
            XmlExtractor xmlExtractor = new XmlExtractor();
            HorseHandler.HorseHandler horseHandler = new HorseHandler.HorseHandler();

            //Retrive file from shared folder
            // Future development would involve an API to retrieve file and parse extension
            var xmlFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"Data\Caulfield_Race1.xml");
            var jsonFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"Data\Wolferhampton_Race1.json");

            List<HorseDto> SortedHorsesList = new List<HorseDto>();

            try
            {
                Console.WriteLine("Json file extraction:");
                SortedHorsesList = jsonExtractor.LoadJson(jsonFilePath);
                horseHandler.SortAndDisplayHorseList(SortedHorsesList);

                Console.WriteLine("\n------------------------------");

                Console.WriteLine("XML file extraction:");
                SortedHorsesList = xmlExtractor.LoadXml(xmlFilePath);
                horseHandler.SortAndDisplayHorseList(SortedHorsesList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
