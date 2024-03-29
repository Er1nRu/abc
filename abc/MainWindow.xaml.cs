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

namespace abc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnSend.IsEnabled = false;
            dateList.ItemsSource = Person.List;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            var message = new Person(nickname.Text, date.Text);
            dateList.Items.Refresh();
        }

        private void nickname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(nickname.Text != "" & date.Text != "")
            {
                btnSend.IsEnabled = true;
            } 
            else
            {
                btnSend.IsEnabled = false;
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var select = dateList.SelectedIndex;
                Edit edit = new Edit(select);
                edit.ShowDialog();
                dateList.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}
