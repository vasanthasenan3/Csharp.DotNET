using Microsoft.Win32;
using Newtonsoft.Json;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;


namespace DailyDairyApplication
{
    /// <summary>
    /// Interaction logic for Profilepage.xaml
    /// </summary>
    public partial class Profilepage : Page
    {
        List<Diary> diaries = new List<Diary>();
        string rootpath;
        string Diarypath;
        string projectfolder;
        string selectedphoto;
        public Profilepage()
        {
            InitializeComponent();
            rootpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            projectfolder = Path.Combine(rootpath, "DailyDiary");
            Directory.CreateDirectory(projectfolder);
            Diarypath = Path.Combine(projectfolder, "Diary.Json");
            Loadprofile();
        }


        private void Loadprofile()
        {
            if (!File.Exists(Diarypath))
                return;


            List<Diary> odiary = JsonConvert.DeserializeObject<List<Diary>>
                (File.ReadAllText(Diarypath)) ?? new List<Diary>();


            Diary user = odiary.FirstOrDefault();

            if (user == null)
                return;
            // Load About Me
            txtabout.Text = user.AboutMe;


            // Load Photo
            if (!string.IsNullOrEmpty(user.PhotoPath) &&
                File.Exists(user.PhotoPath))
            {
                imgBrush.ImageSource =
                    new BitmapImage(new Uri(user.PhotoPath));
            }

            selectedphoto = user.PhotoPath;
        }
        
       
        private void btnsavechanges_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(Diarypath))
            {
                MessageBox.Show("User data not found.");
                return;
            }


            List<Diary> users = JsonConvert.DeserializeObject<List<Diary>>
                (File.ReadAllText(Diarypath)) ?? new List<Diary>();


            Diary user = users.FirstOrDefault();


            if (user == null)
                return;


            // Update Profile Data
            user.AboutMe = txtabout.Text;
            user.Time = DateTime.Now.ToString("hh:MM");
            user.PhotoPath = selectedphoto;



            // Save back to JSON  
            File.WriteAllText(Diarypath,
           JsonConvert.SerializeObject(users, Formatting.Indented));


            MessageBox.Show("Profile Updated Successfully!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == true)
            {
                selectedphoto = openFileDialog.FileName;
                imgBrush.ImageSource = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }
    }
}
