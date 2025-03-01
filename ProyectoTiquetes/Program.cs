// See https://aka.ms/new-console-template for more information
using ProyectoTiquetes;

Console.WriteLine("Hola :)");


public class program { 

private static List<Cajero> cajeros = new List<Cajero>();
private static List<Conductor> conductores = new List<Conductor>();
private static List<Ruta> rutas = new List<Ruta>();
private static Administrador administrador;
private static Cajero cajeroActual; // Variable para almacenar el cajero autenticado


    static void Main(string[] args)
{

    
    // Inicializar datos
    administrador = new Administrador("Andreni", "admin123");
    cajeros.Add(new Cajero(1, 101, "rafael@ejemplo.com", "rafael123", "Rafael"));
    cajeros.Add(new Cajero(2, 102, "sandra@ejemplo.com", "sandra123", "Sandra"));
    conductores.Add(new Conductor("John", "8547", rutas[0]));
    conductores.Add(new Conductor("Oswaldo", "5463", rutas[1]));
    rutas.Add(new Ruta(1, "Homecenter", "Destino1", "Horario1",23,18));
    rutas.Add(new Ruta(2, "IKEA", "Destino2", "Horario2",25,15));

    // Autenticación del usuario
    if (AutenticarUsuario())
    {
        MostrarMenu();
    }
}

static bool AutenticarUsuario()
{
    int intentos = 3;

    for (int i = 0; i < intentos; i++)
    {
        Console.Write("Ingrese su usuario: ");
        string usuario = Console.ReadLine();
        Console.Write("Ingrese su contraseña: ");
        string contraseña = Console.ReadLine();
        Console.Write("Ingrese su rol (Administrador/Cajero): ");
        string rol = Console.ReadLine();
        if (usuario == administrador.Correo && contraseña == administrador.Contrasenia && rol.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Bienvenido {usuario}, Rol: {rol}");
            return true;
        }

        foreach (var cajero in cajeros)
        {
            if (usuario == cajero.Nombre && contraseña == cajero.Contrasenia && rol.Equals("Cajero", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Bienvenido {usuario}, Rol: {rol}");
                cajeroActual = cajero; // Almacenar el cajero autenticado
                return true;
            }
        }
        Console.WriteLine("Datos incorrectos. Intente nuevamente.");
    }
    Console.WriteLine("Se ha excedido el número de intentos. Contacte a soporte técnico.");
    return false;
}

static void MostrarMenu()
{
    Console.WriteLine("\n--- Menú Principal ---");
    Console.WriteLine("1. Menú Administrador");
    Console.WriteLine("2. Menú Cajero");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            MostrarMenuAdministrador();
            break;
        case "2":
            MostrarMenuCajero(cajeroActual); // Pasar el cajero actual
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}

static void MostrarMenuAdministrador()
{
    bool salir = false;

    while (!salir)
    {
        Console.WriteLine("\n--- Menú Administración ---");
        Console.WriteLine("1. Gestión de cuenta administrador");
        Console.WriteLine("2. Gestión de cajeros");
        Console.WriteLine("3. Gestión de conductores");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción: ");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                administrador.GestionarCuenta();
                break;
            case "2":
                GestionarCajeros();
                break;
            case "3":
                GestionarConductores();
                break;
            case "4":
                salir = true;
                Console.WriteLine("Saliendo del menú de Administrador...");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}

static void GestionarCajeros()
{
    bool salir = false;

    while (!salir)
    {
        Console.WriteLine("\n--- Gestión de Cajeros ---");
        Console.WriteLine("1. Crear cajero");
        Console.WriteLine("2. Editar cajero");
        Console.WriteLine("3. Ver lista de cajeros");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción: ");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                AgregarCajero();
                break;
            case "2":
                EditarCajero();
                break;
            case "3":
                VerCajeros();
                break;
            case "4":
                salir = true;
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}

static void AgregarCajero()
{
    static void AgregarCajero()
    {
        Console.Write("Ingrese el ID del cajero: ");
        int id = int.Parse(Console.ReadLine()); // Recolectar el ID
        Console.Write("Ingrese el número de trabajador: ");
        int numTrabajador = int.Parse(Console.ReadLine()); // Recolect NumTrabajador
        Console.Write("Ingrese el correo del cajero: ");
        string correo = Console.ReadLine(); // Recolect Correo
        Console.Write("Ingrese la contraseña del cajero: ");
        string contraseña = Console.ReadLine(); // Recollect Contraseña
        Console.Write("Ingrese el nombre del cajero: ");
        string nombre = Console.ReadLine(); // Recolect Nombre
        // Se envian los datos recolectados a los parametros de Cajero
        cajeros.Add(new Cajero(id, numTrabajador, correo, contraseña, nombre));
        Console.WriteLine("Cajero agregado correctamente.");

    }
   }

static void EditarCajero()
{
    Console.Write("Ingrese el número del cajero a editar: ");
    int num = int.Parse(Console.ReadLine()) - 1;

    if (num >= 0 && num < cajeros.Count)
    {
        Console.Write("Ingrese el nuevo nombre de usuario del cajero: ");
        cajeros[num].Nombre = Console.ReadLine();
        Console.Write("Ingrese la nueva contraseña del cajero: ");
        cajeros[num].Contrasenia = Console.ReadLine();
        Console.WriteLine("Cajero editado correctamente.");
    }
    else
    {
        Console.WriteLine("Número de cajero no válido.");
    }
}

static void VerCajeros()
{
    Console.WriteLine("\n--- Lista de Cajeros ---");
    for (int i = 0; i < cajeros.Count; i++)
    {
        Console.WriteLine($"Cajero {i + 1}: {cajeros[i].Nombre}");
    }
}

  static void MostrarMenuCajero(Cajero cajeroActual)
  {
    bool salir = false;
    while (!salir)
    {
        Console.WriteLine("\n--- Menú Cajero ---");
        Console.WriteLine("1. Cambiar nombre de usuario");
        Console.WriteLine("2. Cambiar contraseña");
        Console.WriteLine("3. Realizar venta");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción: ");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                CambiarNombreUsuario(cajeroActual);
                break;
            case "2":
                CambiarContrasenia(cajeroActual);
                break;
            case "3":
                RealizarVenta();
                break;
            case "4":
                salir = true;
                Console.WriteLine("Saliendo del menú de Cajero...");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
    }

    static void CambiarNombreUsuario(Cajero cajero)
    {
        Console.Write("Ingrese el nuevo nombre de usuario: ");
        string nuevoNombre = Console.ReadLine();
        cajero.Nombre = nuevoNombre;
        Console.WriteLine("Nombre de usuario cambiado correctamente.");
    }

    static void CambiarContrasenia(Cajero cajero)
    {
        Console.Write("Ingrese la nueva contraseña: ");
        string nuevaContrasenia = Console.ReadLine();
        cajero.Contrasenia = nuevaContrasenia; // Ensure that Contrasenia is accessible
        Console.WriteLine("Contraseña cambiada correctamente.");
    }

    static void RealizarVenta()
{
    Console.Write("\nIngrese el nombre del comprador: ");
    string nombreComprador = Console.ReadLine();
    Console.Write("Seleccione el número de la ruta: ");
    int numRuta = int.Parse(Console.ReadLine()) - 1;

    if (numRuta >= 0 && numRuta < rutas.Count)
    {
        Console.Write("Ingrese la cantidad de tiquetes: ");
        int cantidadTiquetes = int.Parse(Console.ReadLine());
        Factura factura = new Factura(numRuta + 1, cantidadTiquetes, 0); // Aquí se puede calcular el precio total
        cajeros[0].RealizarVenta(factura); // Suponiendo que el cajero que realiza la venta es el primero en la lista
    }
    else
    {
        Console.WriteLine("Número de ruta no válido.");
    }
}

static void GestionarConductores()
{
    bool salir = false;

    while (!salir)
    {
        Console.WriteLine("\n--- Gestión de Conductores ---");
        Console.WriteLine("1. Crear conductor");
        Console.WriteLine("2. Editar conductor");
        Console.WriteLine("3. Ver lista de conductores");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción: ");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                AgregarConductor();
                break;
            case "2":
                EditarConductor();
                break;
            case "3":
                VerConductores();
                break;
            case "4":
                salir = true;
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}

static void AgregarConductor()
{
    Console.Write("Ingrese el nombre del conductor: ");
    string nombre = Console.ReadLine(); 
    Console.Write("Ingrese el número de automóvil del conductor: ");
    string numeroAutomovil = Console.ReadLine(); 
    // Mostar Rutas disponibles
    Console.WriteLine("\n--- Rutas Disponibles ---");//Las rutas dentro de la lista rutas[] definida más arriba
    for (int i = 0; i < rutas.Count; i++)
    {
        Console.WriteLine($"Ruta {i + 1}: {rutas[i].Origen} a {rutas[i].Destino}");
    }
    Console.Write("Seleccione el número de la ruta: ");
    int rutaIndex = int.Parse(Console.ReadLine()) - 1; // Recolect Ruta
    if (rutaIndex >= 0 && rutaIndex < rutas.Count)
    {
        // Crear conductor enviandolos datos recolectados a los parametros
        conductores.Add(new Conductor(nombre, numeroAutomovil, rutas[rutaIndex]));
        Console.WriteLine("Conductor agregado correctamente.");
    }
    else
    {
        Console.WriteLine("Número de ruta no válido.");
    }
   }

static void EditarConductor()
{
    Console.Write("Ingrese el número del conductor a editar: ");
    int num = int.Parse(Console.ReadLine()) - 1;

    if (num >= 0 && num < conductores.Count)
    {
        Console.Write("Ingrese el nuevo nombre del conductor: ");
        conductores[num].Nombre = Console.ReadLine();
        Console.WriteLine("Conductor editado correctamente.");
    }
    else
    {
        Console.WriteLine("Número de conductor no válido.");
    }
}

static void VerConductores()
{
    Console.WriteLine("\n--- Lista de Conductores ---");
    for (int i = 0; i < conductores.Count; i++)
    {
        Console.WriteLine($"Conductor {i + 1}: {conductores[i].Nombre}");
    }
    }

}



