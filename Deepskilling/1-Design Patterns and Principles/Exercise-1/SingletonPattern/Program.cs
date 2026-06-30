// See https://aka.ms/new-console-template for more information
using SingletonPattern;
class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.Instance;
        logger1.Log("First log message");
        Logger logger2 = Logger.Instance;
        logger2.Log("Second log message");
        if(logger1 == logger2)
        {
            Console.WriteLine("Only one Logger instance exists.");
        }
    }
}