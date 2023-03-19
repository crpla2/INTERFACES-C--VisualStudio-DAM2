using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppFitipaldi.Entity
{
    public class Parte
    {
        private Vehiculo vehiculo;
        private string cliente;
        private Reparacion reparacion;
        private DateTime fechaEntrada;
        private DateTime fechaSalida;
        private int horasEstimadas;
        private int horasReales;

        public Parte() { }
        public Parte(Vehiculo vehiculo, Reparacion reparacion, DateTime fechaEntrada, DateTime fechaSalida, int horasEstimadas, int horasReales)
        {
            this.vehiculo = vehiculo;
            this.cliente = vehiculo.Propietario.NombreCompleto;
            this.reparacion = reparacion;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            this.horasEstimadas = horasEstimadas;
            this.horasReales = horasReales;
        }
        public Parte(Vehiculo vehiculo, Reparacion reparacion, DateTime fechaEntrada,  int horasEstimadas)
        {
            this.vehiculo = vehiculo;
            this.cliente = vehiculo.Propietario.NombreCompleto;
            this.reparacion = reparacion;
            this.fechaEntrada = fechaEntrada;
           
            this.horasEstimadas = horasEstimadas;
           
        }

        public Vehiculo Vehiculo
        {
            get { return vehiculo; }
            set { vehiculo = value; }
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public Reparacion Reparacion
        {
            get { return reparacion; }
            set { reparacion = value; }
        }

        public DateTime FechaEntrada
        {
            get { return fechaEntrada; }
            set { fechaEntrada = value; }
        }

        public DateTime FechaSalida
        {
            get { return fechaSalida; }
            set { fechaSalida = value; }
        }

        public int HorasEstimadas
        {
            get { return horasEstimadas; }
            set { horasEstimadas = value; }
        }

        public int HorasReales
        {
            get { return horasReales; }
            set { horasReales = value; }
        }
    }

}
