using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      var entry = "";
      //Prompt for start date
      Console.WriteLine("Enter start date as: month, day, year, dayofweek");
      Console.Write("Starting Date: ");
      entry = Console.ReadLine();
      var entrySplit = entry.Split(',');
      if (entrySplit.Length < 4)
        Console.WriteLine("Enter a date as: month, day, year, dayofweek");
      int[,] startDate = { { int.Parse(entrySplit[0]), int.Parse(entrySplit[1]), int.Parse(entrySplit[2]), int.Parse(entrySplit[3]) } };
      //Prompt for event date
      Console.WriteLine("Enter event date as: month, day, year");
      Console.Write("Ending Date: ");
      entry = Console.ReadLine();
      entrySplit = entry.Split(',');
      if (entrySplit.Length < 3)
        Console.WriteLine("Enter a date as: month, day, year");
      int[,] endDate = { { int.Parse(entrySplit[0]), int.Parse(entrySplit[1]), int.Parse(entrySplit[2]) } };
      processDatePairs(startDate, endDate);
      Console.WriteLine();
      Console.WriteLine("Testing 3 random pairs of dates");
      Console.WriteLine();
      int[,] startDates = { { 4, 23, 1923, 1 }, { 8, 12, 1934, 0 }, { 10, 15, 1965, 5 } };
      int[,] endDates = { { 6, 20, 1932 }, { 4, 2, 1956 }, { 9, 20, 1972 } };
      processDatePairs(startDates, endDates);
      Console.ReadKey();
    }

    //Processes date pairs showing difference in days and day name of the event day
    static void processDatePairs(int[,] startDates, int[,] endDates)
    {
      string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
      for (int i = 0; i < startDates.GetLength(0); i++)
      {
        var startDayOfWeek = startDates[i, 3];
        var startDate = new Date(startDates[i, 1], startDates[i, 0], startDates[i, 2]);
        var eventDate = new Date(endDates[i, 1], endDates[i, 0], endDates[i, 2]);
        var startDateFrom1900 = startDate.numberOfDaysSince(1900);
        var eventDateFrom1900 = eventDate.numberOfDaysSince(1900);
        var diff = eventDateFrom1900 - startDateFrom1900;
        var endingDayOffset = diff % 7;
        //add offset to starting day of week index
        var endingDay = (startDayOfWeek + endingDayOffset) % 7;
        Console.WriteLine(eventDate.print() + " is " + diff + " days from " + startDate.print() + " on " + days[endingDay]);
      }
    }
  }
}
