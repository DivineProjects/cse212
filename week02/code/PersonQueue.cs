/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    // / <param name="person">The person to add</param>
    public void Enqueue(Person person)
    {
        // _queue.Insert(0, person);
        _queue.Add(person);
        // Console.WriteLine($"Added {person} to the {_queue.ToString()}");
    }

    public Person Dequeue()
    {
        var person = _queue[0];
        _queue.RemoveAt(0);
        // Console.WriteLine($"Premoved {person} to the {_queue.ToString()}");

        return person;
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}