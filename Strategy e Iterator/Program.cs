using Strategy_e_Iterator;

static void LlenarAlumnos(IColeccionable coleccion)
{
    for (int i = 0; i < 20; i++)
    {
        string name = GenerateName(new Random().Next(5, 15));
        Numero dni = new (new Random().Next(10000000, 50000000));
        Numero legajo = new (new Random().Next(1000, 4000));
        Numero promedio = new (new Random().Next(1, 11));
        Strategy_e_Iterator.IComparable alumno = new Alumno(name,dni,legajo,promedio);
        coleccion.Agregar(alumno);
    }
}

static void InformarPersonas(IColeccionable coleccion)
{
    Console.WriteLine("Cantidad elementos: " + coleccion.Cuantos());
    Console.WriteLine("Elemento mas chico: " + coleccion.Minimo());
    Console.WriteLine("Elemento mas grande: " + coleccion.Maximo());
}

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

Pila pila = new ();
Cola cola = new ();
Conjunto conjunto = new ();
Diccionario diccionario = new ();
LlenarAlumnos(pila);
LlenarAlumnos(cola);
LlenarAlumnos(conjunto);
LlenarAlumnos(diccionario);

Console.WriteLine("Por legajo:");
CambiarEstrategia(pila, new LegajoStrategy());
InformarPersonas(pila);

Console.WriteLine("\nPor Dni:");
CambiarEstrategia(pila, new DniStrategy());
InformarPersonas(pila);

Console.WriteLine("\nPor Nombre:");
CambiarEstrategia(pila, new NombreStrategy());
InformarPersonas(pila);

Console.WriteLine("\nPor Promedio:");
CambiarEstrategia(pila, new PromedioStrategy());
InformarPersonas(pila);


//El siguiente codigo es para mostrar cada elemento de cada coleccion utilizando la funcion InformarElemento:
Console.WriteLine("\n***Pila***");
InformarElemento(pila);
Console.WriteLine("\n***Cola***");
InformarElemento(cola);
Console.WriteLine("\n***Conjunto***");
InformarElemento(conjunto);
Console.WriteLine("\n***Diccionario***");
InformarElemento(diccionario);


static void InformarElemento(IIterable coleccionIterable)
{
    IIterator iter = coleccionIterable.CrearIterador();
    while (iter.HasNext())
    {
        Console.WriteLine(iter.Current());
        iter.Next();
    }
}

static void CambiarEstrategia(IIterable coleccionIterable, IAlumnoStrategy estrategia)
{
    IIterator iter = coleccionIterable.CrearIterador();
    while (iter.HasNext())
    {
        ((Alumno)iter.Current()).SetStrategy(estrategia);
        iter.Next();
    }
}

