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
using System.Windows.Shapes;
using WpfAppFitipaldi.Entity;

namespace WpfAppFitipaldi
{
    public partial class NuevoParteWindow : Window
    {
        public Parte Parte { get; set; }

        public NuevoParteWindow()
        {
            InitializeComponent();

           

            // Cargar datos en los ComboBox
            vehiculoComboBox.ItemsSource = PageVehiculos.vehiculos;
            reparacionComboBox.ItemsSource = PageTaller.reparaciones;

            // Crear una nueva instancia de Parte
            Parte = new Parte();

            // Establecer el DataContext del formulario a la instancia de Parte creada
            DataContext = Parte;
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            // Validar que se haya seleccionado un vehículo y una reparación
            if (vehiculoComboBox.SelectedItem == null || reparacionComboBox.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un vehículo y una reparación.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Validar que se haya ingresado un valor válido para las horas estimadas
            if (!int.TryParse(horasEstimadasTextBox.Text, out int horasEstimadas) || horasEstimadas <= 0)
            {
                MessageBox.Show("Debe ingresar un valor válido para las horas estimadas.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            // Establecer los valores de la instancia de Parte con los valores ingresados por el usuario
            Parte.Vehiculo = (Vehiculo)vehiculoComboBox.SelectedItem;
            Parte.Reparacion = (Reparacion)reparacionComboBox.SelectedItem;
            // Obtener la fecha actual
            DateTime currentDate = DateTime.Now;

            // Establecer la fecha por defecto en el DatePicker
            fechaEntradaDatePicker.SetValue(DatePicker.SelectedDateProperty, currentDate);

            // Escuchar el evento SelectedDateChanged del DatePicker
            fechaEntradaDatePicker.SelectedDateChanged += (sender, e) => {
                // Actualizar la fecha de la instancia de Parte cada vez que el usuario cambie la fecha
                Parte.FechaEntrada = fechaEntradaDatePicker.SelectedDate.Value;
            };
            Parte.HorasEstimadas = horasEstimadas;

            // Cerrar el formulario indicando que se guardó la información
            DialogResult = true;
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
            int horasEstimadas = (int)Parte.HorasEstimadas;

            // Aumentar el valor en una unidad
            horasEstimadas++;

            // Asignar el nuevo valor al objeto DataContext
            Parte.HorasEstimadas = horasEstimadas;

            // Actualizar la vista
            horasEstimadasTextBox.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
        }

        private void DisminuirHorasEstimadas_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el valor actual de horas estimadas
            int horasEstimadas = (int)Parte.HorasEstimadas;

            // Disminuir el valor en una unidad, asegurándose de que nunca sea menor que cero
            horasEstimadas = Math.Max(0, horasEstimadas - 1);

            // Asignar el nuevo valor al objeto DataContext
            Parte.HorasEstimadas = horasEstimadas;

            // Actualizar la vista
            horasEstimadasTextBox.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
        }

    }
}