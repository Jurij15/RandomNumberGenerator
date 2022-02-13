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
            Console.WriteLine("GUI::Generated a number");
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenBtn_Click(object sender, RoutedEventArgs e)
        {
            generateinternal();
            GenNumBox.Text = number;
        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            string message = "Made by Jurij15, version 1.0";
            string caption = "About";
            MessageBoxButton buttons = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBoxResult result = MessageBox.Show(message, caption, buttons, icon);
            Console.WriteLine("GUI::Opened AboutBox");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Console.WriteLine("GUI::GUI closed");
        }
    }
}
