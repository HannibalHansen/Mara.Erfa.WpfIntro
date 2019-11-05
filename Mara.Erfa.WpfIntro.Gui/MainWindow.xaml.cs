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

namespace Mara.Erfa.WpfIntro.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hej med dig", "Besked", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(sender != null)
            {
                if(textBoxName.Text.Length > 4)
                {
                    MessageBox.Show("","",MessageBoxButton.OK);
                }
            }
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            bool isChecked = false;
            if(checkBox.IsChecked.HasValue)
            {
                isChecked = checkBox.IsChecked.Value;
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = default;
            if(datePicker.SelectedDate.HasValue)
            {
                selectedDate = datePicker.SelectedDate.Value;
            }
            MessageBox.Show($"{selectedDate}", "Dato");
        }
    }
}
