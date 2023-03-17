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
using WpfAppFitipaldi.Entity;

namespace WpfAppFitipaldi
{
    public partial class PageTaller : Page
    {
        private List<Parte> partes { get; }
        private List<Vehiculo> vehiculos = PageVehiculos.vehiculos;
        public static List<Reparacion> reparaciones { get; } = new List<Reparacion>()
        {
            new Reparacion ("Cambio de aceite", 50),
            new  Reparacion ("Cambio de neumáticos", 200)
        };
       
        public PageTaller()
        {
            InitializeComponent();

            partes = new List<Parte>()
            {
                new Parte(vehiculos[0], reparaciones[0],new DateTime(2022, 1, 1), new DateTime(2022, 1, 3), 8, 10),
                new Parte(vehiculos[1], reparaciones[1],new DateTime(2022, 1, 1), new DateTime(2022, 1, 3), 8, 10),
                new Parte(vehiculos[2], reparaciones[0],new DateTime(2022, 1, 1), new DateTime(2022, 1, 3), 8, 10)
            };

            partesDataGrid.ItemsSource = partes;
        }

       
        private void NuevoParteButton_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de nuevo parte
            NuevoParteWindow nuevoParteWindow = new NuevoParteWindow();
            nuevoParteWindow.Closing += NuevoParteWindow_Closing; // Suscribir al evento Closing
            nuevoParteWindow.ShowDialog();
        }

        private void NuevoParteWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NuevoParteWindow nuevoParteWindow = sender as NuevoParteWindow;
            if (nuevoParteWindow.DialogResult != true) // Comprobar si el usuario ha añadido un nuevo parte
            {
                e.Cancel = true; // Cancelar el cierre de la ventana
            }
        }

        private void BorrarParteButton_Click(object sender, RoutedEventArgs e)
        {
            if (partesDataGrid.SelectedItem != null)
            {
                partes.Remove((Parte)partesDataGrid.SelectedItem);
                partesDataGrid.Items.Refresh();
            }
        }

        private void AumentarHorasReales_Click(object sender, RoutedEventArgs e)
        {
            if (partesDataGrid.SelectedItem != null)
            {
                Parte parte = (Parte)partesDataGrid.SelectedItem;
                parte.HorasReales++;
                partesDataGrid.Items.Refresh();
            }
        }

        private void DisminuirHorasReales_Click(object sender, RoutedEventArgs e)
        {
            if (partesDataGrid.SelectedItem != null)
            {
                Parte parte = (Parte)partesDataGrid.SelectedItem;
                parte.HorasReales = parte.HorasReales > 0 ? parte.HorasReales - 1 : 0;
                partesDataGrid.Items.Refresh();
            }
        }
    }
}

