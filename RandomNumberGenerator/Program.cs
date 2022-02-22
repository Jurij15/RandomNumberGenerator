using System;
using System.IO;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using RandomNumberGenerator.ConsoleClasses.Commands;
using RandomNumberGenerator.ConsoleClasses;
using System.Diagnostics;

namespace RandomNumberGenerator
{
    internal class Program
    {
        static void loopForever()
        {
            while (true) ;
        }
        //private static int percentage;
        [STAThread]
        static void Main(string[] args)
        {
            startup startup = new startup();
            startup.doonstart();
            //commands
            CommandSystem commandSystem = new CommandSystem();
            commandSystem.startcommsystem();
        }
        public void generateinternal()
        {
            //generate a number
            Generate generate = new Generate();
            generate.GenerateNum();
            System.Console.WriteLine(generate.number);
        }
    }
}