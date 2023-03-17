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
            // Crear un nuevo cliente con los datos del formulario
            Cliente cliente = new Cliente(nombreTextBox.Text, apellidosTextBox.Text, direccionTextBox.Text, telefonoTextBox.Text, dniTextBox.Text);

            // Agregar el nuevo cliente a la lista y actualizar el origen de datos del ComboBox
            clientes.Add(cliente);
            clientesComboBox.ItemsSource = null;
            clientesComboBox.ItemsSource = clientes;
        }

        private void actualizarButton_Click(object sender, RoutedEventArgs e)
        {
            // Actualizar los datos del cliente seleccionado en el ComboBox con los datos del formulario
            Cliente cliente = clientesComboBox.SelectedItem as Cliente;
            cliente.Nombre = nombreTextBox.Text;
            cliente.Apellidos = apellidosTextBox.Text;
            cliente.Direccion = direccionTextBox.Text;
            cliente.Telefono = telefonoTextBox.Text;
            cliente.Dni = dniTextBox.Text;

            // Actualizar el origen de datos del ComboBox
            clientesComboBox.ItemsSource = null;
            clientesComboBox.ItemsSource = clientes;
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
    }
}
