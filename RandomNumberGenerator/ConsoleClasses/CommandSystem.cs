using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNumberGenerator.ConsoleClasses.Commands;

namespace RandomNumberGenerator.ConsoleClasses
{
    public class CommandSystem
    {
        public void startcommsystem()
        {
            string noinput = "";
            string generate = "gen";
            string infinitegenerate = "gen inf";
            string gui = "gui";
            string help = "?help";
            string verboxtest = "?ver";
            string breakprogram = "breakprogram";
            string exit = "exit";
            string testdumptofile = "ToFile";
            //string testdumptofileinfinite = "?!tofile inf";
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
                else if (input == testdumptofile)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please enter the file path");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string filepath = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please enter how many numbers you want (1-999999");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string amount = Console.ReadLine();
                    int amountint = Convert.ToInt32(amount);
                    int maxnum = 999999;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (amountint > maxnum)
                    {
                        Console.WriteLine("Your number is higher than 999999!");
                        Console.WriteLine("This may result in high CPU usage and large filesize!");
                        while (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("Press enter to start generating...");
                            ToFIle.ToFileExecute(amountint);
                        }

                    }
                    else if (amountint < maxnum)
                    {
                        Console.WriteLine("Press enter to start generating...");
                        while (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            //Console.WriteLine("Press enter to start generating...");
                            ToFIle.ToFileExecute(amountint);
                        }
                    }
                    /*
                    else if (input == testdumptofileinfinite)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        InfiniteToFIle infiniteToFIle = new InfiniteToFIle();
                        infiniteToFIle.inftofileExecute();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    */
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
                    else if (input != testdumptofile)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Command not recognised!");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    /*
                    else if (input != testdumptofileinfinite)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Command not recognised!");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    */
                }
            }
        }
    }
}
