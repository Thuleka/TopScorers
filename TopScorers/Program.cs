// See https://aka.ms/new-console-template for more information
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using TopScorers;

public class Program
{

    public static void Main(string[] args)
    {
       // Fetch csv file 
        string csvData = "C:\\Temp\\TestData.csv";

        try
        
        {
            // read csv file
            string[] lines = File.ReadAllLines(csvData);

            ICsvData dataParser = new CsvData();
            List<(string Name, int Score)> scores = dataParser.CsvInputData(lines);

            if (scores.Count == 0)
            {
                Console.WriteLine("NoValidData");
                return;
            }

            // Get maximum scores by Name
            int maxScore = scores.Max(s => s.Score);
            var topScorers = scores.Where(s => s.Score == maxScore).OrderBy(s => s.Name);

            ITopScorer outputProvider = new CsvTopScores();
            outputProvider.DisplayTopScorers(topScorers);
        }
        catch (Exception ex)
        {
            Console.WriteLine(string.Format(ex.Message));
        }
    }
}

