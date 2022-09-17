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
    /// Логика взаимодействия для PageOranisationCredits.xaml
    /// </summary>
    public partial class PageOrganisationCredits : Page
    {
        public PageOrganisationCredits()
        {
            InitializeComponent();
        }

        private void BtnContinue_Click(object sender, RoutedEventArgs e)
        {
            ClassFrameNavigation.FrameView.Navigate(new PageEntrySystem());
        }

        private void BtnBackspace_Click(object sender, RoutedEventArgs e)
        {
            ClassFrameNavigation.FrameView.Navigate(new PageRegistration());
        }

        private void BtnUploadMedia_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
