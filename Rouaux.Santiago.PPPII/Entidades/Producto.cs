using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        //ATRIBUTOS
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;


        //PROPIEDADES

        public abstract float CalcularCostoDeProduccion
        { get; }

        public EMarcaProducto Marca
        {
            get { return _marca; }
        }
        
        public float Precio
        {
            get { return _precio; }
        }
        
        //CONSTRUCTOR
        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }

        //SOBRECARGA DE OPERADORES
        public static bool operator ==(Producto p1, Producto p2)
        {
            if(p1.GetType() == p2.GetType() && p1.Marca == p2.Marca && (int)p1 == (int)p2)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, EMarcaProducto marca)
        {
            if(p1.Marca == marca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Producto p1, EMarcaProducto marca)
        {
            return !(p1 == marca);
        }

        public override bool Equals(object obj)
        {
            return obj is Producto;
        }

        //CONVERSIONES
        public static explicit operator int(Producto p)
        {
            return p._codigoBarra;
        }

        public static implicit operator string(Producto p)
        {
            return "MARCA: " + p.Marca.ToString() + "\nCODIGO DE BARRAS: " + ((int)p).ToString() + "\nPRECIO: " + p.Precio.ToString();
        }

        

        //METODOS
        public virtual string Consumir()
        {
            return "Parte de una mezcla.";
        }
    }

    public enum EMarcaProducto
    {
        Manaos,
        Pitusas,
        Naranjú,
        Diversión,
        Swift,
        Favorita        
    }

    public enum ETipoProducto
    {
        Galletita, 
        Gaseosa, 
        Jugo, 
        Harina, 
        Todos
    }
}
