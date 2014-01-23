using BusinessLayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour MatchFenetre.xaml
    /// </summary>
    public partial class MatchFenetre : Window
    {
        BusinessManager coupeManager;

        public MatchFenetre()
        {
            InitializeComponent();
            Container myContainer = new Container();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.MinHeight = 450;
            this.MinWidth = 600;
        }

        private void WindowMatchs_Loaded(object sender, RoutedEventArgs e)
        {
            coupeManager = new BusinessManager();

            ListeMatchs.ItemsSource = coupeManager.ListMatchs();

            Match m = new Match(0) ;
            this.DataContext = m; 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Match m = this.DataContext as Match;
            coupeManager.ListMatchs().Add(m);
        }

    }
}
