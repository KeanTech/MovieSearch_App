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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkoleOpgave_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        public int CalculateAdd(int number1, int number2)
        {
            return number1 + number2;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            this.ResultWindow.Text = CalculateAdd(int.Parse(Number1.Text), int.Parse(Number2.Text)).ToString();
        }

        private void Number1_MouseEnter(object sender, MouseEventArgs e)
        {
            int number;
            if (int.TryParse(Number1.Text, out number))
            {
                Number1.Text = number.ToString();
            }
            else
            {
                Number1.Text = "";
            }
        }
        private void Number2_MouseEnter(object sender, MouseEventArgs e)
        {
            int number;
            if(int.TryParse(Number2.Text, out number))
            {
                Number2.Text = number.ToString();
            }
            else
            {
                Number2.Text = "";
            }
            
        }
        private void Number1_MouseLeave(object sender, MouseEventArgs e)
        {
            int number;
            if (int.TryParse(Number1.Text, out number))
            {
                Number1.Text = number.ToString();
            }
            else
            {
                Number1.Text = "Number";
            }
        }
        private void Number2_MouseLeave(object sender, MouseEventArgs e)
        {
            int number;
            if(int.TryParse(Number2.Text, out number))
            {
                Number2.Text = number.ToString();
            }
            else
            {
                Number2.Text = "Number";
            }
        }

     
    }
}
