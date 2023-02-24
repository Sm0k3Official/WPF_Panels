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

namespace WPF_Panels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IWindow
    {
        private bool areEventsChecked { set; get; }

        private DontClickMeWindow dontClickMeWindow;
        private LoginWindow loginWindow;

        public MainWindow()
        {
            InitializeComponent();

            areEventsChecked = false;
            logoutButton.IsEnabled = false;

            dontClickMeButton.Visibility = Visibility.Hidden;
            eventsCheckBox.Visibility = Visibility.Hidden;
            bunVenitLabel.Visibility = Visibility.Hidden;
        }

        public void CloseAllWindows()
        {
            if (dontClickMeWindow != null && dontClickMeWindow.IsEnabled)
            {
                dontClickMeWindow.Close();
            }

            if (loginWindow != null && loginWindow.IsEnabled)
            {
                loginWindow.Close();
            }
        }

        //Don't click me methods
        private void Button_DontClickMe(object sender, RoutedEventArgs e)
        {
            dontClickMeWindow = new DontClickMeWindow(this);

            if (areEventsChecked)
            {
                dontClickMeWindow.Closed += DontClickMeWindow_Closed;
                dontClickMeWindow.Show();

                dontClickMeButton.IsEnabled = false;

                this.Hide();
            }
            else 
            {
                dontClickMeWindow.ShowDialog();
            }
        }

        private void DontClickMeWindow_Closed(object sender, EventArgs e)
        {
            dontClickMeButton.IsEnabled = true;
        }
        
        //Checkbox for activating or deactivating the events
        private void CheckBox_Events(object sender, RoutedEventArgs e)
        {
            areEventsChecked = true;
        }

        private void UncheckBox_Events(object sender, RoutedEventArgs e)
        {
            areEventsChecked = false;
        }

        //Login methods
        private void Button_Login(object sender, RoutedEventArgs e)
        {
            loginWindow = new LoginWindow(this);
            loginWindow.ShowDialog();
        }

        //Logout methods
        private void Button_Logout(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();

            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            CloseAllWindows();

            base.OnClosed(e);
        }
    }
}
