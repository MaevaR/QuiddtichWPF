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
using BusinessLayer;
using EntitiesLayer;

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour CoupeFenetre.xaml
    /// </summary>
    public partial class CoupeFenetre : Window
    {
        public CoupeFenetre()
        {
            InitializeComponent();
            Container myContainer = new Container();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.MinHeight = 450;
            this.MinWidth = 600;
        }


        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            BusinessManager coupeManager = new BusinessManager();

            ListeCoupes.ItemsSource = coupeManager.ListCoupes();

            Coupe coupe = new Coupe(0,2014,"Nom de la coupe");
            this.DataContext = coupe; 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Coupe coupe = this.DataContext as Coupe;
        }

 
    }
}
