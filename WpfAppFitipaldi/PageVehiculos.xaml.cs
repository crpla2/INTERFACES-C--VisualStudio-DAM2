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
    public partial class PageVehiculos : Page
    { 
        private static List<Cliente> clientes = PageClientes.clientes;
        
        public static List<Vehiculo> vehiculos { get; } = new List<Vehiculo>()
            {
                new Vehiculo("Ford", "Focus", "1234ABC",clientes[0]),
                new Vehiculo("Renault", "Clio", "5678DEF", clientes[1]),
                new Vehiculo("Seat", "León", "9012GHI", clientes[2])
            };
       
        public PageVehiculos()
        {
            InitializeComponent();
                 
            // Establecer la lista de vehículos como origen de datos del DataGrid
            vehiculosDataGrid.ItemsSource = vehiculos;
        }

        private void nuevoButton_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana de inserción de vehículo
            NuevoVehiculoWindow nuevoVehiculoWindow = new NuevoVehiculoWindow(PageClientes.clientes);

            nuevoVehiculoWindow.Owner = Window.GetWindow(this);
            if (nuevoVehiculoWindow.ShowDialog() == true)
            {
                // Agregar el nuevo vehículo a la lista y actualizar el origen de datos del DataGrid
                vehiculos.Add(nuevoVehiculoWindow.Vehiculo);
                vehiculosDataGrid.Items.Refresh();
            }
        }

        private void actualizarButton_Click(object sender, RoutedEventArgs e)
        {
            vehiculosDataGrid.Items.Refresh();
        }

        private void vehiculosDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            // Obtener el vehículo editado
            Vehiculo vehiculo = (Vehiculo)e.Row.Item;

            // Actualizar los datos del vehículo
            vehiculo.Marca = ((TextBox)e.EditingElement).Text;

            // Refrescar el DataGrid
            vehiculosDataGrid.Items.Refresh();
        }

        private void borrarButton_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el vehículo seleccionado en el DataGrid
            Vehiculo vehiculo = vehiculosDataGrid.SelectedItem as Vehiculo;

            // Eliminar el vehículo seleccionado de la lista y actualizar el origen de datos del DataGrid
            vehiculos.Remove(vehiculo);
            vehiculosDataGrid.Items.Refresh();
        }
    }
}