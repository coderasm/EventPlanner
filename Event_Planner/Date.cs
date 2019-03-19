using System;

namespace DateProg
{
  class Date
  {
    private DateTime date = DateTime.Now;

    public Date()
    {

    }

    public Date(int day, int month, int year)
    {
      date = new DateTime(year, month, day);
    }

    public int numberOfDaysSince(int year)
    {
      var startDate = new DateTime(year, 1, 1);
      var difference = date.Subtract(startDate);
      return (int)difference.TotalDays;
    }

    public bool isEarlier(Date date)
    {
      var firstDiff = numberOfDaysSince(1900);
      var secondDiff = date.numberOfDaysSince(1900);
      if (secondDiff < firstDiff)
        Console.WriteLine(date.print() + " is earlier than " + print());
      else
        Console.WriteLine(print() + " is earlier than " + date.print());
      return secondDiff < firstDiff;
    }

    public bool isLater(Date date)
    {
      var firstDiff = numberOfDaysSince(1900);
      var secondDiff = date.numberOfDaysSince(1900);
      if (secondDiff > firstDiff)
        Console.WriteLine(date.print() + " is later than " + print());
      else
        Console.WriteLine(print() + " is later than " + date.print());
      return secondDiff > firstDiff;
    }

    public bool isTheSame(Date date)
    {
      var firstDiff = numberOfDaysSince(1900);
      var secondDiff = date.numberOfDaysSince(1900);
      if (secondDiff == firstDiff)
        Console.WriteLine(date.print() + " equals " + print());
      else
        Console.WriteLine(print() + " does not equal " + date.print());
      return secondDiff == firstDiff;
    }

    public int nextDay()
    {
      var nextDay = date.AddDays(1).Day;
      Console.WriteLine("Day after " + print() + ": " + nextDay);
      return nextDay;
    }

    public int nextMonth()
    {
      var nextMonth = date.AddMonths(1).Month;
      Console.WriteLine("Month after " + print() + ": " + nextMonth);
      return nextMonth;
    }

    public int nextYear()
    {
      var nextYear = date.AddYears(1).Year;
      Console.WriteLine("Year after " + print() + ": " + nextYear);
      return nextYear;
    }

    public int prevDay()
    {
      var prevDay = date.AddDays(-1).Day;
      Console.WriteLine("Day before " + print() + ": " + prevDay);
      return prevDay;
    }

    public int prevMonth()
    {
      var prevMonth = date.AddMonths(-1).Month;
      Console.WriteLine("Month before " + print() + ": " + prevMonth);
      return prevMonth;
    }

    public int prevYear()
    {
      var prevYear = date.AddYears(-1).Year;
      Console.WriteLine("Year before " + print() + ": " + prevYear);
      return prevYear;
    }

    public string print()
    {
      return date.ToString("M/d/yyyy");
    }
  }
}
