// See https://aka.ms/new-console-template for more information
using ProyectoTiquetes;

//Console.WriteLine("Hola :)");


public class program { 

private static List<Cajero> cajeros = new List<Cajero>();
private static List<Conductor> conductores = new List<Conductor>();
private static List<Ruta> rutas = new List<Ruta>();
private static Administrador administrador;
private static Cajero cajeroActual; // Variable para almacenar el cajero autenticado


    static void Main(string[] args)
{

     // Inicializar datos
    administrador = new Administrador("Andreni@ejemplo.com", "admin123");
    cajeros.Add(new Cajero(1, 101, "rafael@ejemplo.com", "rafael123", "Rafael"));
    cajeros.Add(new Cajero(2, 102, "sandra@ejemplo.com", "sandra123", "Sandra"));
    rutas.Add(new Ruta(1, "Homecenter", "Destino1", "Horario1", 23, 18, 10000));
    rutas.Add(new Ruta(2, "IKEA", "Destino2", "Horario2", 25, 15, 20000));
    conductores.Add(new Conductor("3","John", "8547", rutas[0]));
    conductores.Add(new Conductor("4", "Oswaldo", "5463", rutas[1]));
    

        // Autenticación del usuario
        Console.WriteLine("COMERCIO ONLINE 101  \n Bienvenido al sistema de empleados \n A continuacion inicie sesión con su usuario: \n");
        string rol = AutenticarUsuario();
        if (rol != null)
        {
            if (rol.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                MostrarMenuAdministrador();
            }
            else
            {
                MostrarMenuCajero(cajeroActual); // Pasar el cajero autenticado
            }
        }
    }

    static string AutenticarUsuario()
    {
        int intentos = 3;

        for (int i = 0; i < intentos; i++)
        {
            Console.Write("~Ingrese su correo: ~ ");
            string correo = Console.ReadLine().Trim();
            Console.Write("~ Ingrese su contraseña: ~ ");
            string contraseña = Console.ReadLine().Trim();
            Console.Write("~ Ingrese su rol (Administrador/Cajero): ~ ");
            string rol = Console.ReadLine().Trim();

            // Verificar si las credenciales del administrador son correctas
            if (administrador != null &&
                correo.Equals(administrador.Correo, StringComparison.OrdinalIgnoreCase) &&
                contraseña.Equals(administrador.Contrasenia) &&
                rol.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Bienvenido {correo}, Rol: {rol}");
                return "Administrador"; // Retornar el rol
            }

            // Verificar si las credenciales del usuario coinciden con algún cajero
            foreach (var cajero in cajeros)
            {
                // Debug
                Console.WriteLine($"Comparando usuario: '{correo}' con '{cajero.Correo}'");
                Console.WriteLine($"Comparando contraseña: '{contraseña}' con '{cajero.Contrasenia}'");
                Console.WriteLine($"Comparando rol: '{rol}' con 'Cajero'");

                if (correo.Equals(cajero.Correo, StringComparison.OrdinalIgnoreCase) &&
                    contraseña.Equals(cajero.Contrasenia) &&
                    rol.Equals("Cajero", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Bienvenido {cajero.Nombre}, Rol: {rol}");
                    cajeroActual = cajero; // Almacenar el cajero autenticado
                    return "Cajero"; // Retornar el rol
                }
            }
            Console.WriteLine("Datos incorrectos. Intente nuevamente.");
        }
        Console.WriteLine("Se ha excedido el número de intentos. Contacte a soporte técnico.");
        return null; // Retornar null si la autenticación falla
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
        Console.Write("Seleccione una opción: \n");
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
        // Mostrar cajeros
        Console.WriteLine("~ Cajer@/s actuales: ~ \n");
        foreach (var cajero in cajeros)
        {
            Console.WriteLine($"ID: '{cajero.ID}, , Numero trabajador: '{cajero.NumTrabajador}, Correo: '{cajero.Correo}', Nombre: '{cajero.Nombre}'\n");
        }

        Console.Write("Ingrese el ID del cajero: \n");
        int id = int.Parse(Console.ReadLine()); // Recolectar el ID
        Console.Write("Ingrese el número de trabajador: \n");
        int numTrabajador = int.Parse(Console.ReadLine()); // Recolect NumTrabajador
        Console.Write("Ingrese el correo del cajero: \n");
        string correo = Console.ReadLine(); // Recolect Correo
        Console.Write("Ingrese la contraseña del cajero: \n");
        string contraseña = Console.ReadLine(); // Recolectar Contraseña
        Console.Write("Ingrese el nombre del cajero: \n");
        string nombre = Console.ReadLine(); // Recolect Nombre
        // Se envian los datos recolectados a los parametros de Cajero
        cajeros.Add(new Cajero(id, numTrabajador, correo, contraseña, nombre));
        Console.WriteLine("Cajero agregado correctamente.\n");

    }

static void EditarCajero()
{
        // Mostrar cajeros
        Console.WriteLine("~ Cajer@/s actuales: ~ \n");
        foreach (var cajero in cajeros)
        {
            Console.WriteLine($"ID: '{cajero.ID}, , Numero trabajador: '{cajero.NumTrabajador}, Correo: '{cajero.Correo}', Nombre: '{cajero.Nombre}'\n");
        }

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
        cajero.Contrasenia = nuevaContrasenia; //Contrasenia es accesible
        Console.WriteLine("Contraseña cambiada correctamente.");
    }

    static void RealizarVenta()
    {
        Console.Write("\nIngrese el nombre del comprador: ");
        string nombreComprador = Console.ReadLine();
        Console.Write("Seleccione el número de la ruta: ");
        int numRuta = int.Parse(Console.ReadLine()) - 1; // ajuste para un indice en cero

        // Revisar si la ruta seleccionada es valida
        if (numRuta >= 0 && numRuta < rutas.Count)
        {
            Console.Write("Ingrese la cantidad de tiquetes: ");
            int cantidadTiquetes = int.Parse(Console.ReadLine());

            // Precio por tiquete de la ruta seleccionada
            int precioPorTiquete = rutas[numRuta].PrecioTiquete; 
            int totalPrecio = precioPorTiquete * cantidadTiquetes;

            // Crear la factura
            Factura factura = new Factura(numRuta + 1, cantidadTiquetes, totalPrecio);

            // Realizar la venta con el cajero autenticado
            cajeroActual.RealizarVenta(factura);

            // Mostrat compra al usuario
            Console.WriteLine($"~* Venta realizada con éxito! *~\n");
            Console.WriteLine($"Comprador: {nombreComprador} \n");
            Console.WriteLine($"Ruta: '{rutas[numRuta].Origen}' hacia '{rutas[numRuta].Destino}'\n");
            Console.WriteLine($"Cantidad de tiquetes: {cantidadTiquetes}");
            Console.WriteLine($"Total a pagar: {totalPrecio:C}"); // Formatear a pesos
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
    // Mostrar cajeros
    Console.WriteLine("~ Conduct@re/s actuales: ~ \n");
    foreach (var conductor in conductores)
    {
        Console.WriteLine($"ID: '{conductor.ID}, Nombre: '{conductor.Nombre}' , Numero automovil: '{conductor.NumeroAutomovil}, Ruta Conductor: '{conductor.RutaConductor}'\n");
    }

    Console.Write("Ingrese el ID del conductor: \n");
    string id = Console.ReadLine();
    Console.Write("Ingrese el nombre del conductor: \n");
    string nombre = Console.ReadLine(); 
    Console.Write("Ingrese el número de automóvil del conductor: \n");
    string numeroAutomovil = Console.ReadLine(); 
    // Mostar Rutas disponibles
    Console.WriteLine("\n--- Rutas Disponibles ---\n");//Las rutas dentro de la lista rutas[] definida más arriba
    for (int i = 0; i < rutas.Count; i++)
    {
        Console.WriteLine($"Ruta {i + 1}: {rutas[i].Origen} a {rutas[i].Destino}\n");
    }
    Console.Write("Seleccione el número de la ruta: \n");
    int rutaIndex = int.Parse(Console.ReadLine()) - 1; // Recolect Ruta
    if (rutaIndex >= 0 && rutaIndex < rutas.Count)
    {
        // Crear conductor enviandolos datos recolectados a los parametros
        conductores.Add(new Conductor(id,nombre, numeroAutomovil, rutas[rutaIndex]));
        Console.WriteLine("Conductor agregado correctamente.\n");
    }
    else
    {
        Console.WriteLine("Número de ruta no válido.\n");
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



