/*
 * Adpater and Decorator patterns 
 *
 */


namespace ProxyCommand
{
    public interface Student
    {
        string GetName();
        int YourAnswerIs(int question);
        void SetScore(int score);
        int GetScore();
        string ShowResult();
        bool Equals(Student student);
        bool LessThan(Student student);
        bool GreaterThan(Student student);
    }
    public interface Collection
    {
        IteratorOfStudent GetIterator();
        void AddStudent(Student student);
        void Sort();
    }
    public interface IteratorOfStudent
    {
        void Beginning();
        bool End();
        Student Current();
        void Next();
    }
    internal class ListOfStudent : Collection
    {
        private List<Student> list = new List<Student>();

        public IteratorOfStudent GetIterator()
        {
            return new ListOfStudentIterator(list);
        }

        public void AddStudent(Student student)
        {
            list.Add(student);
        }

        public void Sort()
        {
            list.Sort(new StudentComparer());
        }
    }
    internal class ListOfStudentIterator : IteratorOfStudent
    {
        private List<Student> list;
        private int index;

        public ListOfStudentIterator(List<Student> _list)
        {
            list = _list;
        }

        public void Beginning()
        {
            index = 0;
        }

        public bool End()
        {
            return index >= list.Count;
        }

        public Student Current()
        {
            return list[index];
        }

        public void Next()
        {
            index++;
        }
    }
    internal class StudentComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s1.Equals(s2))
                return 0;
            else
            if (s1.LessThan(s2))
                return 1;
            else
                return -1;
        }
    }
    public class Teacher
    {
        private Collection students;

        public Teacher()
        {
            students = new ListOfStudent();
        }

        public void SetStudents(Collection _students)
        {
            students = _students;
        }

        public void GoToClass(Student student)
        {
            students.AddStudent(student);
        }

        public void TeachingAClass()
        {
            Student student;
            IteratorOfStudent iterator = students.GetIterator();

            // Pasar lista
            Console.WriteLine("Good morning\n\n");
            Console.WriteLine("I'm going to take attendance");
            iterator.Beginning();
            while (!iterator.End())
            {
                student = iterator.Current();
                Console.WriteLine("\t" + student.GetName() + " is present");
                iterator.Next();
            }
            Console.WriteLine("\n\n");

            // tomar examen
            Console.WriteLine("I'm going to take an exam");
            iterator.Beginning();
            while (!iterator.End())
            {
                student = iterator.Current();
                TakeAnExam(student);
                iterator.Next();
            }
            Console.WriteLine("\n\n");

            // mostrar resultado
            Console.WriteLine("Exam results");
            students.Sort();
            iterator.Beginning();
            while (!iterator.End())
            {
                student = iterator.Current();
                Console.WriteLine(student.ShowResult() + "\n");
                iterator.Next();
            }
        }

        private void TakeAnExam(Student student)
        {
            int hit = 0;
            for (int i = 0; i < 10; i++)
            {
                int answer = student.YourAnswerIs(i);
                if (answer == (i % 3))
                    hit++;
            }
            student.SetScore(hit);

            Console.WriteLine("\t" + student.GetName() + "'s score is " + hit.ToString());
        }
    }
}
