using ProyectoAmigos.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace ProyectoAmigos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        ObservableCollection<Persona> personas;
        public MainWindow()
        {
            InitializeComponent();
            personas = new ObservableCollection<Persona>();
            personas.Add(new Persona("Miguel", "Desarrollo"));
            personas.Add(new Persona("Santi", "Desarrollo"));

            foreach (Persona persona in personas)
            {
                lstPersonas.Items.Add(persona);
            }

            dgAlumnos.ItemsSource = personas;
        }

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {
            String cadena = "Esta seguro que desea introducir a " + txNombre.Text;
            String caption = "Proceso de validación";

            if (txNombre.Text == "" || txApellidos.Text == "")
            {
                MessageBox.Show("Comprueba haber rellenado los datos");
                return;
            }

            MessageBoxResult dialogResult = MessageBox.Show(cadena, caption, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (dialogResult == MessageBoxResult.Yes)
            {
                Persona p = new Persona(txNombre.Text, txApellidos.Text);
                lstPersonas.Items.Add(p);
                personas.Add(p);
                txNombre.Clear();
                txApellidos.Clear();
            }
            else
            {
                MessageBox.Show("Arreglalo");
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VentanaHija hija = new VentanaHija();
            this.Hide();
            hija.ShowDialog();
        }

        private void BotonmejorAmigo_Click(object sender, RoutedEventArgs e)
        {

            object[] itemsToRemove = new object[lstPersonas.SelectedItems.Count];
            lstPersonas.SelectedItems.CopyTo(itemsToRemove, 0);

            foreach (object item in itemsToRemove)
            {
                lstPersonas.Items.Remove(item);
                lstmejoresAmigos.Items.Add(item);

            }
        }

        private void BotonQuitarAmigo_Click(object sender, RoutedEventArgs e)
        {
            if (lstmejoresAmigos.SelectedItems.Count != 0)
            {
                foreach (Persona p in lstmejoresAmigos.SelectedItems)
                {
                    lstPersonas.Items.Add(p);
                }
                for (int i = (lstmejoresAmigos.SelectedItems.Count - 1); i >= 0; i--)
                {
                    lstmejoresAmigos.Items.RemoveAt(i);
                }
            }

        }

       

        private void BotonActualiza_Click(object sender, RoutedEventArgs e)
        {
            
            personas.ElementAt(0).Nombre = "Raul";
        }
        
    }
}