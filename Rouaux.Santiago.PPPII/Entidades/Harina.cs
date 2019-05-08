using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina : Producto
    {
        //ATRIBUTOS
        protected ETipoHarina _tipo;
        protected static bool DeConsumo;

        //PROPIEDAD
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (float)0.6 * this.Precio;
            }
        }

        //CONSTRUCTORES
        static Harina()
        {
            Harina.DeConsumo = false;
        }

        public Harina(int codigo, float precio, EMarcaProducto marca, ETipoHarina tipo) : base(codigo, marca, precio)
        {
            this._tipo = tipo;
        }

        //METODOS
        private string MostrarHarina()
        {
            return (string)this + "\nTIPO: " + this._tipo + "\n";
        }

        public override string ToString()
        {
            return this.MostrarHarina();
        }

    }

    public enum ETipoHarina
    {
        CuatroCeros,
        TresCeros,
        Integral
    }
}
