using MementoPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Caretaker caretaker = new Caretaker();
        Originator originator = new Originator();

        originator.SetState("State1");
        originator.SetState("State2");
        caretaker.AddMemento(originator.SaveToMemento());
        originator.SetState("State3");
        caretaker.AddMemento(originator.SaveToMemento());
        originator.SetState("State4");

        originator.RestoreFromMemento(caretaker.GetMemento(0));
        originator.RestoreFromMemento(caretaker.GetMemento(1));
    }
}