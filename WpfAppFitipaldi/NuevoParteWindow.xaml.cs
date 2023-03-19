using System;
using System.Collections.Generic;
using System.IO;
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
using WpfAppFitipaldi.Entity;

namespace WpfAppFitipaldi
{
    public partial class NuevoParteWindow : Window
    {
        public Parte parteCreado { get; set; }

        public NuevoParteWindow()
        {
            InitializeComponent();

            // Cargar datos en los ComboBox
            vehiculoComboBox.ItemsSource = PageVehiculos.vehiculos;
            reparacionComboBox.ItemsSource = PageTaller.reparaciones;

            // Crear una nueva instancia de Parte
            parteCreado = new Parte();
            parteCreado.FechaEntrada = DateTime.Today;
           

            // Establecer el DataContext del formulario a la instancia de Parte creada
            DataContext = parteCreado;
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {          

            if (IsValid())
            {
                parteCreado = new Parte((Vehiculo)vehiculoComboBox.SelectedItem, (Reparacion)reparacionComboBox.SelectedItem, fechaEntradaDatePicker.SelectedDate.Value, int.Parse(horasEstimadasTextBox.Text));
                parteCreado.FechaSalida = parteCreado.FechaEntrada;
                parteCreado.HorasReales = parteCreado.HorasEstimadas; 
                this.DialogResult = true; // establecer DialogResult en true para indicar que se creó un nuevo parte
                this.Close(); // cerrar el formulario
            }
        }

        private bool IsValid()
        {
            // Verificar que se haya seleccionado un vehículo
            if (vehiculoComboBox.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un vehículo.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            // Verificar que se haya seleccionado una reparación
            if (reparacionComboBox.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una reparación.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            // Verificar que la fecha de entrada no sea posterior a la fecha de salida
            if (fechaEntradaDatePicker.SelectedDate >= DateTime.Now)
            {
                MessageBox.Show("La fecha de entrada no puede ser posterior a la fecha de salida.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            // Verificar que las horas estimadas sean un número positivo
            if (!int.TryParse(horasEstimadasTextBox.Text, out int horasEstimadas) || horasEstimadas <= 0)
            {
                MessageBox.Show("Las horas estimadas deben ser un número positivo.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            // Todos los campos son válidos
            return true;
        }



        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar el formulario indicando que se canceló la operación
            DialogResult = false;
            Close();
        }

        private void AumentarHorasEstimadas_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el valor actual de horas estimadas
            int horasEstimadas = (int)parteCreado.HorasEstimadas;

            // Aumentar el valor en una unidad
            horasEstimadas++;

            // Asignar el nuevo valor al objeto DataContext
            parteCreado.HorasEstimadas = horasEstimadas;

            // Actualizar la vista
            horasEstimadasTextBox.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
        }

        private void DisminuirHorasEstimadas_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el valor actual de horas estimadas
            int horasEstimadas = (int)parteCreado.HorasEstimadas;

            // Disminuir el valor en una unidad, asegurándose de que nunca sea menor que cero
            horasEstimadas = Math.Max(0, horasEstimadas - 1);

            // Asignar el nuevo valor al objeto DataContext
            parteCreado.HorasEstimadas = horasEstimadas;

            // Actualizar la vista
            horasEstimadasTextBox.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
        }

    }
}