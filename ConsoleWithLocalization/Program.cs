using System;
using System.Globalization;
using System.Threading;

using Domain.Resources;

namespace ConsoleWithLocalization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Default = System Default
            Console.WriteLine(Messages.WELCOME);

            ChangeCulture("de");
            Console.WriteLine(Messages.WELCOME);

            ChangeCulture("es");
            Console.WriteLine(Messages.WELCOME);

            ChangeCulture("en");
            Console.WriteLine(Messages.WELCOME);

            ChangeCulture("it"); //Doesn't exist
            Console.WriteLine(Messages.WELCOME);
        }

        static void ChangeCulture(string name)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(name);
        }
    }
}
