using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items to the queue with different priorities and then Dequeue the item with the highes priority.
    // Expected Result: The item with the highest priority is returned.
    // Defect(s) Found: Found that the Dequeue method was not returning the item with the highest priority. It was returning the first item in the queu instead. Fixed the Dequeue method to find the item with the highest priority and return it.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Tim", result);
    }

    [TestMethod]
    // Scenario: Add two items with the same highest priority.
    // Expected Result: The first item added should be removed first.
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Tim", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenerio: Dequeue from an empty queue.
    // Expected Result: InvalidOperationException with the correct message.
    // Defect(s) Found:
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

}