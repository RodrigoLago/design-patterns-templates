using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryObserver
{
    public interface IEstrategiaAlumno
    {
        public bool SosIgual(IComparable a1, IComparable a2);
        public bool SosMenor(IComparable a1, IComparable a2);
        public bool SosMayor(IComparable a1, IComparable a2);
    }
}
