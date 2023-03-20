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

namespace WpfAppFitipaldi
{
    public partial class PageInicio : Page
    {
        private string nombreUsuario = "a";
        private string contrasena = "a";

        public PageInicio()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string nombreUsuarioIngresado = UsernameTextBox.Text;
            string contrasenaIngresada = PasswordBox.Password;

            if (nombreUsuarioIngresado == nombreUsuario && contrasenaIngresada == contrasena)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Inicio de sesión", MessageBoxButton.OK, MessageBoxImage.Information);

                // Obtener la ventana principal y establecer IsLoggedIn como verdadero
                MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow.IsLoggedIn = true;

                // Navegar a la pestaña de clientes
                mainWindow.MainTabControl.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void CerrarSesionButton_Click(object sender, RoutedEventArgs e)
        {
            // Establecer IsLoggedIn como falso en la ventana principal
            ((MainWindow)Application.Current.MainWindow).IsLoggedIn = false;

            // Mostrar la pestaña de inicio en la ventana principal
            ((MainWindow)Application.Current.MainWindow).MainTabControl.SelectedIndex = 0;
        }

    }
}