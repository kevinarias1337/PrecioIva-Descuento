using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace precioiva
{
    public class Calculoprecio
    {
        private double precio;

        public void setPrecio(double total)
        {
            this.precio = total;
        }
        public double getPrecio()
        {
            return this.precio;
        }

        public double calcularDescuento()
        {
            return this.getPrecio() * 0.20;
        }
        public double calcularIva()
        {
            return this.getPrecio() * 0.19;
        }
        public double calcularPrecio()
        {
            return (this.getPrecio()-this.calcularDescuento())+this.calcularIva();
        }
    }
}
