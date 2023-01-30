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

namespace HolaMundo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lblHolamundo.Content = "Hola Mundo";
            lblHolamundo.Visibility= Visibility.Hidden;

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            if (lblHolamundo.IsVisible)
            {
                imgHolamundo.Visibility = Visibility.Hidden;
                lblHolamundo.Visibility = Visibility.Hidden;
                btnMostrar.Content = "Mostrar";
            }
            else
            {
                imgHolamundo.Visibility = Visibility.Visible;
                lblHolamundo.Visibility  =Visibility.Visible;
                btnMostrar.Content = "Ocultar";
            }
        }
    }
}
