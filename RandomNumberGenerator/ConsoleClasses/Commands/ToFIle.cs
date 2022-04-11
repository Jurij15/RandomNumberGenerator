using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows;

namespace RandomNumberGenerator.ConsoleClasses.Commands
{
    public static class ToFIle
    {
         public static void ToFileExecute(int HowMuch)
        {
            Console.WriteLine("Enter path:");
            //string path = Console.ReadLine();
            string filename = "random.txt";
            int currentnum = 0;
            using (FileStream fs = File.Create(filename))
            {
                while (currentnum < HowMuch)
                {
                    Random random = new Random();
                    int answer = random.Next(1, 201);
                    string textanswer = answer.ToString();
                    //number = textanswer;
                    Byte[] title = new UTF8Encoding(true).GetBytes(textanswer);
                    fs.Write(title, 0, title.Length);
                    Console.WriteLine(textanswer);
                    currentnum += 1;
                }
            }
        }
    }
}
