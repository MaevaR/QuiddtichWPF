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
using BusinessLayer;

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private BusinessManager coupe;
        public Login()
        {
            InitializeComponent();
             coupe = new BusinessManager();

             this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (coupe.PasswordCheck(txtLogin.Text.ToLower(), txtPassword.Password))
            {
                MainWindow win = new MainWindow();
                win.Show();

                this.Close();
            }
        }


    }
}
