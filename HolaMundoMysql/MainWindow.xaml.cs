using Devart.Data.MySql;
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

namespace HolaMundoMysql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVersion_Click(object sender, RoutedEventArgs e)
        {

            MySqlConnection myConn = new MySqlConnection();
            myConn.ConnectionString = "User Id=root;Password=root;Host=127.0.0.1;";
            myConn.Open();
            MessageBox.Show(myConn.ServerVersion);
            myConn.Close();

        }

       

        private void btnPaises_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnectionStringBuilder myCSB = new MySqlConnectionStringBuilder();
            myCSB.Port = 3306; myCSB.Host = "localhost"; myCSB.UserId = "root"; myCSB.Password = "root"; myCSB.Direct = true; myCSB.Compress = true; myCSB.Database = "WORLD"; myCSB.MaxPoolSize = 150; myCSB.ConnectionTimeout = 30;
            MySqlConnection myConnection = new MySqlConnection(myCSB.ConnectionString);
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = "select * from country where code='ABW'";
            String cadena = ""; String resultado = "";
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                // printing the column names
                for (int i = 0; i < reader.FieldCount; i++)
                    cadena += reader.GetName(i).ToString() + "\t";
                while (reader.Read())
                {
                    // printing the table content
                    for (int i = 0; i < reader.FieldCount; i++)
                        resultado += reader.GetValue(i).ToString() + "\t";
                }
            }
            MessageBox.Show(cadena); MessageBox.Show(resultado);
        }
    }
}
