using System;
using System.IO;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using RandomNumberGenerator.ConsoleClasses.Commands;
using System.Diagnostics;

namespace RandomNumberGenerator
{
    internal class Program
    {
        static void loopForever()
        {
            while (true) ;
        }
        private static int percentage;

        static void Main(string[] args)
        {
            ConsoleColor background = Console.BackgroundColor;
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("RandomNumberGenerator, by Jurij15");
            Thread.Sleep(100);
            System.Console.WriteLine("v0.1");
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
            //commands
            string noinput = "";
            string generate = "gen";
            string gui = "gui";
            string help = "?help";
            string verboxtest = "?ver";
            string breakprogram = "breakprogram";
            //recognise commands and execution
            while (noinput == noinput)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                string input = Console.ReadLine();

                //if command is recognised
                if (input == help)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    help helpclass = new help();
                    helpclass.helpexecute();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (input == generate)
                {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                    //generate a number
                    Generate generatee = new Generate();
                    generatee.GenerateNum();
                    System.Console.WriteLine(generatee.number);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (input == gui)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    gui guii = new gui();
                    guii.guiexecute();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (input == verboxtest)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    ver ver = new ver();
                    ver.verexecute();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (input == breakprogram)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    programbreak programbreak = new programbreak();
                    programbreak.breakprogramexecute();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                //if command isn't recognised
                else if (input != generate)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Command not recognised!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (input != gui)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Command not recognised!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (input != help)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Command not recognised!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (input != verboxtest)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Command not recognised!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (input != breakprogram)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Command not recognised!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            }
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