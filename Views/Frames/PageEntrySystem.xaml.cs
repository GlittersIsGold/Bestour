using Bestour.Classes;
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

namespace Bestour.Views.Frames
{
    /// <summary>
    /// Логика взаимодействия для PageEntrySystem.xaml
    /// </summary>
    public partial class PageEntrySystem : Page
    {
        public PageEntrySystem()
        {
            InitializeComponent();
        }

        private void BtnContinue_Click(object sender, RoutedEventArgs e)
        {
            ClassFrameNavigation.FrameView.Navigate(new PageTrustedPerson());
        }

        private void BtnBackspace_Click(object sender, RoutedEventArgs e)
        {
            ClassFrameNavigation.FrameView.Navigate(new PageOrganisationCredits());
        }
    }
}
