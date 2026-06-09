using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using Newtonsoft.Json;

namespace clses
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string welcome = "Welcome Mrs" + txtusernam.Text.Replace("Vasanth", "Kani");
            //MessageBox.Show(welcome);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string rootpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            string projectfolder = Path.Combine(rootpath, "BillApp");
            string filepath = Path.Combine(projectfolder, $"{txtusername.Text}.txt");
            if (File.Exists(filepath))
            {
                string value = File.ReadAllText(filepath);
                User userdata = JsonConvert.DeserializeObject<User>(value);
                if (userdata.Username == txtusername.Text && userdata.Password==txtpass.Password)
                {
                    MessageBox.Show("Valid User");
                }
                else
                {
                    MessageBox.Show("InvalidUser");
                }
                
            }
            else
            {
                MessageBox.Show("InvalidUser");
            }
















            //////if (string.IsNullOrWhiteSpace(txtusername.Text)== false )
            //////   {
            //////       char[] names = txtusername.Text.ToCharArray();
            //////       string name1 = names[0].ToString().ToUpper();
            //////       string remain = txtusername.Text.Substring(1).ToLower();
            //////       MessageBox.Show(name1 + remain);
            //////   }
            /////
            //string text = txtusername.Text;
            //// if(!string.IsNullOrWhiteSpace(txtusername.Text))
            ////{
            ////    string first = char.ToUpper(text[0]).ToString();
            ////    string remaining = text.Substring(1).ToLower();
            ////    string correct = first + remaining;
            ////    MessageBox.Show(correct);
            ////}

            //if (!string.IsNullOrWhiteSpace(txtusername.Text))
            //{
            //    string first = char.ToUpper(text[0]).ToString();
            //    string remaining = text[1..].ToLower();
            //    string correct = first + remaining;
            //    MessageBox.Show(correct);
            //}


            //string removing = text.Remove(3,7);
            //MessageBox.Show(removing);


            ////string name = txtusername.Text.ToLower();
            ////string uname = txtusername.Text.ToUpper();
            ////if(txtusername.Text.ToLower ()  == "vasanth")
            ////{
            ////    MessageBox.Show("Valid User");
            ////}







            //int i = 10;
            //string k = "vasanth";
            //    bool b = true;
            //char c = 'a';
            //object value = 10;
            //value = "kani";
            //value = i;

            //if ( value is string)
            //{
            //    string output = Convert.ToString(value);
            //    MessageBox.Show(output);
            //}
            //else if(value is int)
            //{
            //    int numb = Convert.ToInt32(value);
            //    MessageBox.Show(numb.ToString());
            //}


            //dynamic value1 = 10;
            //value1 = "kanishka";
            //int s = 17;
            //value1 = s;

            //int outp = s;

            //    MessageBox.Show(outp.ToString());

            //string outpt = value1;

            //MessageBox.Show(outpt);

        }
    }
}