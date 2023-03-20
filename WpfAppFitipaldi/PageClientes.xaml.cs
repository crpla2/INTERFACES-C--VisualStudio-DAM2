using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppFitipaldi.Entity;

namespace WpfAppFitipaldi
{
    public partial class PageClientes : Page
    {  // Inicializar la lista de clientes
        public static List<Cliente> clientes { get; } = new List<Cliente>()
            {
                new Cliente("Juan", "García", "Calle Mayor 1", "123456789", "12345678A"),
                new Cliente("María", "Rodríguez", "Plaza del Sol 2", "987654321", "87654321B"),
                new Cliente("Pedro", "Sánchez", "Avenida de la Constitución 3", "555444333", "76543210C")
            };

        public PageClientes()
        {
            InitializeComponent();          

            // Establecer la lista de clientes como origen de datos del ComboBox
            clientesComboBox.ItemsSource = clientes;

            nombreTextBox.IsEnabled = true;
            apellidosTextBox.IsEnabled = true;
            direccionTextBox.IsEnabled = true;
            telefonoTextBox.IsEnabled = true;
            dniTextBox.IsEnabled = true;
            insertarButton.IsEnabled = true;
            actualizarButton.IsEnabled = false;
            borrarButton.IsEnabled = false;
        }

        private void clientesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Actualizar el formulario con los datos del cliente seleccionado en el ComboBox
            if (clientesComboBox.SelectedItem != null)
            {
                nombreTextBox.IsEnabled = true;
                apellidosTextBox.IsEnabled = true;
                direccionTextBox.IsEnabled = true;
                telefonoTextBox.IsEnabled = true;
                dniTextBox.IsEnabled = true;
                insertarButton.IsEnabled = false;
                actualizarButton.IsEnabled = true;
                borrarButton.IsEnabled = true;
            }
            else
            {
                nombreTextBox.IsEnabled = true;
                apellidosTextBox.IsEnabled = true;
                direccionTextBox.IsEnabled = true;
                telefonoTextBox.IsEnabled = true;
                dniTextBox.IsEnabled = true;
                insertarButton.IsEnabled = true;
                actualizarButton.IsEnabled = false;
                borrarButton.IsEnabled = false;
            }
        }

        private void insertarButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsValid())
            {
                // Crear un nuevo cliente con los datos del formulario
                Cliente cliente = new Cliente(nombreTextBox.Text, apellidosTextBox.Text, direccionTextBox.Text, telefonoTextBox.Text, dniTextBox.Text.ToUpper());

                // Agregar el nuevo cliente a la lista y actualizar el origen de datos del ComboBox
                clientes.Add(cliente);
                clientesComboBox.ItemsSource = null;
                clientesComboBox.ItemsSource = clientes;

                // Limpiar el formulario
                nombreTextBox.Text = "";
                apellidosTextBox.Text = "";
                direccionTextBox.Text = "";
                telefonoTextBox.Text = "";
                dniTextBox.Text = "";
            }
        }


        private void actualizarButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsValid())
            {
                // Actualizar los datos del cliente seleccionado en el ComboBox con los datos del formulario
                Cliente cliente = clientesComboBox.SelectedItem as Cliente;
                cliente.Nombre = nombreTextBox.Text;
                cliente.Apellidos = apellidosTextBox.Text;
                cliente.Direccion = direccionTextBox.Text;
                cliente.Telefono = telefonoTextBox.Text;
                cliente.Dni = dniTextBox.Text.ToUpper();

                // Actualizar el origen de datos del ComboBox
                clientesComboBox.ItemsSource = null;
                clientesComboBox.ItemsSource = clientes;
            }
        }


        private void borrarButton_Click(object sender, RoutedEventArgs e)
        {
            // Eliminar el cliente seleccionado del ComboBox y de la lista
            Cliente cliente = clientesComboBox.SelectedItem as Cliente;
            clientes.Remove(cliente);
            clientesComboBox.ItemsSource = null;
            clientesComboBox.ItemsSource = clientes;

            // Limpiar el formulario
            nombreTextBox.Text = "";
            apellidosTextBox.Text = "";
            direccionTextBox.Text = "";
            telefonoTextBox.Text = "";
            dniTextBox.Text = "";

            nombreTextBox.IsEnabled = true;
            apellidosTextBox.IsEnabled = true;
            direccionTextBox.IsEnabled = true;
            telefonoTextBox.IsEnabled = true;
            dniTextBox.IsEnabled = true;
            insertarButton.IsEnabled = true;
            actualizarButton.IsEnabled = false;
            borrarButton.IsEnabled = false;
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            nombreTextBox.Text = string.Empty;
            apellidosTextBox.Text = string.Empty;
            direccionTextBox.Text = string.Empty;
            telefonoTextBox.Text = string.Empty;
            dniTextBox.Text = string.Empty;

            clientesComboBox.SelectedIndex = -1;
        }
        private bool IsValid()
        {
            // Comprobar que los campos requeridos están completos
            if (string.IsNullOrEmpty(nombreTextBox.Text) ||
                string.IsNullOrEmpty(apellidosTextBox.Text) ||
                string.IsNullOrEmpty(direccionTextBox.Text) ||
                string.IsNullOrEmpty(telefonoTextBox.Text) ||
                string.IsNullOrEmpty(dniTextBox.Text))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Error de validación", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            // Comprobar que el teléfono tiene un formato válido
            if (!System.Text.RegularExpressions.Regex.IsMatch(telefonoTextBox.Text, @"^[6789]\d{8}$"))
            {
                MessageBox.Show("El número de teléfono no es válido. Debe tener 9 dígitos y empezando por 6,7,8 o 9.", "Error de validación", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            // Comprobar que el DNI tiene un formato válido
            if (!System.Text.RegularExpressions.Regex.IsMatch(dniTextBox.Text, @"^\d{8}[A-Za-z]$"))
            {
                MessageBox.Show("El DNI no es válido. Debe tener 8 dígitos seguidos de una letra mayúscula.", "Error de validación", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }

    }
}
