using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RandomNumberGenerator.ConsoleClasses.Commands
{
    public class ver
    {
        public void verexecute()
        {
            Console.WriteLine("Version 1.0");
            System.Windows.MessageBox.Show("Version 1.0");
        }
    }
}
