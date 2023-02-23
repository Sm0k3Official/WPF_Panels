using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF_Panels
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private MainWindow mainWindow;
        public LoginWindow(MainWindow newMainWindow)
        {
            InitializeComponent();
            mainWindow = newMainWindow;
        }
        public void DisplayLogo()
        {
            mainWindow.bunVenit.Content = "Bun venit in echipa noastra, \n" + username.Text.ToString()+"\n\n\n\n Acesta este logo-ul companiei:";
            BitmapImage image = new BitmapImage(new Uri("D:\\Facultate\\Anul_2\\Sem2\\Medii vizuale de programare\\WPF_Panels\\Logo.png", UriKind.Absolute));
            mainWindow.logo.Source = image;
        }
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if(username.Text!="" && parola.Password.ToString()!="")
            {
                DisplayLogo();
                this.Close();
            }
            else
            {
                mesaj.Content = "Date insuficiente!";
            }
        }
    }
}
