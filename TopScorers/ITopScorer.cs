using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopScorers
{
    public  interface ITopScorer
    {
        void DisplayTopScorers(IEnumerable<(string Name, int Score)> topScorers);
    }
}
