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
    /// Logique d'interaction pour EquipeFenetre.xaml
    /// </summary>
    public partial class EquipeFenetre : Window
    {
        public EquipeFenetre()
        {
            InitializeComponent();
            Container myContainer = new Container();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.MinHeight = 450;
            this.MinWidth = 600;
        }
    }
}
