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
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {

        public bool IsLogged = false;

        public PageLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

            string Login = "1";
            string Pass = "1";
                if (TbLogin.Text == Login && PbPass.Password == Pass)
            {
                IsLogged = true;
                ClassFrameNavigation.FrameView.Navigate(new PageRegistration());

            }
        }

        private void PbPass_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
