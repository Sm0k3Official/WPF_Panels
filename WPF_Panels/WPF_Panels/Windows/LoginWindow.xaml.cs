﻿using System;
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

        private string imageURI = "\\Resources\\Logo.png";

        public LoginWindow(MainWindow newMainWindow)
        {
            InitializeComponent();

            mainWindow = newMainWindow;
        }
        public void DisplayLogo()
        {
            mainWindow.usernameLabel.Content = username.Text.ToString();

            BitmapImage image = new BitmapImage(new Uri(imageURI, UriKind.Relative)); 

            mainWindow.logoImage.Source = image;
            mainWindow.logoImage.Height = image.Height/2;
            mainWindow.logoImage.Width = image.Width/2;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if(username.Text!="" && parola.Password.ToString()!="")
            {
                DisplayLogo();
                
                mainWindow.loginButton.IsEnabled = false;
                mainWindow.logoutButton.IsEnabled = true;

                mainWindow.dontClickMeButton.Visibility = Visibility.Visible;
                mainWindow.eventsCheckBox.Visibility = Visibility.Visible;
                mainWindow.bunVenitLabel.Visibility = Visibility.Visible;

                this.Close();
            }
            else
            {
                mesaj.Content = "Date insuficiente!";
            }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OK_Click(sender, e);
        }
    }
}
