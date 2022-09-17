using Bestour.Classes;
using Bestour.Views.Frames;
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

namespace Bestour.Views.Boxes
{
    /// <summary>
    /// Логика взаимодействия для WindowApplicationAccepted.xaml
    /// </summary>
    public partial class WindowApplicationAccepted : Window
    {
        public WindowApplicationAccepted()
        {
            InitializeComponent();
        }

        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            Close();
            ClassFrameNavigation.FrameView.Navigate(new PageLogin());
        }
    }
}
