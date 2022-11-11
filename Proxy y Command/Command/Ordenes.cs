namespace ProxyCommand
{
    //Ej8
    public interface IOrdenable
    {
        public void SetOrdenInicio(OrdenEnAula1 ordenEnAula1);
        public void SetOrdenLlegaAlumno(OrdenEnAula2 ordenEnAula1);
        public void SetOrdenAulaLlena(OrdenEnAula1 ordenEnAula1);
    }
    //Ej4,5,6,7
    public interface OrdenEnAula2
    {
        public void Ejecutar(IComparable comparable);
    }
    public interface OrdenEnAula1 : OrdenEnAula2
    {
        public void Ejecutar();
    }

    public abstract class Ordenes : OrdenEnAula1
    {
        protected Aula aula;
        public Ordenes(Aula aula)
        {
            this.aula = aula;
        }
        public abstract void Ejecutar();
        public abstract void Ejecutar(IComparable comparable);
    }
    public class OrdenInicio : Ordenes
    {
        public OrdenInicio(Aula aula) : base(aula)
        {

        }
        public override void Ejecutar()
        {
            aula.Comenzar();
        }
        public override void Ejecutar(IComparable comparable)
        {

        }
    }
    public class OrdenAulaLlena : Ordenes
    {
        public OrdenAulaLlena(Aula aula) : base(aula)
        {

        }
        public override void Ejecutar()
        {
            aula.ClaseLista();
        }
        public override void Ejecutar(IComparable comparable)
        {

        }
    }
    public class OrdenLlegaAlumno : Ordenes
    {
        public OrdenLlegaAlumno(Aula aula) : base(aula)
        {

        }
        public override void Ejecutar(IComparable comparable)
        {
            aula.NuevoAlumno((IEstudiante)comparable);
        }
        public override void Ejecutar()
        {

        }
    }
}

