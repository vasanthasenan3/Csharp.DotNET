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

namespace clses
{
    /// <summary>
    /// Interaction logic for StringFunctions.xaml
    /// </summary>
    public partial class StringFunctions : Window
    {

        

        private void Replace_Click(object sender, RoutedEventArgs e)
        {
            string text = txtinput.Text;
            string replacing = text.Replace(txtinput.Text , "kanishka");
            txtoutput.Text = replacing;
        }

        private void StartsWith_Click(object sender, RoutedEventArgs e)
        {
            string text = txtinput.Text;
            bool result = text.StartsWith("Mr");
            txtoutput.Text = result.ToString ();
        }

        private void EndsWith_Click(object sender, RoutedEventArgs e)
        {
            string text = txtinput.Text;
            bool result = text.EndsWith(".");
            txtoutput.Text = result.ToString();
        }

        private void Contains_Click(object sender, RoutedEventArgs e)
        {
            string text = txtinput.Text;
            bool result = text.Contains("@");
            txtoutput.Text = result.ToString();
        }

        private void Toupper_Click(object sender, RoutedEventArgs e)
        {
            string text = txtinput.Text;
            string name = char.ToUpper(text[0]).ToString();
            string names = text[1..].ToString();
            string result = name + names;
            txtoutput.Text = result.ToString();
        }

        private void ToLower_Click(object sender, RoutedEventArgs e)
        {
            string text = txtinput.Text;
            string names = text[0..].ToLower().ToString();
            txtoutput.Text = names.ToString();
        }

        private void NullCheck_Click(object sender, RoutedEventArgs e)
        {
         string text = txtinput.Text;
         bool result = string.IsNullOrEmpty(text);
         txtoutput.Text = result.ToString();

        }

        private void IndexOf_Click(object sender, RoutedEventArgs e)
        {
            string text = txtinput.Text;
            string name = text.IndexOf("u").ToString();
            txtoutput.Text = name.ToString();

        }

        private void Split_Click(object sender, RoutedEventArgs e)
        {
            
            string[] name = txtinput.Text.Split(',');
            MessageBox.Show(name.ToString());
        }

        private void Join_Click(object sender, RoutedEventArgs e)
        {
            string text = txtinput.Text;
            string[] name = { txtinput.Text };
            string result = string.Join("-", name);
            txtoutput.Text = result;

        }

        private void Substring_Click(object sender, RoutedEventArgs e)
        {
         string text = txtinput.Text;
         string names = text.Substring(1);
            txtoutput.Text = names;
        }

        private void Whitspacecheck_Click(object sender, RoutedEventArgs e)
        {
            string text = txtinput.Text;
            bool result = string.IsNullOrWhiteSpace(text);
            txtoutput.Text = result.ToString();

        }

        private void LastIndexOf_Click(object sender, RoutedEventArgs e)
        {
            string text = txtinput.Text;
            string name = text.LastIndexOf("u").ToString();
            txtoutput.Text = name.ToString();

        }

        private void Trimstend_Click(object sender, RoutedEventArgs e)
        {
            //string text = txtinput.Text;
            //string name = text.TrimEnd();
            //txtoutput.Text = name.ToString();

            //string text = txtinput.Text;
            //string name = text.TrimStart();
            //txtoutput.Text = name.ToString();

            string text = txtinput.Text;
            string name = text.Trim();
            txtoutput.Text = name.ToString();
        }
    }
}
