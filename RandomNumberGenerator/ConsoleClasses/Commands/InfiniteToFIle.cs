using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RandomNumberGenerator.ConsoleClasses.Commands
{
    public  class InfiniteToFIle
    {
        public void inftofileExecute()
        {
            string path = "randomINF.txt";
            using (FileStream fs = File.Create(path)) ;
            List<string> lines = new List<string>();
            StreamReader reader = new StreamReader("randomINF.txt");
            while (true)
            {
                /*
                Random random = new Random();
                int answer = random.Next(1, 201);
                string number = answer.ToString();
                lines.Add(number);
                Console.WriteLine(number);
                */
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("randomINF.txt", true))
                {
                    file.WriteLine("text to edit / append ...");
                }
            }
        }
    }
}
