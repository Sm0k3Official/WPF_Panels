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

namespace WPF_Panels.Windows.Panels
{
    /// <summary>
    /// Interaction logic for GridSplitterWindow.xaml
    /// </summary>
    public partial class GridSplitterWindow : Window
    {
        private Button button;

        public GridSplitterWindow(Button button)
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
