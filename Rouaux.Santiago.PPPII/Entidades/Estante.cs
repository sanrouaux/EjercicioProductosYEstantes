using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        //ATRIBUTOS
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        //PROPIEDAD
        public float ValorEstanteTotal
        {
            get
            {
                return this.GetValorEstante();
            }
        }

        //CONSTRUCTORES
        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad) : this()
        {
            this._capacidad = capacidad;
        }


        //METODOS
        public List<Producto> GetProductos()
        {
            return this._productos;
        }


        private float GetValorEstante()
        {
            float valor = 0;
            foreach (Producto p in this._productos)
            {
                valor += p.Precio;
            }
            return valor;
        }


        public float GetValorEstante(ETipoProducto tipo)
        {
            float valor = 0;
            foreach (Producto p in this._productos)
            {
                if (p is Jugo && tipo == ETipoProducto.Jugo)
                {
                    valor += p.Precio;
                }
                else if (p is Gaseosa && tipo == ETipoProducto.Gaseosa)
                {
                    valor += p.Precio;
                }
                else if (p is Galletita && tipo == ETipoProducto.Galletita)
                {
                    valor += p.Precio;
                }
                else if (p is Harina && tipo == ETipoProducto.Harina)
                {
                    valor += p.Precio;
                }
            }
            return valor;
        }


        public static string MostrarEstante(Estante e)
        {
            string retorno = "CAPACIDAD: " + e._capacidad.ToString() + "\n";
            foreach (Producto p in e._productos)
            {
                if (p is Jugo)
                {
                    retorno += ((Jugo)p).ToString() + "\n";
                }
                else if (p is Gaseosa)
                {
                    retorno += ((Gaseosa)p).ToString() + "\n";
                }
                else if (p is Galletita)
                {
                    retorno += ((Galletita)p).ToString() + "\n";
                }
                else if (p is Harina)
                {
                    retorno += ((Harina)p).ToString() + "\n";
                }
            }
            return retorno;
        }


        //SOBRECARGA DE OPERADORES
        public static bool operator ==(Estante e, Producto prod)
        {
            foreach (Producto p in e._productos)
            {
                if (p == prod)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto prod)
        {
            return !(e == prod);
        }

        public static bool operator +(Estante e, Producto prod)
        {
            if (e._capacidad > e._productos.Count && e != prod)
            {
                e._productos.Add(prod);
                return true;
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto prod)
        {
            if (e == prod)
            {
                e._productos.Remove(prod);
            }
            return e;
        }

        public static Estante operator -(Estante e, ETipoProducto tipo)
        {    
            //if(tipo == ETipoProducto.Todos)
            //{
            //    for (int i = e._productos.Count - 1; i >= 0; i--)
            //    {
            //        e -= e._productos[i];
            //    }
            //}

            for (int i = e._productos.Count - 1; i >= 0; i--)
            {
                if ((tipo == ETipoProducto.Jugo || tipo == ETipoProducto.Todos) && e._productos[i] is Jugo)
                {
                    e._productos.Remove(e._productos[i]);
                }
                else if ((tipo == ETipoProducto.Harina || tipo == ETipoProducto.Todos) && e._productos[i] is Harina)
                {
                    e._productos.Remove(e._productos[i]);
                }
                else if ((tipo == ETipoProducto.Gaseosa || tipo == ETipoProducto.Todos) && e._productos[i] is Gaseosa)
                {
                    e._productos.Remove(e._productos[i]);
                }
                else if ((tipo == ETipoProducto.Galletita || tipo == ETipoProducto.Todos) && e._productos[i] is Harina)
                {
                    e._productos.Remove(e._productos[i]);
                }
            }
            return e;
        }

    }
}
