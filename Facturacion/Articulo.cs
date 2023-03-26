using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion
{
    internal class Articulo
    {

        //ATRIBUTOS

        private int id;
        private int precio;
        private string nombre;
        private int cantidad;

        //PROPIEDADES

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        //CONSTRUCTORES

        public Articulo( int precio, string nombre, int id)
        {
            this.Precio = precio;
            this.Nombre = nombre;
            this.Id = id;
        }

        public Articulo(int precio, string nombre, int id, int cantidad)
        {
            this.Precio = precio;
            this.Nombre = nombre;
            this.Id = id;
            this.Cantidad = cantidad;
        }

    }
}
