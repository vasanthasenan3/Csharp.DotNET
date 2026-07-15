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

namespace DailyDairyApplication
{
    /// <summary>
    /// Interaction logic for DashBoard.xaml
    /// </summary>
    public partial class DashBoard : Window
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void newentry_Click(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(new DiaryEntry());

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(new Homedash());
        }

       

   

       
        private void myprofile_Click(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(new Profilepage());
        }

        private void myexpences_Click(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(new Expences());
        }

        private void btnlogout_Click_1(object sender, RoutedEventArgs e)
        {
            Users.LoggedInUsername = string.Empty;

            Application.Current.Shutdown();
        }
    }
}
