namespace ProxyCommand
{
    public class Aula
    {
        Teacher profesor;
        public void Comenzar()
        {
            Console.WriteLine("Doy inicio a la clase");
            profesor = new Teacher();
        }
        public void NuevoAlumno(IEstudiante alumno)
        {
            profesor.GoToClass(new AdaptadorAlumno(alumno));
        }
        public void ClaseLista()
        {
            profesor.TeachingAClass();
        }
    }

}
