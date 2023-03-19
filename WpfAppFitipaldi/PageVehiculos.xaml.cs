using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            vehiculosDataGrid.CellEditEnding += vehiculosDataGrid_CellEditEnding;
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


        // Diccionario para guardar los valores originales de las celdas editadas
        Dictionary<DataGridCell, object> valoresOriginales = new Dictionary<DataGridCell, object>();
        private void vehiculosDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            // Obtener la fila que se está editando
            DataGridRow row = e.Row;

            // Obtener la celda que se está editando
            DataGridCell cell = e.Column.GetCellContent(row).Parent as DataGridCell;

            // Obtener el valor editado
            string valorEditado = ((TextBox)cell.Content).Text;

            // Obtener el nombre de la columna que se está editando
            string nombreColumna = e.Column.Header.ToString();

            // Obtener el vehículo editado
            Vehiculo vehiculo = row.Item as Vehiculo;

            try
            {
                // Validar los datos de la celda editada
                if (nombreColumna == "Marca")
                {
                    if (string.IsNullOrWhiteSpace(valorEditado))
                    {
                        throw new Exception("Debe ingresar una marca.");
                    }
                    else
                    {
                        vehiculo.Marca = valorEditado;
                    }
                }
                else if (nombreColumna == "Modelo")
                {
                    if (string.IsNullOrWhiteSpace(valorEditado))
                    {
                        throw new Exception("Debe ingresar un modelo.");
                    }
                    else
                    {
                        vehiculo.Modelo = valorEditado;
                    }
                }
                else if (nombreColumna == "Matricula")
                {
                    string matricula = valorEditado.ToUpper();
                    if (!Regex.IsMatch(matricula, @"^[0-9]{4}[BCDFGHJKLMNPQRSTVWXYZ]{3}$"))
                    {
                        throw new Exception("La matrícula ingresada no es válida.");
                    }
                    else if (ExisteMatricula(matricula))
                    {
                        throw new Exception("Ya existe otro vehículo con la misma matrícula.");
                    }
                    else
                    {
                        vehiculo.Matricula = matricula;
                    }
                }
                // Guardar el valor original de la celda editada
                if (!valoresOriginales.ContainsKey(cell))
                {
                    valoresOriginales.Add(cell, e.EditingElement.DataContext);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                e.Cancel = true;

                // Restaurar el valor anterior de la celda
                if (valoresOriginales.ContainsKey(cell))
                {
                    cell.DataContext = valoresOriginales[cell];
                    cell.Content = new TextBlock() { Text = valoresOriginales[cell].ToString() };
                }
            }
            finally
            {
                try
                {
                    vehiculosDataGrid.Items.Refresh();
                }
                catch (Exception ex)
                {
                }
            }   

        }

        private bool ExisteMatricula(string matricula)
        {
            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.Matricula == matricula)
                {
                    return true;
                }
            }

            return false;
        }

        private void borrarButton_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el vehículo seleccionado en el DataGrid
            Vehiculo vehiculo = vehiculosDataGrid.SelectedItem as Vehiculo;

            // Preguntar al usuario si realmente desea eliminar el vehículo
            MessageBoxResult result = MessageBox.Show("¿Está seguro que desea eliminar el vehículo seleccionado?", "Eliminar vehículo", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                // Eliminar el vehículo seleccionado de la lista y actualizar el origen de datos del DataGrid
                vehiculos.Remove(vehiculo);
                vehiculosDataGrid.Items.Refresh();
            }
        }
    }
}