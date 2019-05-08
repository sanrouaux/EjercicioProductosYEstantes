using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa : Producto
    {
        //ATRIBUTOS
        protected float _litros;
        protected static bool DeConsumo;

        //PROPIEDAD
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (float)0.42 * this.Precio;
            }
        }

        //CONSTRUCTORES
        static Gaseosa()
        {
            Gaseosa.DeConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros) : base(codigoBarra, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto p, float litros) : this((int)p, p.Precio, p.Marca, litros)
        {
            

        }

        //METODOS
        public override string Consumir()
        {
            return "Bebible";
        }

        private string MostrarGaseosa()
        {
            return (string)this + "\nLITROS: " + this._litros + "\n";
        }

        public override string ToString()
        {
            return this.MostrarGaseosa();
        }
    }
}
