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

namespace Lab2
{
    public partial class MainWindow : Window
    {
        private IArray array1;
        private IArray array2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int size = int.Parse(FirstSize.Text);
                var random = new Random();
                var elements = Enumerable.Range(0, size).Select(_ => random.Next(100)).ToList();

                if (IsSortArray.IsChecked == true)
                {
                    array1 = new SortArray(elements);
                    ResFirst.Text = "SortArray: " + string.Join(", ", array1.Elements);
                }
                else if (IsXorArray.IsChecked == true)
                {
                    array1 = new XorArray(elements);
                    ResFirst.Text = "XorArray: " + string.Join(", ", array1.Elements);
                }
            }
            catch (Exception ex)
            {
                ResFirst.Text = "Error: " + ex.Message;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int size = int.Parse(FirstSize.Text);
                var random = new Random();
                var elements = Enumerable.Range(0, size).Select(_ => random.Next(100)).ToList();

                if (IsSortArray.IsChecked == true)
                {
                    array2 = new SortArray(elements);
                    array1.Add(array2);
                    ResFirst.Text = "SortArray after Add: " + string.Join(", ", array1.Elements);
                }
                else if (IsXorArray.IsChecked == true)
                {
                    array2 = new XorArray(elements);
                    array1.Add(array2);
                    ResFirst.Text = "XorArray after Add: " + string.Join(", ", array1.Elements);
                }
            }
            catch (Exception ex)
            {
                ResFirst.Text = "Error: " + ex.Message;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                array1.Foreach();
                if (IsSortArray.IsChecked == true)
                {
                    ResFirst.Text = "SortArray after Foreach: " + string.Join(", ", array1.Elements);
                }
                else if (IsXorArray.IsChecked == true)
                {
                    ResFirst.Text = "XorArray after Foreach: " + string.Join(", ", array1.Elements);
                }
            }
            catch (Exception ex)
            {
                ResFirst.Text = "Error: " + ex.Message;
            }
        }

    }
}