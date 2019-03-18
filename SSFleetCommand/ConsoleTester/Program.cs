using SSFleetCommandModels.Models;
using SSFleetCommandModels.Util;
using System;
using System.Linq;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            var csvConverter = new CSVConverter<DraftStarSystem>()
            {
                Path = @"D:\Downloads\SystemLog.csv",
                SkipLines = 1,
                TakeLines = 1
            };

            var result = csvConverter.Execute();
            DateTime endBlocked = DateTime.Now;
            var convertResult = csvConverter.ExecuteAsync();
            result = convertResult.GetAwaiter().GetResult();
            DateTime endAsync = DateTime.Now;

            Console.WriteLine($"Processed: {csvConverter?.Results?.Count ?? 0} records -> Sync: {(endBlocked - startTime).TotalSeconds} secs Async -> {(endAsync - endBlocked).TotalSeconds} secs");
            var starSystemsList = csvConverter.Results.Select(ds => new StarSystem(ds));
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}
