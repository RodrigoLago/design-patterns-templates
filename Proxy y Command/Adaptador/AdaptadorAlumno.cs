namespace ProxyCommand
{
    class AdaptadorAlumno : Student, IComparable
    {
        IEstudiante alumno;
        public AdaptadorAlumno(IEstudiante alumno)
        {
            this.alumno = alumno;
        }
        private IEstudiante GetAlumno()
        {
            return alumno;
        }
        public bool Equals(Student student)
        {
            return alumno.SosIgual(((AdaptadorAlumno)student).GetAlumno());
        }

        public string GetName()
        {
            return alumno.GetNombre();
        }

        public bool GreaterThan(Student student)
        {
            return alumno.SosMayor(((AdaptadorAlumno)student).GetAlumno());
        }

        public bool LessThan(Student student)
        {
            return alumno.SosMenor(((AdaptadorAlumno)student).GetAlumno());
        }

        public void SetScore(int score)
        {
            alumno.SetCalificacion(score);
        }
        public int GetScore()
        {
            return alumno.GetCalificacion();
        }
        public string ShowResult()
        {
            return alumno.MostrarCalificacion();
        }
        public int YourAnswerIs(int question)
        {
            return alumno.ResponderPregunta(question);
        }
        public bool SosIgual(IComparable elem)
        {
            return alumno.SosIgual((AdaptadorAlumno)elem);
        }

        public bool SosMenor(IComparable elem)
        {
            return alumno.SosMenor((AdaptadorAlumno)elem);
        }

        public bool SosMayor(IComparable elem)
        {
            return alumno.SosMayor((AdaptadorAlumno)elem);
        }


    }
}
