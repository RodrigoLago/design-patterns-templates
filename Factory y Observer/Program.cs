using FactoryObserver;

Gerente gerente = new Gerente("Jefe");
Pila pila = new Pila();
Helper.Llenar(pila, 3);
Console.WriteLine("Lista de vendedores :");
Helper.InformarElementos(pila);
//Helper.Informar(pila,3);

Console.WriteLine("\n\nLista de ventas :");
IIterator iter = pila.CrearIterador();
while (iter.HasNext())
{
    ((Vendedor)iter.Current()).AgregarObservador(gerente);
    iter.Next();
}
Helper.JornadaDeVentas(pila);
Console.WriteLine("\n\nMejores vendedores :");
gerente.Cerrar();
Console.ReadKey();
