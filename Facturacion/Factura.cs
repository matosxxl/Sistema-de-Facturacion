using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion
{
    internal class Factura
    {
        //ATRIBUTO
        private List<Articulo> articulosFactura;

        //PROPIEDAD
        public List<Articulo> FacturaLista
        {
            get { return articulosFactura; }
        }

        public Articulo ArticulosFactura
        {
            get { return ArticulosFactura; }
            set { articulosFactura.Add(value); }
        }

        //Constructor
        public Factura() {
            articulosFactura = new List<Articulo>();
        }

        public void AgregarArticulo( Articulo art, int cantidad )
        {
            Articulo artAgregar = art;
            artAgregar.Cantidad = cantidad;

            ArticulosFactura = artAgregar;
        }
    }
}
