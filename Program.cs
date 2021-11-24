using lesson7.Properties;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Threading;
//using System.Configuration;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Resources.hello);
            ResourceManager rm = new ResourceManager("lesson7.DataStrings",
                Assembly.GetExecutingAssembly());

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Console.WriteLine(DateTime.Now.ToShortDateString());

            //Console.WriteLine(rm.GetString("hello"));

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine(DateTime.Now.ToShortDateString());
            int a = 7;
            var b = 3;
            Console.WriteLine("Введите ваше имя");
            string nameOne = Console.ReadLine();
            Console.WriteLine($"Hello " + nameOne + "\t" + (a * b));
            Console.ReadKey();
        }
    }
}
