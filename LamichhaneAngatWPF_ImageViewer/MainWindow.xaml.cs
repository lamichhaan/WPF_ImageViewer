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

namespace LamichhaneAngatWPF_ImageViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myImageViewer.Source =
                new BitmapImage(new Uri("Images\\Forest.jpg", UriKind.Relative));
        }
        private void browseButton_Click_1(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int i = r.Next(4);

            switch (i)
            {
                case 1:
                    myImageViewer.Source =
                        new BitmapImage(new Uri("Images/Creek.jpg", UriKind.Relative));
                    break;

                case 2:
                    myImageViewer.Source =
                        new BitmapImage(new Uri("Images/Dock.jpg", UriKind.Relative));
                    break;
                case 3:
                    myImageViewer.Source =
                        new BitmapImage(new Uri("Images/Forest.jpg", UriKind.Relative));
                    break;

            }
        }

    }
}
