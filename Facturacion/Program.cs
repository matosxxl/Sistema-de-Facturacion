using Facturacion;

bool cancel = false;
int idArt, cantidad;
string nombre;
const string articulosSuper = "articulos.txt";

List<Articulo> listaArt = new List<Articulo>();
Articulo objArticulo;
Factura objFactura = new Factura();

//Inicio del programa

LeerArticulos();
Console.WriteLine("SISTEMA DE FACTURACION: \n");

while (cancel == false)
{
    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"Elija el articulo que desea agregar a su compra (1 - {listaArt.Count}) \n(Si desea parar de agregar articulos seleccione un numero diferente de las opciones): \n");

    foreach (Articulo articulo in listaArt)
    {
        Console.WriteLine($"[{articulo.Id}] - {articulo.Nombre} || Precio: {articulo.Precio}$ \n");
    }

    Console.WriteLine("---------------------------------------------------------------------------------------------------------------\n");

    idArt = Convert.ToInt32(Console.ReadLine());

    if (idArt < 1 || idArt > listaArt.Count)
    {
        cancel = true;
        break;
    }

    objArticulo = listaArt.Find(articulo => articulo.Id == idArt);

    Console.WriteLine($"\nARTICULO: {objArticulo.Nombre}\n");
    Console.WriteLine($"\nPRECIO: {objArticulo.Precio}\n");
    Console.WriteLine("Ingrese la cantidad que desea:\n");
    cantidad = Convert.ToInt32(Console.ReadLine());
    objArticulo.Cantidad = cantidad;
    objFactura.ArticulosFactura = objArticulo;

}

Console.Clear();
Console.WriteLine("Introduzca el nombre del cliente: \n");
nombre = Console.ReadLine();

ImprimirFactura();
Console.ReadLine();

void LeerArticulos()
{
    bool cierre = false;
    int i = 1;
    StreamReader articulosA = new StreamReader(articulosSuper);
    while (!cierre)
    {
        string nombre;
        double precio;
        try
        {
            nombre = articulosA.ReadLine();
            precio = Convert.ToDouble(articulosA.ReadLine());

            if (nombre == null)
            {
                throw new Exception();
            }
        }
        catch
        {
            cierre = false;
            break;
        }

        CrearArticulos(precio, nombre, i);
        i++;
    }

    articulosA.Close();

}

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
    Console.WriteLine($"Cliente: {nombre}");
}
