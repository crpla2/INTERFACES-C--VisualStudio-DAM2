using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppFitipaldi.Entity
{
    public class Vehiculo : INotifyPropertyChanged
    {
        public Vehiculo(string marca, string modelo, string matricula, Cliente propietario)
        {
            Marca = marca;
            Modelo = modelo;
            Matricula = matricula;
            Propietario = propietario;
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set
            {
                marca = value;
                NotifyPropertyChanged("Marca");
            }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set
            {
                modelo = value;
                NotifyPropertyChanged("Modelo");
            }
        }

        private string matricula;
        public string Matricula
        {
            get { return matricula; }
            set
            {
                matricula = value;
                NotifyPropertyChanged("Matricula");
            }
        }

        private Cliente propietario;
        public Cliente Propietario
        {
            get { return propietario; }
            set
            {
                propietario = value;
                NotifyPropertyChanged("Propietario");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
