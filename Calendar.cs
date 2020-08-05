using System;

namespace calendar
{
    public class Calendar
    {
        public int Month { get; set; } = DateTime.Now.Month;
        public int Year { get; set; } = DateTime.Now.Year;

        public void Show()
        {
            Console.WriteLine($"********* Month: {this.Month}, {this.Year} *********");
            Console.WriteLine("Mo \t Tu \t We \t Th \t Fr \t Sa \t Su");
            var start = new DateTime(this.Year, this.Month, 1);
            var end = start.AddMonths(1).AddDays(-1);
            int numberDayOfWeek = (int) start.DayOfWeek;

            for (int i = 1; i < numberDayOfWeek; i++)
            {
                Console.Write("\t");
            }
            for (DateTime day = start; day <= end; day = day.AddDays(1))
            {
                if (day.DayOfWeek == DayOfWeek.Monday)
                {
                    Console.WriteLine();
                }
                
                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday || day.Date == DateTime.Now.Date)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(day.Day + "\t");
                    Console.ResetColor();
                }else{
                    Console.Write(day.Day + "\t");
                }
                
            }
            Console.WriteLine();
        }
    }
}