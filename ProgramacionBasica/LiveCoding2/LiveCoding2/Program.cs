// See https://aka.ms/new-console-template for more information

using System.Globalization;

string path = @"C:\Users\a846809\Documents\TestDir\file1.txt";
CultureInfo locale = new CultureInfo("es-MX");

Console.WriteLine("Enter a date with the following format yyyyMMdd");

DateTime myDate = DateTime.ParseExact(Console.ReadLine(), "yyyyMMdd", locale);
string parsedDate = String.Format("Log date: {0} {1} of {2}, {3}", myDate.DayOfWeek, myDate.Day, myDate.ToString("MMMM"), myDate.Year);

Console.WriteLine(parsedDate);
File.AppendAllText(path, parsedDate + "\n");

Console.ReadKey();