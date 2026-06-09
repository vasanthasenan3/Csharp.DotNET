using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace clses
{
    /// <summary>
    /// Interaction logic for Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("ta-IN");

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User ouser = new User();
            ouser.Name = txtname.Text;
            ouser.Username = txtusername.Text;
            ouser.Password = txtpassword.Password;
            ouser.Adress = txtadress.Text;
            ouser.Position = txtposition.Text;
            ouser.Degree = txtdegree.Text;
            string content = JsonConvert.SerializeObject(ouser);
            string rootpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            string projectfolder = Path.Combine(rootpath, "BillApp");
            Directory.CreateDirectory(projectfolder);
            string filepath = Path.Combine(projectfolder, $"{txtusername.Text}.txt");
            if(File.Exists(filepath))
            {
                MessageBox.Show("Please Choose Different Username");
            }
            else
           { File.WriteAllText(filepath, content);
                MessageBox.Show("Register Success");
           }





//            string offerletter = $@"OFFER LETTER
//            Date: {DateTime.Now:dd/MM/yyyy}
//            Dear {txtname.Text},
//
//           We are pleased to offer you the position of Software Engineer at Accenture
//           Details:

//           Name: {txtname.Text}
//           Address:{txtadress.Text}
//           Position:{txtposition.Text}
//           Degree:{txtdegree.Text}
//           We look forward to having you on our team.

//           Sincerely,
//           HR Manager
//           Team ACCENTURE";
//           txtoffer.Text = offerletter;

//            //offerletter = offerletter.Replace("{date}", DateTime.Now.ToString());
//            //offerletter = offerletter.Replace("{adress}", txtadress.Text);
//            //offerletter = offerletter.Replace("{name}", txtname.Text);
//            //offerletter = offerletter.Replace("{position}", txtposition.Text);
//            //offerletter = offerletter.Replace("{degree}", txtdegree.Text);
//            //offerletter = offerletter.Replace("{Comapny}", "Team Accenture");
//            //txtoffer.Text = offerletter;
         }
    }
}
