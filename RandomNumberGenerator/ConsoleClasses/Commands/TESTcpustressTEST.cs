using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RandomNumberGenerator.ConsoleClasses.Commands
{
    public class TESTcpustressTEST
    {
        public void cpustresstestexecute()
        {
            static void Main(string[] args)
            {
                for (int ix = 0; ix < Environment.ProcessorCount; ++ix)
                {
                    new Thread(loopForever).Start();
                }
            }
            static void loopForever()
            {
                while (true) ;
            }
        }
    }
}
