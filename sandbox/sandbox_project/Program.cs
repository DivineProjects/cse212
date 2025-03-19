using System;
using System.Collections.Generic;
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
    }

    public Person Dequeue()
    {
        var person = _queue[0];
        _queue.RemoveAt(0);
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

public class Person
{
    public readonly string Name;
    public int Turns { get; set; }

    internal Person(string name, int turns)
    {
        Name = name;
        Turns = turns;
    }

    public override string ToString()
    {
        return Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})";
    }
}

public class TakingTurnsQueue
{
    private readonly PersonQueue _people = new();

    public int Length => _people.Length;

    /// <summary>
    /// Add new people to the queue with a name and number of turns
    /// </summary>
    // / <param name="name">Name of the person</param>
    // / <param name="turns">Number of turns remaining</param>
    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    /// <summary>
    /// Get the next person in the queue and return them. The person should
    /// go to the back of the queue again unless the turns variable shows that they 
    /// have no more turns left.  Note that a turns value of 0 or less means the 
    /// person has an infinite number of turns.  An error exception is thrown 
    /// if the queue is empty.
    /// </summary>
    public Person GetNextPerson()
    {
        if (_people.IsEmpty())
        {
            throw new InvalidOperationException("No one in the queue.");
        }
        else
        {
            Person person = _people.Dequeue();
            if (person.Turns > 1)
            {
                person.Turns -= 1;
                _people.Enqueue(person);
            } else if (person.Turns <= 0)
            {
                _people.Enqueue(person);
            }
            
            // Console.WriteLine(person.ToString());
            return person;
        }
    }

    public override string ToString()
    {
        return _people.ToString();
    }
}



public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.
        
        var players = new TakingTurnsQueue();

        try
        {
            players.GetNextPerson();
            // Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"No one in the queue.== {e.Message}");
        }
     
        catch (Exception e)
        {
            Console.WriteLine(
                 string.Format($"Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
        
    
}