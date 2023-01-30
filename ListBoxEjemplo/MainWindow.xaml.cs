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

namespace ListBoxEjemplo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for(int i=0;i<10;i++)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                listBoxItem.Content = i.ToString();
                lib.Items.Add(listBoxItem);
            }
        }
        void WriteText2(object sender, RoutedEventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            txtb.Text = "You clicked " + li.Content.ToString() + ".";
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (lib.SelectedItems.Count > 0) {
                String resultado="";
                foreach (ListBoxItem o in lib.SelectedItems)
                {
                    resultado += " " + o.Content.ToString();
                } 
                MessageBox.Show(resultado);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        { lib.Items.RemoveAt(lib.SelectedIndex);
          /*  if (lib.SelectedItems.Count > 0)
            {
                for (int i=(x)
                {
                    if (lib.SelectedItems.Count > 0)
                    {
                        lib.Items.Clear();

                    }
                }

            }*/
        }
    }
}
