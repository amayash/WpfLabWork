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

namespace WpfLabWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string imgPath;
        public MainWindow()
        {
            InitializeComponent();
            // после загрузки формы привязываем загрузку элементов листбокса
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            phoneListBox.Items.Clear();
            phoneListBox.ItemsSource = new[] {
                new Contact()
                {
                    ImagePath = "images/kittens3.jpg",
                    Name = "kittens3",
                    Phone = 79090095563
                },
                new Contact()
                {
                    ImagePath = "images/kittens2.jpg",
                    Name = "kittens2",
                    Phone = 79092195563
                }
            };
        }
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs args)
        {
            MessageBox.Show("Клик! Команда сработала.", "Результат");
        }

        private void ShowContact(object sender, SelectionChangedEventArgs args)
        {
            Contact contact = ((sender as ListBox).SelectedItem as Contact);
            contactInfoBottom.Text = "Информация";
            contactNameBottom.Text = "Имя контакта: " + contact.Name;
            contactPhoneBottom.Text = "Номер телефона: " + contact.Phone;
            infoBottom.Text = contact.Name;

            imageBottom.Source = new BitmapImage(new Uri(contact.ImagePath, UriKind.Relative));
        }
    }
}
