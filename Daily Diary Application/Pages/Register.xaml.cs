using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using Newtonsoft.Json;

namespace DailyDairyApplication
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        List<Users> olist = new List<Users>();
        string rootpath;
        string projectfolder;
        string filepath;
        public Register()
        {
            InitializeComponent();
            rootpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            projectfolder = Path.Combine(rootpath, "DailyDiary");
            Directory.CreateDirectory(projectfolder);
            filepath = Path.Combine(projectfolder, "Users.Json");
            //string data = File.ReadAllText(filepath);
            //olist = JsonConvert.DeserializeObject<List<Users>>(data);
            lstdata.ItemsSource = null;
            lstdata.ItemsSource = olist;
        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        { 
           
            Namerequiredvalidation();
            Usernamevalidation();
            Emailvalidation();
            Passwordcompare();
            
            Users users = new Users();
            //string data = File.ReadAllText(filepath);
            //olist = JsonConvert.DeserializeObject<List<Users>>(data); 
            users.Name = txtname.Text;
            users.Username = txtusername.Text;
            users.Email = txtemail.Text;
            users.Password = pwpassword.Password;
            olist.Add(users);
            string output = JsonConvert.SerializeObject(olist);
            File.WriteAllText(filepath, output);
            lstdata.ItemsSource = null;
            lstdata.ItemsSource = olist;
            MessageBox.Show("Succesfully Registerd");
        }
        private void Namerequiredvalidation()
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                txtname.BorderBrush = Brushes.Red;
            }
            else
            {
                txtname.BorderBrush = Brushes.Black;
            }
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                txtname.BorderBrush = Brushes.Red;
            }
            else
            {
                txtname.BorderBrush = Brushes.Black;
            }
        }
        private void Usernamevalidation()
        {
            if (string.IsNullOrWhiteSpace(txtusername.Text))
            {
                txtusername.BorderBrush = Brushes.Red;
            }
            else
            {
                txtusername.BorderBrush = Brushes.Black;
            }
        }
        private void Passwordcompare()
        {
            if (pwpassword.Password != pwconfirmpassword.Password)
            {
                pwpassword.BorderBrush = Brushes.Red;
                pwconfirmpassword.BorderBrush = Brushes.Red;
            }
            else
            {
                pwpassword.BorderBrush = Brushes.Black;
                pwconfirmpassword.BorderBrush = Brushes.Black;
            }

        }
        private void Emailvalidation()
        {

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isvalid = Regex.IsMatch(txtemail.Text, pattern);
            if (!isvalid)
            {
                txtemail.BorderBrush = Brushes.Red;
            }
            else
            {
                txtemail.BorderBrush = Brushes.Black;
            }
        }


        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
           
            var item = from x in olist
                       where x.Name.ToLower().Contains(txtsearch.Text.ToLower()) ||
                             x.Username.ToLower().Contains(txtsearch.Text.ToLower()) ||
                             x.Email.ToLower().Contains(txtsearch.Text.ToLower())
                       select x;
            lstdata.ItemsSource = null;
            lstdata.ItemsSource = item.ToList();

        }


        private void btnregs_Click_1(object sender, RoutedEventArgs e)
        {
         Login ologin = new Login();
            ologin.Show();
            this.Close();
        }
    }  
}
