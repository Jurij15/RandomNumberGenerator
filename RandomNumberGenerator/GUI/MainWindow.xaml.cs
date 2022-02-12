using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RandomNumberGenerator.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string? number { get; set; }
        public void generateinternal()
        {
            Random random = new Random();
            int answer = random.Next(1, 201);
            string textanswer = answer.ToString();
            number = textanswer;
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
