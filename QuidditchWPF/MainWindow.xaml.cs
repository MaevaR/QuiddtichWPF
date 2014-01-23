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
using System.ComponentModel;


namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Container myContainer = new Container();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.MinHeight = 450;
            this.MinWidth = 600;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MatchFenetre win = new MatchFenetre();
            win.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StadeFenetre win = new StadeFenetre();
            win.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            JoueurFenetre win = new JoueurFenetre();
            win.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CoupeFenetre win = new CoupeFenetre();
            win.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            EquipeFenetre win = new EquipeFenetre();
            win.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ReservationFenetre win = new ReservationFenetre();
            win.Show();
        }
    }
}
