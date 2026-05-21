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
    /// Interaction logic for Logic.xaml
    /// </summary>
    public partial class Logic : Window
    {
        int[] numbers = { 1, 11, 2, 22, 3, 33, 4, 44, 5, 55 };
        string[] names = { "vasanthasenan", "kanisha", "ishu", "thiru", "nivetha" };
       

        private void btnnuumbers_Click(object sender, RoutedEventArgs e)
        {
            //   for (int i = 100; i <= 150; i++)
            //{
            //    MessageBox.Show(i.ToString());
            //}


            //int count = names.Length;
            //for (int i = 0; i <= count; i++)
            //{
            //    MessageBox.Show(names [i]);
            //}
            string[] product = txtnum.Text.Split(",");
            int count = product.Length;
            for (int i = 0; i <= count; i++)
                MessageBox.Show(product[i]);
            
            
           
        }
       
        private void btnsum_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
