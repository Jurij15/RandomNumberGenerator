using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator.ConsoleClasses.Commands
{
    public class help
    {
        public void helpexecute()
        {
            Console.WriteLine("List of commands:");
            Console.WriteLine("GUI - open gui");
            Console.WriteLine("gen - generate a number");
            Console.WriteLine("ver - display a version box");
        }
    }
}
