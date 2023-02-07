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
            imgPath = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 24).ToString();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            phoneListBox.Items.Clear();
            phoneListBox.ItemsSource = new[] {
                new Contact()
                {
                    ImagePath = imgPath + "\\Images\\kittens3.jpg",
                    Name = "kittens4",
                    Phone = 79090095563
                },
                new Contact()
                {
                    ImagePath = imgPath + "\\Images\\kittens2.jpg",
                    Name = "kittens5",
                    Phone = 79092195563
                }
            };
        }

        private void ShowContact(object sender, SelectionChangedEventArgs args)
        {
            Contact contact = ((sender as ListBox).SelectedItem as Contact);
            contactBottom.Text = "Выбран контакт: " + contact.Name;
        }
    }
}
