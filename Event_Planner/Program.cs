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
      string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
      var entry = "";
      //Prompt for start date
      Console.WriteLine("Enter start date as: month, day, year, dayofweek");
      Console.Write("Starting Date: ");
      entry = Console.ReadLine();
      var entrySplit = entry.Split(',');
      if (entrySplit.Length < 4)
        Console.WriteLine("Enter a date as: month, day, year, dayofweek");
      var startDayOfWeek = int.Parse(entrySplit[3]);
      var startDate = new Date( int.Parse(entrySplit[1]), int.Parse(entrySplit[0]), int.Parse(entrySplit[2]));
      //Prompt for event date
      Console.WriteLine("Enter event date as: month, day, year");
      Console.Write("Ending Date: ");
      entry = Console.ReadLine();
      entrySplit = entry.Split(',');
      if (entrySplit.Length < 3)
        Console.WriteLine("Enter a date as: month, day, year");
      var eventDate = new Date(int.Parse(entrySplit[1]), int.Parse(entrySplit[0]), int.Parse(entrySplit[2]));
      var startDateFrom1900 = startDate.numberOfDaysSince(1900);
      var eventDateFrom1900 = eventDate.numberOfDaysSince(1900);
      var diff = eventDateFrom1900 - startDateFrom1900;
      var endingDayOffset = diff % 7;
      var endingDay = (startDayOfWeek + endingDayOffset) % 7;
      Console.WriteLine(eventDate.print() + " is " + diff + " days from " + startDate.print() + " on " + days[endingDay]);
      Console.ReadKey();
    }
  }
}
