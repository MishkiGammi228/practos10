using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_10
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
        List<int> _list = new List<int>();

        private void добавить_Click(object sender, RoutedEventArgs e)
        {
            int maxEven = int.MinValue;
            int minimumMultiple = int.MaxValue;
            if (Int32.TryParse(value.Text, out int Value) && Int32.TryParse(multiple.Text, out int multipleNumber))
            {
                _list.Add(Value);
                listBox.Items.Add(Value);
                int[] array = new int[_list.Count];
                array = _list.ToArray();
                for (int i = 0; i < array.Length; i++)
                {
                    if (maxEven < array[i] && array[i] % 2 == 0)
                    {
                        maxEven = array[i];
                    }
                    if (minimumMultiple > array[i] && multipleNumber % array[i] == 0)
                    {
                        minimumMultiple = array[i];
                    }
                }
                rez.Text = $" максимальное четное число = {maxEven}, минимальное число, кратное {minimumMultiple} = {multipleNumber }";
            }
            else
            {
                MessageBox.Show("Поля не заполнены или заполнены неверно");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            rez.Clear();
            listBox.Items.Clear();
            value.Clear();
            multiple.Clear();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В одномерном массиве целых чисел найти максимальный среди элементов,являющихся четными, и минимальный среди элементов, кратных А.");
        }

        private void Exite_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
