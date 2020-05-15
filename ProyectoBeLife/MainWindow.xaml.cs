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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace ProyectoBeLife
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void BtMenu_Click(object sender, RoutedEventArgs e)
        {
            FlyMenu.IsOpen = true;
        }



        //basura
        private void Flyout_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {

        }

        private void BtMenu_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtCliente_Click(object sender, RoutedEventArgs e)
        {
            TBmain.SelectedIndex = 0;
        }

        private void BtListadoCliente_Click(object sender, RoutedEventArgs e)
        {
            TBmain.SelectedIndex = 1;
        }

        private void BtContrato_Click(object sender, RoutedEventArgs e)
        {
            TBmain.SelectedIndex = 2;
        }

        private void BtListadoContrato_Click(object sender, RoutedEventArgs e)
        {
            TBmain.SelectedIndex = 3;
        }
    }
}
