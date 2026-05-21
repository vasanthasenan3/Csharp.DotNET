using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string username = "Admin";
        string password = "vk0409";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtusername.Text == username && txtpassword.Password == password)
            {
                Logic  ohome = new Logic ();
                ohome.Show();
            }
               
            else
            {
                MessageBox.Show("Ivalid Username And Password");
            }
        }
        
    }
}
