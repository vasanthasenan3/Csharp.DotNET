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
using System.Windows.Shapes;
using System.Collections;
using System.Collections.Specialized;
using System.Data.OracleClient;
using System.Threading.Tasks.Dataflow;

namespace Practiceforunstd2
{
    /// <summary>
    /// Interaction logic for Collections.xaml
    /// </summary>
    public partial class Collections : Window
    {
        public Collections()
        {
            InitializeComponent();
        }

        private void ArrayList_Click(object sender, RoutedEventArgs e)
        {   //ArrayList
            string[] name = { "Senan", "Kanishka", "Nivetha" };
            int[] nums = { 1, 2, 3, 4, 5 };
            ArrayList oarray = new ArrayList() { "Ishu", "Kani", "Nila" };
            oarray.Add("Vasanthasenan");
            oarray.Insert(1, "Deva");
            oarray.AddRange(name);
            oarray.InsertRange(0, nums);
            oarray.Remove("Senan");
            oarray.RemoveAt(7);
            oarray.RemoveRange(0,4);
            int count = oarray.Count;
            for(int i=0; i < count; i++)
            {
                MessageBox.Show(oarray[i].ToString());
            }
            foreach ( var items in oarray)
            {
                MessageBox.Show(items.ToString());
            }
        }

        private void Hashtable_Click(object sender, RoutedEventArgs e)
        {  //Hashtable
            Hashtable ohash = new Hashtable();
            ohash.Add("Name", "Vasanthasenan");
            ohash.Add("Age", "21");
            foreach (var items in ohash.Keys)
                MessageBox.Show(items.ToString());
            foreach (var item in ohash.Values)
                MessageBox.Show(item.ToString());
            foreach (DictionaryEntry items in ohash)
                MessageBox.Show(items.ToString());
        }

        private void Stack_Click(object sender, RoutedEventArgs e)
        {   //Stack LIFO
            Stack ostack = new Stack();
            ostack.Push("Vasanthasenan");
            ostack.Push("Kanisha");
            ostack.Push("ishu");
            string name = ostack.Peek().ToString();
            MessageBox.Show(name);
            ostack.Pop();
            string names = ostack.Peek().ToString();
            MessageBox.Show(names);
        }

        private void Queue_Click(object sender, RoutedEventArgs e)
        {   //Queue FIFO
            Queue oqueue = new Queue();
            oqueue.Enqueue("ishu");
            oqueue.Enqueue("kanishka");
            oqueue.Enqueue("vasanth");
            string name1 = oqueue.Peek().ToString();
            MessageBox.Show(name1);
            oqueue.Dequeue();
            string names1 = oqueue.Peek().ToString();
            MessageBox.Show(names1);

        }

        private void SortedList_Click(object sender, RoutedEventArgs e)
        {   //SortrdList
            SortedList olist = new SortedList();
            olist.Add("Z", "26");
            olist.Add("X", "24");
            olist.Add("A", "1");
        }

        private void BitArray_Click(object sender, RoutedEventArgs e)
        {   //BitArray
            BitArray obit = new BitArray(3);
            obit[0] = true;
            obit[1] = false;
            obit[2] = true;
        }

        private void ListDictionary_Click(object sender, RoutedEventArgs e)
        {   //ListDictionary - Similar to Hashtable but Efficient for small collections.

            ListDictionary lisdic = new ListDictionary();
            lisdic.Add("Name", "Vasanthasenan");
            lisdic.Add("Age", "21");
            foreach (var items in lisdic.Keys)
                MessageBox.Show(items.ToString());
            foreach (var item in lisdic.Values)
                MessageBox.Show(item.ToString());
            foreach (DictionaryEntry items in lisdic)
                MessageBox.Show(items.ToString());
        }

        private void HybridDictionary_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NamevalueCollection_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StringCollection_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StringDictionary_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
