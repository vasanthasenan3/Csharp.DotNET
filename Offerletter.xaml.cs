using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace offerletter
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
            //string offerletter = "Offer Letter\r\n\r\nDate: {date} \r\nName: {name}  \r\nAddress: {adress}  \r\nPosition: {position}  \r\nDegree: {degree}  \r\n\r\nDear {name},  \r\nWe are pleased to offer you the role of {position} Your {degree} makes you a strong fit for our team.  \r\n\r\nSincerely,  \r\n Team Accenture \r\n\r\n\r\n\r\n";
            //offerletter = offerletter.Replace("{date}", DateTime.Now.ToString());
            //offerletter = offerletter.Replace("{adress}", txtadress.Text);
            //offerletter = offerletter.Replace("{name}", txtname.Text);
            //offerletter = offerletter.Replace("{position}", txtposition.Text);
            //offerletter = offerletter.Replace("{degree}", txtdegree.Text);
            //offerletter = offerletter.Replace("{Comapny}", "Team Accenture");
            //txtoffer.Text = offerletter;

            string offerletter = $@"Offer Letter
            
            Date: {DateTime.Now:dd-MM-yyyy}
            Name: {txtname.Text}
            Address: {txtadress.Text}
            Position: {txtposition.Text}
            Degree: {txtdegree.Text}

            Dear {txtname.Text},
            We are pleased to offer you the role of {txtposition.Text}. Your {txtdegree.Text} makes you a strong fit for our team.
            Sincerely,
            Team Accenture";

            txtoffer.Text = offerletter;
        }
    }
}