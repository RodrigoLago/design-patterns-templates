using Strategy_e_Iterator.Interfaces;
using IComparable = Strategy_e_Iterator.Interfaces.IComparable;

namespace Strategy_e_Iterator
{
    public class Persona : IComparable
    {
        public string Nombre { get; set; }
        public Numero Dni { get; set; }
        public Persona(string nombre, Numero dni)
        {
            Nombre = nombre;
            Dni = dni;
        }

        public bool SosIgual(IComparable comparable)
        {
            return this.Dni.SosIgual(((Persona)comparable).Dni);
        }

        public bool SosMayor(IComparable comparable)
        {
            return this.Dni.SosMayor(((Persona)comparable).Dni);
        }

        public bool SosMenor(IComparable comparable)
        {
            return this.Dni.SosMenor(((Persona)comparable).Dni);
        }
        public override string ToString()
        {
            return Nombre + " " + Dni.Valor;
        }
    }
}
