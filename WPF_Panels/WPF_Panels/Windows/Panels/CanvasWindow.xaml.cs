using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for CanvasWindow.xaml
    /// </summary>
    public partial class CanvasWindow : Window
    {        
        private Button button;

        public CanvasWindow(Button button)
        {
            InitializeComponent();

            this.button = button;
            button.IsEnabled = false;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = true;

            this.Close();
        }

        private void cyanButton_Click(object sender, RoutedEventArgs e)
        {
            //bring the light cyan rectangle to the front and the other rectangles to the back
            Canvas.SetZIndex(lightCyanRectangle, 1);
            Canvas.SetZIndex(lightBlueRectangle, 0);
            Canvas.SetZIndex(lightCoralRectangle, 0);

            //set a border to the light cyan rectangle
            lightCyanRectangle.Stroke = Brushes.Black;
            lightCyanRectangle.StrokeThickness = 2;

            //remove the border from the other rectangles
            lightBlueRectangle.Stroke = null;
            lightCoralRectangle.Stroke = null;
        }

        private void blueButton_Click(object sender, RoutedEventArgs e)
        {
            //bring the light blue rectangle to the front and the other rectangles to the back
            Canvas.SetZIndex(lightCyanRectangle, 0);
            Canvas.SetZIndex(lightBlueRectangle, 1);
            Canvas.SetZIndex(lightCoralRectangle, 0);

            //set a border to the light blue rectangle
            lightBlueRectangle.Stroke = Brushes.Black;
            lightBlueRectangle.StrokeThickness = 2;

            //remove the border from the other rectangles
            lightCyanRectangle.Stroke = null;
            lightCoralRectangle.Stroke = null;
        }

        private void coralButton_Click(object sender, RoutedEventArgs e)
        {
            //bring the light coral rectangle to the front and the other rectangles to the back
            Canvas.SetZIndex(lightCyanRectangle, 0);
            Canvas.SetZIndex(lightBlueRectangle, 0);
            Canvas.SetZIndex(lightCoralRectangle, 1);

            //set a border to the light coral rectangle
            lightCoralRectangle.Stroke = Brushes.Black;
            lightCoralRectangle.StrokeThickness = 2;

            //remove the border from the other rectangles
            lightCyanRectangle.Stroke = null;
            lightBlueRectangle.Stroke = null;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            button.IsEnabled = true;
        }
    }
}
