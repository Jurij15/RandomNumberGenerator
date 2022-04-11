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
            string filename = "randomINF.txt";
            using (FileStream fs = File.Create(filename))
            {
                while (true)
                {
                    Random random = new Random();
                    int answer = random.Next(1, 201);
                    string textanswer = answer.ToString();
                    //number = textanswer;
                    Byte[] title = new UTF8Encoding(true).GetBytes(textanswer);
                    fs.Write(title, 0, title.Length);
                    Console.WriteLine(textanswer);
                }
            }
        }
    }
}
