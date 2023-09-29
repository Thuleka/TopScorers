using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopScorers
{
    public class CsvData : ICsvData
    {
        public List<(string Name, int Score)> CsvInputData(string[] lines)
        {
            List<(string Name, int Score)> scores = new List<(string, int)>();

            foreach (string line in lines.Skip(1)) // Skip the header row
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3 && int.TryParse(parts[2], out int score))
                {
                    scores.Add((parts[0] +" "+ parts[1], score));
                }
                else
                {
                    Console.WriteLine($"Skipping invalid line: {line}");
                }
            }

            return scores;
        }
    }

}
