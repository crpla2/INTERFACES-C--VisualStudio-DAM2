using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppFitipaldi.Entity
{
    public class Cliente
    {
        private string nombre;
        private string apellidos;
        private string direccion;
        private string telefono;
        private string dni;
        private string nombreCompleto;

        public Cliente(string nombre, string apellidos, string direccion, string telefono, string dni)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
            this.dni = dni;
            this.nombreCompleto = nombre + " " + apellidos;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }
    }

}
