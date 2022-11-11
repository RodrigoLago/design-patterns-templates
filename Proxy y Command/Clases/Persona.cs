namespace ProxyCommand
{
    public class Persona : IComparable
    {
        private string nombre;
        private int dni;
        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        public int GetDni()
        {
            return dni;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        //Interfaz IComparable
        public virtual bool SosIgual(IComparable elem)
        {
            return this.GetDni() == ((Persona)elem).GetDni();
        }

        public virtual bool SosMayor(IComparable elem)
        {
            return this.GetDni() < (((Persona)elem).GetDni());
        }

        public virtual bool SosMenor(IComparable elem)
        {
            return this.GetDni() > (((Persona)elem).GetDni());
        }
        public override string ToString()
        {
            return "Persona " + GetNombre() + "Dni " + GetDni().ToString();
        }
    }
}
