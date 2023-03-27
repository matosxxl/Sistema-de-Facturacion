using Facturacion;

bool cancel = false;
int idArt, cantidad;

List<Articulo> listaArt = new List<Articulo>();
Articulo objArticulo;
Factura objFactura = new Factura();

CrearArticulos(72.99, "Leche", 1);
CrearArticulos(8, "Huevos", 2);
CrearArticulos(81.99, "Pan", 3);
CrearArticulos(238.99, "Jamon", 4);
CrearArticulos(183.99, "Queso", 5);
CrearArticulos(5, "Guineos", 6);
CrearArticulos(123.99, "Jugo", 7);
CrearArticulos(89.00, "Refresco", 8);  
CrearArticulos(7, "Manzanas", 9);
CrearArticulos(92, "Piña", 10);

//Inicio del programa

Console.WriteLine("SISTEMA DE FACTURACION: \n");

while (cancel == false)
{
    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("Elija el articulo que desea agregar a su compra (1 - 10) (Si desea parar de agregar articulos seleccione un numero diferente de las opciones): \n");

    foreach (Articulo articulo in listaArt)
    {
        Console.WriteLine($"[{articulo.Id}] - {articulo.Nombre} || Precio: {articulo.Precio}$ \n");
    }

    Console.WriteLine("---------------------------------------------------------------------------------------------------------------\n");
        
    idArt = Convert.ToInt32(Console.ReadLine());
        
    if( idArt < 1 || idArt > listaArt.Count)
    {
        cancel = true;
        break;
    }

    objArticulo = listaArt.Find( articulo => articulo.Id == idArt );

    Console.WriteLine($"ARTICULO: {objArticulo.Nombre}");
    Console.WriteLine("Ingrese la cantidad que desea:\n");
    cantidad = Convert.ToInt32(Console.ReadLine());
    objArticulo.Cantidad = cantidad;

    objFactura.ArticulosFactura = objArticulo;

}

ImprimirFactura();

void CrearArticulos(double precio, string nombre, int id)
{
    objArticulo = new Articulo(precio, nombre, id);
    listaArt.Add(objArticulo);
}

void ImprimirFactura()
{
    Console.WriteLine("A continuacion los objetos de su factura: ");
    foreach (var articulo in objFactura.FacturaLista)
    {
        Console.WriteLine($"{articulo.Nombre}: {articulo.Cantidad} === {articulo.Precio * articulo.Cantidad}");
    }
}