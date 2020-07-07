using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSVParser
{
   public class EfficiencyItems
    {

        public int Rank { get; set; }

        public string Title { get; set; }

        public double Efficiency { get; set; }

        public int Cost { get; set; }

        


        public override string ToString()
        {
            return $"Rank = {Rank}, Title is {Title}, Efficiency = {Efficiency}, Cost = {Cost}";
        }

        public static EfficiencyItems ParserCsv (string lines)
        {
            string[] parts = lines.Split(';');

            return new EfficiencyItems
            {
                Rank = int.Parse(parts[0]),
                Title = parts[1],
                Efficiency =double.Parse(parts[2]),
                Cost = int.Parse(parts[3]),
                
            };
        }

    }
}
