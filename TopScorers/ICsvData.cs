using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopScorers
{
    public interface ICsvData
    {
        List<(string Name, int Score)> CsvInputData(string[] lines);
     
    }
}
