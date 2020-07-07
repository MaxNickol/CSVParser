using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSVParser
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadingFile(@"TopItemsGold.csv");
        }



        public static void ReadingFile(string path)
        {


            List<EfficiencyItems> list = File.ReadAllLines(path)
                                              .Skip(1)
                                              .Select(line => EfficiencyItems.ParserCsv(line))                                              
                                              .OrderByDescending(item => item.Cost)
                                              .Take(10)
                                              .ToList();

            Console.WriteLine($"The most expensive item in list is {list.Max(item => item.Title + " Efficiency " + item.Efficiency + " Cost " + item.Cost)}");
            Console.WriteLine();
            Console.WriteLine($"The cheapest item in list is {list.Min(item => item.Title + " Efficiency " + item.Efficiency + " Cost " + item.Cost)} ");
            Console.WriteLine();            

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
                                              
            
        }
    }
}
