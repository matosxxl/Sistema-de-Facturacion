using Facturacion;

bool cancel = false;
int idArt, cantidad;
string nombre;

List<Articulo> listaArt = new List<Articulo>();
Articulo objArticulo;
Factura objFactura = new Factura();

CrearArticulos(72.99,  "Leche   ", 1);
CrearArticulos(8,      "Huevos  ", 2);
CrearArticulos(81.99,  "Pan     ", 3);
CrearArticulos(238.99, "Jamon   ", 4);
CrearArticulos(183.99, "Queso   ", 5);
CrearArticulos(5,      "Guineos ", 6);
CrearArticulos(123.99, "Jugo    ", 7);
CrearArticulos(89.00,  "Refresco", 8);  
CrearArticulos(7,      "Manzanas", 9);
CrearArticulos(92,     "Piña    ", 10);

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

    Console.WriteLine($"\nARTICULO: {objArticulo.Nombre}\n");
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
    double precioFactura = 0;
    DateTime fecha = DateTime.Now;

    Console.Clear();
    Console.WriteLine("*----------------------------------------*");
    Console.WriteLine("       FACTURA PARA CONSUMIDOR FINAL      ");
    Console.WriteLine("*----------------------------------------*");
    Console.WriteLine("DESCRIPCION (cant.)   |              VALOR");
    Console.WriteLine("");
    foreach (Articulo articulo in objFactura.FacturaLista)
    {
        var precioFinal = articulo.Precio * articulo.Cantidad;
        precioFactura += precioFinal;
        Console.WriteLine($"{articulo.Nombre}   : {articulo.Cantidad}                      {precioFinal:C}");
    }
    Console.WriteLine("*----------------------------------------*");
    Console.WriteLine($"TOTAL A PAGAR:                     {precioFactura:C}");
    Console.WriteLine("*----------------------------------------*");
    Console.WriteLine("");
    Console.WriteLine($"Compra realizada: {fecha.ToShortDateString()} {fecha.ToShortTimeString()}");
}