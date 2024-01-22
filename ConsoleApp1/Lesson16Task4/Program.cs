namespace Lesson16Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Clients> clientRecords = new List<Clients>
        {
            new Clients { Year = 2022, Month = 1, Duration = 5, ClientCode = 1 },
            new Clients { Year = 2022, Month = 1, Duration = 8, ClientCode = 2 },
            new Clients { Year = 2022, Month = 2, Duration = 7, ClientCode = 1 },
            new Clients { Year = 2023, Month = 1, Duration = 10, ClientCode = 2 },
            new Clients { Year = 2023, Month = 2, Duration = 6, ClientCode = 1 }
        };

            var totalYearDuration = clientRecords
                .GroupBy(record => record.Year)
                .Select(group => new
                {
                    Year = group.Key,
                    TotalDuration = group.Sum(record => record.Duration)
                })
                .OrderByDescending(result => result.TotalDuration)
                .ThenBy(result => result.Year)
                .First();

            Console.WriteLine($"Year with the longest total duration of classes: {totalYearDuration.Year}");
            Console.WriteLine($"Longest total duration of classes: {totalYearDuration.TotalDuration} hours");
        }
    }
}
