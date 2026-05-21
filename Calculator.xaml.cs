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

namespace practiceforundsd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string firstnumber = " ";
        string secondnumber = " ";
        string oper = " ";

        private void Number_click (object sender, RoutedEventArgs e)
        {
         Button btnnumber = (Button)sender;
            if (oper == " ")
            {
                firstnumber = firstnumber + btnnumber.Content.ToString();
                txtresult.Text = firstnumber;
            }
            else
            {
                secondnumber = secondnumber + btnnumber.Content.ToString();
                txtresult.Text = secondnumber;
            }

        }

        private void Oper_click(object sender, RoutedEventArgs e)
        {
            Button btnoper = (Button)sender;
            oper = btnoper.Content.ToString();
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = " ";
            secondnumber = " ";
            oper = " ";
            txtresult.Text = " ";
        }

        private void btnequal_Click(object sender, RoutedEventArgs e)
        {

            int first = Convert.ToInt16(firstnumber);
            int second = Convert.ToInt16(secondnumber);
            int result = 0;
            if (oper == "+")
            {
                result = first + second;
                txtresult.Text = Convert.ToString(result);
            }
            else if (oper == "-")
            {
                result = first-second;
                txtresult.Text = Convert.ToString(result);
            }
            else if (oper == "*")
            {
                result = first * second;
                txtresult.Text = Convert.ToString(result);
            }
            else if (oper == "/")
            {
                result = first / second;
                txtresult.Text = Convert.ToString(result);
            }






        }
    }
}