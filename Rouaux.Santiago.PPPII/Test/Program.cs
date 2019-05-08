﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {

        static int OrdenarProductos(Producto p1, Producto p2)
        {
            if ((int)p1 > (int)p2)
            {
                return 1;
            }
            else if((int)p1 < (int)p2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


        static void Main(string[] args)
        {




            Console.Title = "Primer Parcial Laboratorio II - 2016 -";
            Estante est1 = new Estante(4);
            Estante est2 = new Estante(3);
            Harina h1 = new Harina(102, 37.5f, EMarcaProducto.Favorita,
            ETipoHarina.CuatroCeros);
            Harina h2 = new Harina(103, 40.25f, EMarcaProducto.Favorita,
            ETipoHarina.Integral);
            Galletita g1 = new Galletita(113, 33.65f, EMarcaProducto.Pitusas, 250f);
            Galletita g2 = new Galletita(111, 56f, EMarcaProducto.Diversión, 500f);
            Jugo j1 = new Jugo(112, 25f, EMarcaProducto.Naranjú, ESaborJugo.Pasable);
            Jugo j2 = new Jugo(333, 33f, EMarcaProducto.Swift, ESaborJugo.Asqueroso);
            Gaseosa g = new Gaseosa(j2, 2250f);
            if (!(est1 + h1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + j1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + h2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + j2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + g))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            Console.WriteLine("Valor total Estante1: {0}", est1.ValorEstanteTotal);
            Console.WriteLine("Valor Estante1 sólo de Galletitas: {0}",
            est1.GetValorEstante(ETipoProducto.Galletita));
            Console.WriteLine("Contenido Estante1:\n{0}", Estante.MostrarEstante(est1));
            Console.WriteLine("Estante ordenado por Código de Barra....");
            est1.GetProductos().Sort(Program.OrdenarProductos);
            Console.WriteLine(Estante.MostrarEstante(est1));
            est1 = est1 - ETipoProducto.Galletita;
            Console.WriteLine("Estante1 sin Galletitas: {0}", Estante.MostrarEstante(est1));
            Console.WriteLine("Contenido Estante2:\n{0}", Estante.MostrarEstante(est2));
            est2 -= ETipoProducto.Todos;
            Console.WriteLine("Contenido Estante2:\n{0}", Estante.MostrarEstante(est2));

            Console.ReadLine();
        }
    }
}
