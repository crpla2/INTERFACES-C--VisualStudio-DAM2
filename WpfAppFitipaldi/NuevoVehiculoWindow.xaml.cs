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

using System.Collections.Generic;
using System.Windows;
using WpfAppFitipaldi.Entity;
using System.Text.RegularExpressions;

namespace WpfAppFitipaldi
{
    public partial class NuevoVehiculoWindow : Window
    {
        public Vehiculo Vehiculo { get; set; }
        private List<Cliente> clientes;
        private List<Vehiculo> vehiculos = PageVehiculos.vehiculos;

        public NuevoVehiculoWindow(List<Cliente> clientes)
        {
            InitializeComponent();

            this.clientes = clientes;

            // Establecer la lista de clientes como origen de datos del ComboBox
            ClientesComboBox.ItemsSource = clientes;
            ClientesComboBox.DisplayMemberPath = "NombreCompleto";
        }

        private void guardarButton_Click(object sender, RoutedEventArgs e)
        {
            if(IsValid()) { 
                // Crear un nuevo vehículo con los datos introducidos en la ventana
                Vehiculo = new Vehiculo(MarcaTextBox.Text, ModeloTextBox.Text, MatriculaTextBox.Text.ToUpper(), ClientesComboBox.SelectedItem as Cliente);

                this.DialogResult = true; // establecer DialogResult en true para indicar que se creó un nuevo parte
                this.Close(); // cerrar el formulario
            }
        }
        private bool IsValid()
        {
            // Validar marca
            if (string.IsNullOrWhiteSpace(MarcaTextBox.Text))
            {
                MessageBox.Show("Debe ingresar una marca.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                MarcaTextBox.Focus();
                return false;
            }

            // Validar modelo
            if (string.IsNullOrWhiteSpace(ModeloTextBox.Text))
            {
                MessageBox.Show("Debe ingresar un modelo.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                ModeloTextBox.Focus();
                return false;
            }

            // Validar matrícula
            string matricula = MatriculaTextBox.Text.ToUpper();
            if (!Regex.IsMatch(matricula, @"^[0-9]{4}[BCDFGHJKLMNPQRSTVWXYZ]{3}$"))
            {
                MessageBox.Show("La matrícula ingresada no es válida.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                MatriculaTextBox.Focus();
                return false;
            }

            if (ExisteMatricula(matricula))
            {
                MessageBox.Show("Ya existe otro vehículo con la misma matrícula.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                MatriculaTextBox.Focus();
                return false;
            }

            // Validar cliente
            if (ClientesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir un cliente.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                ClientesComboBox.Focus();
                return false;
            }

            // Todos los campos son válidos
            return true;
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
        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar la ventana con DialogResult = false
            DialogResult = false;
            Close();
        }
    }
}

