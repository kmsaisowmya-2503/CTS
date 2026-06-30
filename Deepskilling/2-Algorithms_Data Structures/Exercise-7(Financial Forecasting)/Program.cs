// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Current value: ");
        double currentValue = Convert.ToDouble(Console.ReadLine());


        Console.Write("Growth Rate: ");
        double growthRate = Convert.ToDouble(Console.ReadLine());


        Console.Write("Year: ");
        int year = Convert.ToInt32(Console.ReadLine());


        double futureValue = Forecast.CalculateFutureValue(
            currentValue,
            growthRate,
            year
        );


        Console.WriteLine("Predicted Future Value:");
        Console.WriteLine(futureValue);
    }
}
