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
        //this is a testing, this will make a file with (maybe) 20 random numbers
        //there is probably a waaay simpler process, I just don't know it
        public string Number1 { get; set; }
        public string Number2 { get; set; }
        public string Number3 { get; set; }
        public string Number4 { get; set; }
        public string Number5 { get; set; }
        public string Number6 { get; set; }
        public string Number7 { get; set; }
        public string Number8 { get; set; }
        public string Number9 { get; set; }
        public string Number10 { get; set; }
        public string Number11 { get; set; }
        public string Number12 { get; set; }
        public string Number13 { get; set; }
        public string Number14 { get; set; }
        public string Number15 { get; set; }
        public string Number16 { get; set; }
        public string Number17 { get; set; }
        public string Number18 { get; set; }
        public string Number19 { get; set; }
        public string Number20 { get; set; }


        public void ToFileExecute()
        {
            //create a new file 
            string path = "random.txt";
            using (FileStream fs = File.Create(path));
            List<string> lines = new List<string>();
            StreamReader reader = new StreamReader("random.txt");
            /*
            //lines.Add("Numbers here:");
            //this didn't work for some reason
            for (int i = 0; i < 20; i++)
            {
                Random random = new Random();
                int answer = random.Next(1, 501);
                string textanswer = answer.ToString();
                string line = answer.ToString();
                Console.WriteLine(line);
                lines.Add(line);
                reader.Close();
            }
            */
            
        }

        public void NumberGenerate()
        {
            Random random = new Random();
            int answer = random.Next(1, 201);
        }
    }
}
