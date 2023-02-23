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

namespace WPF_Panels
{
    /// <summary>
    /// Interaction logic for DontClickMeWindow.xaml
    /// </summary>
    public partial class DontClickMeWindow : Window
    {
        public bool IsClosed { private set; get; }
        public DontClickMeWindow()
        {
            InitializeComponent();
            IsClosed = false;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            IsClosed = true;
        }
    }
}
