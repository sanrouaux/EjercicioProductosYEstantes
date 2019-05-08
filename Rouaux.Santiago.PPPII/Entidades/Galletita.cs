using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita : Producto
    {
        protected float _peso;
        protected static bool DeConsumo;

        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (float)0.33 * this.Precio;
            }
        }

        //CONSTRUCTORES
        static Galletita()
        {
            Galletita.DeConsumo = true;
        }

        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso) : base(codigoBarra, marca, precio)
        {
            this._peso = peso;
        }

        public override string Consumir()
        {
            return "Comestible";
        }

        private static string MostrarGalletita(Galletita g)
        {
            return (string)g + "\nPESO: " + g._peso + "\n";
        }

        public override string ToString()
        {
            return MostrarGalletita(this);
        }

    }
}
