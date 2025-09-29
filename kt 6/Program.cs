using System;
enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main(string[] args)
    {
        PrintDayInRussian(DayOfWeek.Monday);
        PrintDayInRussian(DayOfWeek.Tuesday);
        PrintDayInRussian(DayOfWeek.Wednesday);
        PrintDayInRussian(DayOfWeek.Thursday);
        PrintDayInRussian(DayOfWeek.Friday);
        PrintDayInRussian(DayOfWeek.Saturday);
        PrintDayInRussian(DayOfWeek.Sunday);
    }
    static void PrintDayInRussian(DayOfWeek day)
    {
        string russianDay = day switch
        {
            DayOfWeek.Monday => "Понедельник",
            DayOfWeek.Tuesday => "Вторник",
            DayOfWeek.Wednesday => "Среда",
            DayOfWeek.Thursday => "Четверг",
            DayOfWeek.Friday => "Пятница",
            DayOfWeek.Saturday => "Суббота",
            DayOfWeek.Sunday => "Воскресенье",
            _ => "Неизвестный день"
        };

        Console.WriteLine(russianDay);
    }
}
