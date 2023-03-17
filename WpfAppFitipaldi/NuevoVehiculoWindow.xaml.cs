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

namespace WpfAppFitipaldi
{
    public partial class NuevoVehiculoWindow : Window
    {
        public Vehiculo Vehiculo { get; set; }
        private List<Cliente> clientes;

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
            // Crear un nuevo vehículo con los datos introducidos en la ventana
            Vehiculo = new Vehiculo(MarcaTextBox.Text, ModeloTextBox.Text, MatriculaTextBox.Text, ClientesComboBox.SelectedItem as Cliente);

            // Cerrar la ventana con DialogResult = true
            DialogResult = true;
        }

        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar la ventana con DialogResult = false
            DialogResult = false;
        }
    }
}

