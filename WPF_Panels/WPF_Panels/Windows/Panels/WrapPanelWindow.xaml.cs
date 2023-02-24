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

namespace WPF_Panels.Panels
{
    /// <summary>
    /// Interaction logic for WrapPanel.xaml
    /// </summary>
    public partial class WrapPanelWindow : Window
    {
        private Button button;

        public WrapPanelWindow(Button button)
        {
            InitializeComponent();

            this.button = button;
            button.IsEnabled = false;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = false;

            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            button.IsEnabled = true;
        }
    }
}
