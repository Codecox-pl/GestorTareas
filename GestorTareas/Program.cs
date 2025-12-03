// See https://aka.ms/new-console-template for more information


using GestorTareas;

//Creando lista vacia de Tarea
List<Tarea> tareas = new List<Tarea>();

while (true)
{
    // 1. Mostrar las opciones
    Console.WriteLine("\n--- GESTOR DE TAREAS ---");
    Console.WriteLine("1.- Agregar Tarea");
    Console.WriteLine("2.- Modificar Tarea");
    Console.WriteLine("3.- Eliminar Tarea");
    Console.WriteLine("4.- Listar Tareas");
    Console.WriteLine("5.- Salir");
    Console.Write("Seleccione una opcion: ");

    //2. Leer lo ingresado por el usuario
    string op = Console.ReadLine();

    if (op == "1")
    {
        Console.WriteLine("Ingrese el nombre de la nueva tarea: ");
        string tarea = Console.ReadLine();

        Tarea T = new Tarea(tarea);
        tareas.Add(T);
        Console.WriteLine(">> Tarea agregada con exito");
    }

    else if(op == "2")
    {
        Console.WriteLine("Ingrese el nombre de la tarea: ");
        string busqueda = Console.ReadLine();

        Tarea tareaEncontrada = tareas.FirstOrDefault(t => t.Titulo == busqueda);

        if(tareaEncontrada != null)
        {
            Console.WriteLine("Ingrese el nuevo nombre de la tarea: ");
            string tareaModificada = Console.ReadLine();

            tareaEncontrada.Titulo = tareaModificada;

            Console.WriteLine($"Nombre de la nueva tarea: {tareaEncontrada.Titulo} ");
        }
        else
        {
            Console.WriteLine("No se encontró la tarea mencionada ");
        }

    }

    else if (op == "4")
    {
        Console.WriteLine("\n=== TUS TAREAS ===");
        foreach (var tarea in tareas)
        {
            Console.WriteLine("Tarea:" + tarea.Titulo);
        }
    }

    else if (op == "5")
    {
        break;
    }

    else
    {
        Console.WriteLine("Opcion invalida");
    }
}



