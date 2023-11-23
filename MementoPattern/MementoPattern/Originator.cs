using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Originator
    {
        private string _state;

        public void SetState(string state)
        {
            Console.WriteLine("Originator: Setting state to " + state);
            _state = state;
        }

        public Memento SaveToMemento()
        {
            Console.WriteLine("Originator: Saving to Memento.");
            return new Memento(_state);
        }

        public void RestoreFromMemento(Memento memento)
        {
            _state = memento.State;
            Console.WriteLine("Originator: State after restoring from Memento: " + _state);
        }
    }

}
