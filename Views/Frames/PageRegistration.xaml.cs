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
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void BtnUploadOrganisationCredits_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUploadRegistrationCertificate_Click(object sender, RoutedEventArgs e)
        {

        }


        private void BtnContinue_Click(object sender, RoutedEventArgs e)
        {
            ClassFrameNavigation.FrameView.Navigate( new PageOrganisationCredits() );
        }
    }
}
