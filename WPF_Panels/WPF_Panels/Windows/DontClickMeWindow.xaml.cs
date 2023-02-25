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
using WPF_Panels.Panels;
using WPF_Panels.Windows.Panels;

namespace WPF_Panels
{
    /// <summary>
    /// Interaction logic for DontClickMeWindow.xaml
    /// </summary>
    public partial class DontClickMeWindow : Window, IWindow
    {
        private MainWindow _mainWindow;

        private CanvasWindow canvasWindow;
        private WrapPanelWindow wrapPanel;
        private StackPanelWindow stackPanel;
        private DockPanelWindow dockPanel;
        private GridPanelWindow gridPanelWindow;
        private GridSplitterWindow gridSplitterWindow;
        
        public DontClickMeWindow(MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
        }

        public void CloseAllWindows()
        {
            if(canvasWindow != null && canvasWindow.IsEnabled)
            {
                canvasWindow.Close();
            }

            if (wrapPanel != null && wrapPanel.IsEnabled)
            {
                wrapPanel.Close();
            }

            if (stackPanel != null && stackPanel.IsEnabled)
            {
                stackPanel.Close();
            }

            if (dockPanel != null && dockPanel.IsEnabled)
            {
                dockPanel.Close();
            }

            if (gridPanelWindow != null && gridPanelWindow.IsEnabled)
            {
                gridPanelWindow.Close();
            }

            if (gridSplitterWindow != null && gridSplitterWindow.IsEnabled)
            {
                gridSplitterWindow.Close();
            }
        }

        private void ButtonClick_Canvas(object sender, RoutedEventArgs e)
        {
            canvasWindow = new CanvasWindow(canvasButton);
            canvasWindow.Show();
        }

        private void ButtonClick_WrapPanel(object sender, RoutedEventArgs e)
        {
            wrapPanel = new WrapPanelWindow(wrapPanelButton);
            wrapPanel.Show();
        }

        private void ButtonClick_StackPanel(object sender, RoutedEventArgs e)
        {
            stackPanel = new StackPanelWindow(stackPanelButton);
            stackPanel.Show();
        }

        private void ButtonClick_DockPanel(object sender, RoutedEventArgs e)
        {
            dockPanel = new DockPanelWindow(dockPanelButton);
            dockPanel.Show();
        }

        private void ButtonClick_GridPanel(object sender, RoutedEventArgs e)
        {
            gridPanelWindow = new GridPanelWindow(gridPanelButton);
            gridPanelWindow.Show();
        }

        private void ButtonClick_GridSplitter(object sender, RoutedEventArgs e)
        {
            gridSplitterWindow = new GridSplitterWindow(gridSplitterButton);
            gridSplitterWindow.Show();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if(_mainWindow.eventsCheckBox.IsChecked == true)
                _mainWindow.Close();

            CloseAllWindows();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Show();

            this.Hide();

            this.Close();
        }
    }
}
