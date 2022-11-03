using Strategy_e_Iterator;
using Strategy_e_Iterator.Interfaces;
using Strategy_e_Iterator.Strategy;
using IComparable = Strategy_e_Iterator.Interfaces.IComparable;


static void LlenarAlumnos(IColeccionable coleccion)
{
    for (int i = 0; i < 20; i++)
    {
        string name = GenerateName(new Random().Next(5, 15));
        Numero dni = new Numero(new Random().Next(10000000, 50000000));
        Numero legajo = new Numero(new Random().Next(1000, 4000));
        Numero promedio = new Numero(new Random().Next(1, 11));
        IComparable alumno = new Alumno(name,dni,legajo,promedio);
        coleccion.Agregar(alumno);
    }
}

static void InformarPersonas(IColeccionable coleccion)
{
    Console.WriteLine("Cantidad elementos: " + coleccion.Cuantos());
    Console.WriteLine("Elemento mas chico: " + coleccion.Minimo());
    Console.WriteLine("Elemento mas grande: " + coleccion.Maximo());
}

/*  Probar alumnos*/
Pila pilaAlumnos = new();
LlenarAlumnos(pilaAlumnos);
InformarPersonas(pilaAlumnos);

static string GenerateName(int len)
{
    Random r = new Random();
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
