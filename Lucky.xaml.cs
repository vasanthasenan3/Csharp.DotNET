using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace practiceforundsd
{
    /// <summary>
    /// Interaction logic for Lucky.xaml
    /// </summary>
    public partial class Lucky : Window
    {
        public Lucky()
        {
            InitializeComponent();
        }



        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = btn1.Tag;
            MessageBox.Show("you won" + btn1.Content.ToString());
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            btn2.Content = btn2.Tag;
            MessageBox.Show("you won" + btn2.Content.ToString());
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            btn3.Content = btn3.Tag;
            MessageBox.Show("you won" + btn3.Content.ToString());
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            btn4.Content = btn4.Tag;
            MessageBox.Show("you won" + btn4.Content.ToString());
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            btn5.Content = btn5.Tag;
            MessageBox.Show("you won" + btn5.Content.ToString());
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            btn6.Content = btn6.Tag;
            MessageBox.Show("you won" + btn6.Content.ToString());
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            btn7.Content = btn7.Tag;
            MessageBox.Show("you won" + btn7.Content.ToString());
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            btn8.Content = btn8.Tag;
            MessageBox.Show("you won" + btn8.Content.ToString());
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            btn9.Content = btn9.Tag;
            MessageBox.Show("you won" + btn9.Content.ToString());
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            btn10.Content = btn10.Tag;
            MessageBox.Show("you won" + btn10.Content.ToString());
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            btn11.Content = btn11.Tag;
            MessageBox.Show("you won" + btn9.Content.ToString());
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            btn12.Content = btn12.Tag;
            MessageBox.Show("you won" + btn12.Content.ToString());
        }
    }
}
