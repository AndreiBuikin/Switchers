using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PraktRab10._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RotateTransform rotation = (sender as Canvas).RenderTransform as RotateTransform;
            if (rotation != null)
            {
                (sender as Canvas).RenderTransform = new RotateTransform(
                    rotation.Angle + 20,
                    rotation.CenterX,
                    rotation.CenterY
                );
            }
        }
    }
}
