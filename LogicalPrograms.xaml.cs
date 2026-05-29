using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace clses
{
    /// <summary>
    /// Interaction logic for LogicalPrograms.xaml
    /// </summary>
    public partial class LogicalPrograms : Window
    {
        public LogicalPrograms()
        {
            InitializeComponent();
        }

      

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int a = 10;
            if (a > 5)
            {
                MessageBox.Show("YES");
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            for(int i = 1; i<=5; i++)
            {
                if(i%2 == 0)
                {
                    MessageBox.Show(i.ToString());
                }
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string name = "Hello";
            MessageBox.Show(name.Length.ToString());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            for (int i = 5; i >= 1; i--) 
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string email = "test@gmail.com";
            MessageBox.Show(email.Contains("@").ToString());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            int age = 20;
            if(age > 18)
            {
                if(age < 25)
                {
                    MessageBox.Show("Young");
                }
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string word = "Google";
            MessageBox.Show(word.StartsWith("Go").ToString());
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            for(int i =1; i<=5; i++)
            {
                if(i==3)
                {
                    break;
                }
                MessageBox.Show(i.ToString());
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            string text = "Java";
            MessageBox.Show(text.Replace("Java", "C#"));
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            for(int i=1; i<=3; i++)
            {
                sum = sum + i;
            }
            MessageBox.Show(sum.ToString());
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            string city = "Chennai";
            MessageBox.Show(city.ToUpper());
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            int number = 7;
            if(number %2 == 0)
            {
                MessageBox.Show("Even");
            }
            else
            {
                MessageBox.Show("Odd");
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            string value = "DotNet";
            MessageBox.Show(value.Substring(0,3));
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i <= 3; i++) 
            {
                for (int j = 1; j <= 2; j++) 
                {
                    MessageBox.Show(i + "" + j);
                }
            }
        }
    }
}
