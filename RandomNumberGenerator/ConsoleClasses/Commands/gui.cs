using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using RandomNumberGenerator.GUI;

namespace RandomNumberGenerator.ConsoleClasses.Commands
{
    public class gui
    {
        public void guiexecute()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowInTaskbar = false;
            mainWindow.ShowDialog();
            Console.WriteLine("Opened GUI");
        }
    }
}
