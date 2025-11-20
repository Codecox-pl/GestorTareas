// See https://aka.ms/new-console-template for more information


using GestorTareas;

//Creando lista vacia de Tarea
List<Tarea> tareas = new List<Tarea>();

//Tarea 1 //
Console.WriteLine("Ingrese el nombre de la nueva tarea: ");
string tarea1 = Console.ReadLine();

//Creando objetos
Tarea T1 = new Tarea(tarea1);

//Tarea 2 //
Console.WriteLine("Ingrese el nombre de la nueva tarea: ");
string tarea2 = Console.ReadLine();

//Creando objetos
Tarea T2 = new Tarea(tarea2);

//Tarea 2 //
Console.WriteLine("Ingrese el nombre de la nueva tarea: ");
string tarea3 = Console.ReadLine();

//Creando objetos
Tarea T3 = new Tarea(tarea3);

//Añadiendo a la lista
tareas.Add(T1);
tareas.Add(T2);
tareas.Add(T3);

//Imprimiendo la cantidad de elementos
Console.WriteLine("\n=== TUS TAREAS ===");
foreach (var tarea in tareas)
{
  Console.WriteLine("Tarea:" + tarea.Titulo);  
}

