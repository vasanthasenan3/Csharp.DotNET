using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Text.Json;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Xml.Linq;


namespace DailyDairyApplication
{
    public partial class Expences : Page
    {
        string rootpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string projectfolder;
        string expencesfilepath;
        List<Expense> expences = new List<Expense>();
        public Expences()
        {
            InitializeComponent();
            projectfolder = Path.Combine(rootpath, "DailyDiary");
            Directory.CreateDirectory(projectfolder);
            expencesfilepath = Path.Combine(projectfolder, "Expences.Json");
            LoadExpences();
        }
        private void LoadExpences()
        {
            if (File.Exists(expencesfilepath))
            {
                expences = JsonSerializer.Deserialize<List<Expense>>
                    (File.ReadAllText(expencesfilepath))
                    ?? new List<Expense>();
            }


            var userExpenses = expences
                .Where(e => e.Username == Users.LoggedInUsername)
                .OrderByDescending(e => e.Date)
                .ToList();



            lstExpenses.Items.Clear();


            double total = 0;


            foreach (var expense in userExpenses)
            {
                lstExpenses.Items.Add(
                    $"{expense.Date:dd-MM-yyyy}  - {expense.productname}  ₹{expense.Amount}"
                );


                total += expense.Amount;
            }


            txtTotal.Text = $"Total Expense: ₹{total}";
        }
        private void SaveExpenses()
        {
            File.WriteAllText(
                expencesfilepath,
                JsonSerializer.Serialize(expences,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExpense.Text))
            {
                MessageBox.Show("Enter expense Name");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Enter expense amount");
                return;
            }


            if (!double.TryParse(txtAmount.Text, out double amount))
            {
                MessageBox.Show("Enter valid amount");
                return;
            }


            Expense expense = new Expense
            {
                Username = Users.LoggedInUsername,
                Date = DateTime.Now,
                productname = txtExpense.Text,
                Amount = amount
            };


            expences.Add(expense);


            SaveExpenses();


            txtAmount.Clear();


            LoadExpences();
        }
    }
}
