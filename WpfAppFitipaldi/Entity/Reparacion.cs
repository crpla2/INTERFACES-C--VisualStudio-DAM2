using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppFitipaldi.Entity
{
    public class Reparacion
    {
        private string descripcion;
        private double precio;

        // Constructor
        public Reparacion(string descripcion, double precio)
        {
            this.descripcion = descripcion;
            this.precio = precio;
        }

        // Getters y Setters
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
