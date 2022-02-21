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
            string noinput = "";
            string generate = "gen";
            string infinitegenerate = "gen inf";
            string gui = "gui";
            string help = "?help";
            string verboxtest = "?ver";
            string breakprogram = "breakprogram";
            string exit = "exit";
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
                else if (input == infinitegenerate)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    infinitegen infgen = new infinitegen();
                    infgen.infinitegenExecute();
                    //Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (input == exit)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    exitcomm exitcomm = new exitcomm();
                    exitcomm.exitExecute();
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
                else if (input != infinitegenerate)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Command not recognised!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (input != exit)
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