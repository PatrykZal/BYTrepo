using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Caretaker
    {
        private List<Memento> savedStates = new List<Memento>();

        public void AddMemento(Memento m)
        {
            savedStates.Add(m);
        }

        public Memento GetMemento(int index)
        {
            return savedStates[index];
        }
    }
}
