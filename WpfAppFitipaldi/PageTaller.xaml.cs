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
       
        private static List<Vehiculo> vehiculos = PageVehiculos.vehiculos;
        public static List<Reparacion> reparaciones { get; } = new List<Reparacion>()
        {
            new Reparacion("Cambio de aceite", 50),
            new Reparacion("Cambio de neumáticos", 200)
        };

        private List<Parte> partes { get; } = new List<Parte>()
            {
                new Parte(vehiculos[0], reparaciones[0], new DateTime(2022, 2, 1), new DateTime(2022, 2, 3), 2, 3),
                new Parte(vehiculos[1], reparaciones[1], new DateTime(2022, 2, 10), new DateTime(2022, 2, 14), 4, 4),
               
            }; 
        public PageTaller()
        {
            InitializeComponent();

            partesDataGrid.CanUserAddRows = false;
            partesDataGrid.ItemsSource = partes;
        }

        private void NuevoParteButton_Click(object sender, RoutedEventArgs e)
        {
            // Crear una nueva instancia de NuevoParteWindow y mostrarla
            NuevoParteWindow nuevoParteWindow = new NuevoParteWindow();
            nuevoParteWindow.Closed += NuevoParteWindow_Closed; // suscribirse al evento Closed
            nuevoParteWindow.ShowDialog();
        }

        private void NuevoParteWindow_Closed(object sender, EventArgs e)
        {
            // Agregar el nuevo Parte a la lista de partes y actualizar el DataGrid
            NuevoParteWindow nuevoParteWindow = (NuevoParteWindow)sender;
            if (nuevoParteWindow.DialogResult == true)
            {
                partes.Add(nuevoParteWindow.parteCreado);
                partesDataGrid.Items.Refresh();
            }
        }


        private void BorrarParteButton_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el parte seleccionado en el DataGrid
            Parte parte = partesDataGrid.SelectedItem as Parte;
            // Eliminar el parte seleccionado de la lista y actualizar el origen de datos del DataGrid
            partes.Remove(parte);
            partesDataGrid.Items.Refresh();
        }

        private void DisminuirHorasReales_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Parte parte = (Parte)button.DataContext;
            parte.HorasReales--;
            CollectionViewSource.GetDefaultView(partesDataGrid.ItemsSource).Refresh();
        }

        private void AumentarHorasReales_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Parte parte = (Parte)button.DataContext;
            parte.HorasReales++;
            CollectionViewSource.GetDefaultView(partesDataGrid.ItemsSource).Refresh();
        }
    }
}
