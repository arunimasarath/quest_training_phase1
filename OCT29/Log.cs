using System;
using log4net;
using log4net.Config;
using log4net.Layout;
using log4net.Repository;

namespace log
{
    class Program
    {
       
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            
            ConfigureLogging();

            try
            {
                Console.Write("Enter num1: ");
                int i = int.Parse(Console.ReadLine());

                Console.Write("Enter num2: ");
                int j = int.Parse(Console.ReadLine());

                int sum = i + j;
                Console.WriteLine("Sum: " + sum);
            }
            catch (Exception e)
            {
                log.Error("An error occurred", e);
            }
        }

        private static void ConfigureLogging()
        {
            var repository = LogManager.GetRepository();
            var layout = new PatternLayout
            {
                ConversionPattern = "%message%newline"
            };
            layout.ActivateOptions();

            BasicConfigurator.Configure(repository, new log4net.Appender.ConsoleAppender
            {
                Layout = layout
            });
        }
    }
}




