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
    /// Logique d'interaction pour StadeFenetre.xaml
    /// </summary>
    public partial class StadeFenetre : Window
    {
        private BusinessManager coupeManager;
        public StadeFenetre()
        {
            InitializeComponent();
            Container myContainer = new Container();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.MinHeight = 450;
            this.MinWidth = 600;
        }

        private void WindowStades_loader(object sender, RoutedEventArgs e)
        {
            coupeManager = new BusinessManager();

            ListeStades.ItemsSource = coupeManager.ListStades();

            Stade s = new Stade(0); ;
            this.DataContext = s; 
        }
    }
}
