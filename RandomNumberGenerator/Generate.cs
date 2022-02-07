using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    public class Generate
    {
        public string? number { get; set; }
        public void GenerateNum()
        {
            Random random = new Random();
            int answer = random.Next(1, 201);
            string textanswer = answer.ToString();
            number = textanswer;
        }
    }
}
