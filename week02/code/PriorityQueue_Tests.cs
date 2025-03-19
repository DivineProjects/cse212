using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Testing Enqueue and Dequeue with distinct priorities.
    // Expected Result: Tim
    
    public void TestPriorityQueue_1()
    {
        var bob = new Person("Bob", 2);
        var tim = new Person("Tim", 5);
        var sue = new Person("Sue", 3);

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Name, 2);  
        priorityQueue.Enqueue(tim.Name, 5);  // Highest priority
        priorityQueue.Enqueue(sue.Name, 3);  

        // Dequeueing should give us the person with the highest priority first
        Assert.AreEqual("Tim", priorityQueue.Dequeue());  // Expect "Tim" with priority 5
    }

    [TestMethod]
    // Scenario: Testing FIFO behavior when priorities are the same.
    // Expected Result: Bob.
    // Defect(s) Found
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Bob", 3);  // Highest priority
        priorityQueue.Enqueue("Tim", 1);  
        priorityQueue.Enqueue("Sue", 3);  // Highest priority
        
        // FIFO order: "Bob" the first one inserted should be dequeued first
        Assert.AreEqual("Bob", priorityQueue.Dequeue());  // Expect "Bob" (FIFO order) 
    }

    [TestMethod]
    // Scenario: Testing Dequeue when the queue is empty.
    // Expected Result: An InvalidOperationException should be thrown.
    // Defect(s) Found: None expected.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        
        // Queue is empty at the start
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}