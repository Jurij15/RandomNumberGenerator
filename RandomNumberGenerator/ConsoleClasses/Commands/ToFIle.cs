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
    public  class ToFIle
    {
        //this is a testing, this will make a file with (maybe) 100 random numbers
        public void ToFileExecute()
        {
            //create a new file 
            string path = "random.txt";
            using (FileStream fs = File.Create(path));
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int answer = random.Next(1, 501);
                string textanswer = answer.ToString();
                string line = answer.ToString();
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader("random.txt");
                Console.WriteLine(line);
                lines.Add(line);
                reader.Close();
            }
        }
    }
}
