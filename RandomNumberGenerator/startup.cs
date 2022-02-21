using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RandomNumberGenerator.ConsoleClasses
{
    public class startup
    {
        public void doonstart()
        {
            ConsoleColor background = Console.BackgroundColor;
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("RandomNumberGenerator, by Jurij15");
            Thread.Sleep(100);
            System.Console.WriteLine("v1.0");
            Thread.Sleep(300);
            //initializing
            Console.ResetColor();
            System.Console.WriteLine("Initializing...");
            Thread.Sleep(300);
            //help command
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type ?help for help");
            ///the whole command system
            System.Console.WriteLine("Enter a command...");
        }
    }
}
