//string vOpcion;
//bool cancel = false;

//Console.WriteLine("Factura de supermercado: \n");

//while (cancel == false)
//{
//    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

//    Console.WriteLine("Elija el articulo que desea agregar a su compra (1 - 10) (Si desea parar de agregar articulos seleccione 0): ");
//    Console.WriteLine("[1]  - Leche \n[2]  - Huevos \n[3]  - Pan \n[4]  - Jamon \n[5]  - Queso \n[6]  - Guineos \n[7]  - Jugo \n[8]  - Refresco \n[9]  - Manzanas \n[10] - Piña");
//    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

//    vOpcion = Console.ReadLine();

//    switch (vOpcion)
//    {
//        case "1":
//            Console.WriteLine("ARTICULO: LECHE");
//            Console.WriteLine();
//            break;

//        case "2":
//            Console.WriteLine("ARTICULO: HUEVOS");
//            Console.WriteLine();
//            break;

//        case "3":
//            Console.WriteLine("ARTICULO: PAN");
//            Console.WriteLine();
//            break;

//        case "4":
//            Console.WriteLine("ARTICULO: JAMON");
//            Console.WriteLine();
//            break;

//        case "5":
//            Console.WriteLine("ARTICULO: QUESO");
//            Console.WriteLine();
//            break;

//        case "6":
//            Console.WriteLine("ARTICULO: GUINEOS");
//            Console.WriteLine();
//            break;

//        case "7":
//            Console.WriteLine("ARTICULO: JUGOS");
//            Console.WriteLine();
//            break;

//        case "8":
//            Console.WriteLine("ARTICULO: REFRESCOS");
//            Console.WriteLine();
//            break;

//        case "9":
//            Console.WriteLine("ARTICULO: MANZANAS");
//            Console.WriteLine();
//            break;

//        case "10":
//            Console.WriteLine("ARTICULO: PIÑA");
//            Console.WriteLine();
//            break;

//        case "0":
//            cancel = true;
//            break;

//        default:
//            Console.WriteLine("No ha seleccionado una opcion valida");
//            break;

//    }
//}


using Facturacion;

Articulo objArticulo;

void CrearArticulos()
{
    List<Articulo> arregloArticulos = new List<Articulo>();

    objArticulo = new Articulo(10, "Guineos", 1);
    arregloArticulos.Add(objArticulo);
    objArticulo = new Articulo(10, "Manzanas", 2);
    arregloArticulos.Add(objArticulo);
}

