namespace AdapterDecorator
{
    public class Persona : IComparable
    {
        private string nombre;
        private Numero dni;
        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = new Numero(dni);
        }
        public Numero GetDni()
        {
            return dni;
        }
        public string GetNombre()
        {
            return nombre;
        }
        //Interfaz IComparable
        public virtual bool SosIgual(IComparable elem)
        {
            return this.GetDni() == ((Persona)elem).GetDni();
        }

        public virtual bool SosMayor(IComparable elem)
        {
            return this.GetDni().SosMayor(((Persona)elem).GetDni());
        }

        public virtual bool SosMenor(IComparable elem)
        {
            return this.GetDni().SosMenor(((Persona)elem).GetDni());
        }
        public override string ToString()
        {
            return "Persona " + GetNombre() + "Dni " + GetDni().ToString();
        }
    }
}
