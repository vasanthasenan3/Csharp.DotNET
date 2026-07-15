using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Newtonsoft.Json;

namespace DailyDairyApplication
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }



        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            string rootpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string projectfolder = Path.Combine(rootpath, "DailyDiary");
            string filepath = Path.Combine(projectfolder, "Users.Json");
            if (File.Exists(filepath))
            {
                string value = File.ReadAllText(filepath);
                List<Users> userdata = JsonConvert.DeserializeObject<List<Users>>(value);
                bool found = false;
                foreach (Users users in userdata)
                {
                    if (users.Username == txtusername.Text && users.Password == pwpassword.Password)
                    {
                        found = true;
                        MessageBox.Show("Login Succesfully");
                        DashBoard dashBoard = new DashBoard();
                        dashBoard.Show();
                        this.Close();
                        break;
                    }
                }
                if(found == false)
                {
                    MessageBox.Show("Invalid Username And Password");
                }


            }
        }

      

        private void btnregs_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }
    }
}
