using DailyDairyApplication;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Newtonsoft.Json;
using System.Windows.Media.Imaging;

using System.Windows.Navigation;
using static System.Collections.Specialized.BitVector32;


namespace DailyDairyApplication
{
    /// <summary>
    /// Interaction logic for DiaryEntry.xaml
    /// </summary>
    public partial class DiaryEntry : Page
    { 
        List<Diary> diaries = new List<Diary>();
        string rootpath;
        string Diarypath;
        string projectfolder;
        public DiaryEntry()
        {
            InitializeComponent();
            rootpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            projectfolder = Path.Combine(rootpath, "DailyDiary");
            Directory.CreateDirectory(projectfolder);
            Diarypath = Path.Combine(projectfolder, "Diary.Json");
            txtdate.Text = DateTime.Now.ToString();
            dpDate.SelectedDate = DateTime.Today;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            List<Diary> diaries = new List<Diary>();

            if (File.Exists(Diarypath))
            {
                string json = File.ReadAllText(Diarypath);

                diaries = JsonConvert.DeserializeObject<List<Diary>>(json)
                          ?? new List<Diary>();
            }

            diaries.Add(new Diary
            {
                Title = txttittle.Text,
                Date = txtdate.Text,
                Time = DateTime.Now.ToString("hh:mm"),
                Content = txtcontent.Text
            });

            File.WriteAllText(Diarypath,
                JsonConvert.SerializeObject(diaries,
               Formatting.Indented));

            MessageBox.Show("Diary Entry Saved Successfully!");

            dpDate.SelectedDate = DateTime.Today;
            txtdate.Text = DateTime.Now.ToString("hh:mm tt");
            txtdate.Clear();
        }

       

        private void dpDate_SelectedDateChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (dpDate.SelectedDate.HasValue)
            {
                txtdate.Text = dpDate.SelectedDate.Value.ToString("dd/MM/yyyy");
            }
        }
    }
}
