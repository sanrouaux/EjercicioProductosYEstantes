using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo : Producto
    {
        protected ESaborJugo _sabor;
        protected static bool DeConsumo;

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (float)0.4 * this.Precio;
            }
        }

        //CONSTRUCTORES
        static Jugo()
        {
            Jugo.DeConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor) : base(codigoBarra, marca, precio)
        {
            this._sabor = sabor;
        }

        public override string Consumir()
        {
            return "Bebible";
        }

        private string MostrarJugo()
        {
            return (string)this + "\nSABOR: " + this._sabor + "\n";
        }

        public override string ToString()
        {
            return this.MostrarJugo();
        }


    }


    public enum ESaborJugo
    {
        Asqueroso, 
        Pasable,
        Rico
    }
}
