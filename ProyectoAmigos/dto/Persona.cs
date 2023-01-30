using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAmigos.dto
{
    class Persona:INotifyPropertyChanged
    {
        private String nombre;
        private String apellidos;

        public event PropertyChangedEventHandler? PropertyChanged;
        
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                PropertyChanged(this,new PropertyChangedEventArgs("Nombre"));
            }
        }
        public String Apellidos
        {
            get { return apellidos; }
            set 
            {
                apellidos = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Apellidos"));
            }
        }
        public Persona(String nombre, String apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        public override string ToString()
        {
            return nombre + " " + apellidos;
        }

    }
}
