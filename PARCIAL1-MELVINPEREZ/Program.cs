using PARCIAL1_MELVINPEREZ.Entidades;
using PARCIAL1_MELVINPEREZ.Negocio;

static void Main(string[] args)
{
    ClsUsuario usuarioNegocio= new ClsUsuario();  
    ClsVenta ventaNegocio = new ClsVenta();

    //pedir credenciales del usuario
    Console.WriteLine("Ingrese su nombre de usuario: ");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese su contraseña: ");
    string contra = Console.ReadLine();

    //Verificar las credenciales 
    if (usuarioNegocio.Acceso(nombre, contra))
    {
        Console.WriteLine("ingrese el identificador del producto: ");
        int identificador = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el nombre del producto: ");
        string nombreProducto = Console.ReadLine();
        Console.WriteLine("Ingrese la descripcion del producto: ");
        string descripcionProducto = Console.ReadLine();
        Console.WriteLine("ingrese el precio del producto: ");
        decimal precioProducto = decimal.Parse(Console.ReadLine());
        Console.WriteLine("ingrese la cantidad de productos: ");
        int cantidadProducto = int.Parse(Console.ReadLine());


        //crear una venta 
        VENTA venta = new VENTA
        {
            IdentificadorDeProducto = identificador,
            NombreDelProducto = nombreProducto,
            DescripcionDelProducto = descripcionProducto,
            PrecioDelProducto = precioProducto,
            CantidadDeProducto = cantidadProducto,

        };

        // cobro de la venta
        ventaNegocio.Cobro(venta);


    }
    else
    {
        Console.WriteLine("el usuario a ingresado las credenciales incorrectas");
    }

           

}
