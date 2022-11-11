using Interfaces;
using IComparable = Interfaces.IComparable;

static void Llenar(IColeccionable coleccion)
{
    for (int i = 0; i < 800; i++)
    {
        coleccion.Agregar(new Numero(new Random().Next(1, 50)));
    }
}
static void Informar(IColeccionable coleccion)
{
    Console.WriteLine("Cuantos: " + coleccion.Cuantos());
    Console.WriteLine("Minimo: " + coleccion.Minimo());
    Console.WriteLine("Maximo: " + coleccion.Maximo());
    Console.Write("Ingrese un numero y le digo si esta en la lista: ");
    int lectura = Convert.ToInt32(Console.ReadLine());
    if (coleccion.Contiene(new Numero(lectura)))
    {
        Console.Write("Está contenido.");
    }
    else
    {
        Console.Write("No está contenido.");
    }
}
/* Probar numeros
Pila pila = new();
Llenar(pila);
Informar(pila);*/


static void LlenarPersonas(IColeccionable coleccion)
{
    for (int i = 0; i < 20; i++)
    {
        string name = GenerateName(new Random().Next(5, 15));
        Numero dni = new(new Random().Next(10000000, 50000000));
        IComparable persona = new Persona(name, dni);
        coleccion.Agregar(persona);
    }
}

static void InformarPersonas(IColeccionable coleccion)
{
    Console.WriteLine("Cantidad elementos: " + coleccion.Cuantos());
    Console.WriteLine("Elemento mas chico: " + coleccion.Minimo());
    Console.WriteLine("Elemento mas grande: " + coleccion.Maximo());
}
/*Probar personas
Pila pila = new();
LlenarPersonas(pila);
Console.WriteLine(pila.Minimo());*/



static void LlenarAlumnos(IColeccionable coleccion)
{
    for (int i = 0; i < 20; i++)
    {
        string name = GenerateName(new Random().Next(5, 15));
        Numero dni = new(new Random().Next(10000000, 50000000));
        Numero legajo = new(new Random().Next(1000, 4000));
        Numero promedio = new(new Random().Next(1, 11));
        IComparable alumno = new Alumno(name, dni, legajo, promedio);
        coleccion.Agregar(alumno);
    }
}
/*  Probar alumnos
Pila pilaAlumnos = new();
LlenarAlumnos(pilaAlumnos);
InformarPersonas(pilaAlumnos);*/

static string GenerateName(int len)
{
    Random r = new();
    string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
    string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
    string Name = "";
    Name += consonants[r.Next(consonants.Length)].ToUpper();
    Name += vowels[r.Next(vowels.Length)];
    int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
    while (b < len)
    {
        Name += consonants[r.Next(consonants.Length)];
        b++;
        Name += vowels[r.Next(vowels.Length)];
        b++;
    }
    return Name;
}







