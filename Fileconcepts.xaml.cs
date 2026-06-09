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
using System.IO;

namespace Practiceforunstd2
{
    /// <summary>
    /// Interaction logic for Fileconcepts.xaml
    /// </summary>
    public partial class Fileconcepts : Window
    {
        public Fileconcepts()
        {
            InitializeComponent();
        }

    
        private void createfile_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("C:\\images\\vsn.txt"))
            {
                File.Create("C:\\images\\vsn.txt");
                MessageBox.Show("File Created");
            }
        }

        private void writeclick_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("C:\\images\\vsn.txt"))
            {
                File.WriteAllText("C:\\images\\vsn.txt", "Let It Be" );
                MessageBox.Show("File Was Written");
            }
            else
            {
                MessageBox.Show("File Already Exists");
            }
        }

        private void readclick_Click(object sender, RoutedEventArgs e)
        {
            string value = File.ReadAllText("C:\\images\\vsn.txt");
            MessageBox.Show(value);
        }

        private void deleteclick_Click(object sender, RoutedEventArgs e)
        {
            File.Delete("C:\\images\\vsn.txt");
            MessageBox.Show("File Deleted");
        }

        private void foldercreate_Click(object sender, RoutedEventArgs e)
        {
            if (!Directory.Exists("C:\\images\\student"))
            {
                Directory.CreateDirectory("C:\\images\\student");
            }
            else
            {
                MessageBox.Show("File Already Exists");
            }
        }
        private void getfiles_Click(object sender, RoutedEventArgs e)
        {
            string[] filpath = Directory.GetFiles("C:\\images\\student");
            foreach (string filenames in filpath) 
            {
                MessageBox.Show(filenames);
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Directory.Delete("C:\\images\\student");
        }
    }
}
