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
using System.Windows.Shapes;

namespace abc
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        int SelectItem = 0;
        public Edit(int selectItem)
        {
            InitializeComponent();
            SelectItem = selectItem;
            var usr = Person.List[SelectItem];
            message.Text = usr.Date;
            name.Content = $"Сообщение от {usr.Nick}";
            btnSave.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person.List[SelectItem].Date = message.Text;
            this.Close();
        }

        private void message_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(message.Text != "")
            {
                btnSave.IsEnabled = true;
            }
            else
            {
                btnSave.IsEnabled = false;
            }
        }
    }
}
