using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RandomNumberGenerator.ConsoleClasses.Commands
{
    internal class infinitegen
    {
        public void infinitegenExecute()
        {
            while (true)
            {
                Random random = new Random();
                int answer = random.Next(1, 201);
                string textanswer = answer.ToString();
                Console.WriteLine(textanswer);
                Thread.Sleep(450);
            }
        }
    }
}
