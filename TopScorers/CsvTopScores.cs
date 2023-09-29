using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopScorers
{
    public class CsvTopScores : ITopScorer
    {
        public void DisplayTopScorers(IEnumerable<(string Name, int Score)> topScorers)
        {
           // Console.WriteLine("Top Scorers:");
            foreach (var scorer in topScorers)
            {
                Console.WriteLine($"{scorer.Name}: {scorer.Score}");
            }
        }
    }
}
