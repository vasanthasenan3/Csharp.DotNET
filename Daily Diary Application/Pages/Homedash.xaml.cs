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
using System.Windows.Navigation;
using System.Xml.Linq;
using System.Text.Json;
using Newtonsoft.Json;
namespace DailyDairyApplication
{

    public partial class Homedash : Page
    {
        string rootpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string projectfolder;
        string filepath;
        string diarypath;
        public Homedash()
        {
            InitializeComponent();
            projectfolder = Path.Combine(rootpath, "DailyDiary");
            Directory.CreateDirectory(projectfolder);
            filepath = Path.Combine(projectfolder, "Users.Json");
            diarypath = Path.Combine(projectfolder, "Diary.Json");
            LoadUserDetails();
            LoadDiaryDetails();
        }
        private void LoadUserDetails()
        {
            if (!File.Exists(filepath))
                return;


            List<Users> users = JsonConvert.DeserializeObject<List<Users>>
               (File.ReadAllText(filepath))
               ?? new List<Users>();

            if (users.Count == 0)
                return;

            //// Currently loading first user
            Users ousers = users.First();
            txtName.Text = ousers.Name; 
            txtEmail.Text = ousers.Email;
            
            


        }
        private void LoadDiaryDetails()
        {
            if (!File.Exists(diarypath))
                return;


            List<Diary> entries =
                JsonConvert.DeserializeObject<List<Diary>>
                (File.ReadAllText(diarypath))
                ?? new List<Diary>();
           Diary odiary = entries.First();
            txtAboutMe.Text = odiary.AboutMe;

            if (!string.IsNullOrWhiteSpace(odiary.PhotoPath) &&
                File.Exists(odiary.PhotoPath))
            {
                imgProfile.ImageSource =
                    new BitmapImage(new Uri(odiary.PhotoPath));
            }

            // Show current user's diary
            var userEntries = entries.Where(e => e.Username == Users.LoggedInUsername)
                .OrderByDescending(e => e.Date)
                .ToList();


            lstDiary.ItemsSource = userEntries;
        }

   }
}


