using Bestour.Classes;
using Bestour.Views.Boxes;
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
    /// Логика взаимодействия для PageTrustedPerson.xaml
    /// </summary>
    public partial class PageTrustedPerson : Page
    {
        public PageTrustedPerson()
        {
            InitializeComponent();
        }

        private void BtnContinue_Click(object sender, RoutedEventArgs e)
        {
            WindowApplicationAccepted accepted = new();
            accepted.Show();
        }

        private void BtnBackspace_Click(object sender, RoutedEventArgs e)
        {
            ClassFrameNavigation.FrameView.Navigate(new PageEntrySystem());
        }

        private void BtnUploadOrganisationCredits_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
