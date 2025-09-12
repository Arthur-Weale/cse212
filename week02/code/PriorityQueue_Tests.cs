using System.Collections;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue several items with different priorities and ensure the one 
    // with the highest priority (Y with priority 10) is dequeued first.
    // Expected Result: "Y" should be removed and returned.
    // Defect(s) Found: None – test passed successfully.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("E", 5);
        priorityQueue.Enqueue("F", 3);
        priorityQueue.Enqueue("G", 1);
        priorityQueue.Enqueue("Y", 10);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Y", result);
        //Debug to see if dequeue is removing items
        //To implement this change the PriorityItem class to public
        System.Diagnostics.Debug.WriteLine(string.Join(", ", priorityQueue.Items.Select(i => $"{i.Value}: {i.Priority}")));
    }

    [TestMethod]
    // Scenario: Enqueue three items where two have different priorities 
    // and the highest is B (priority 7).
    // Expected Result: "B" should be removed and returned.
    // Defect(s) Found: None – test passed successfully.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 7);
        priorityQueue.Enqueue("C", 1);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("B", result);
        //Debug to see if dequeue is removing items
        //To implement this change the PriorityItem class to public
        System.Diagnostics.Debug.WriteLine(string.Join(", ", priorityQueue.Items.Select(i => $"{i.Value}: {i.Priority}")));
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: Throws InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: None – exception thrown as expected.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "The queue is empty");
        //Debug to see if dequeue is removing items
        //To implement this change the PriorityItem class to public
        System.Diagnostics.Debug.WriteLine(string.Join(", ", priorityQueue.Items.Select(i => $"{i.Value}: {i.Priority}")));
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same highest priority (8).
    // FIFO should be respected, so "G" should be dequeued first.
    // Expected Result: "G" should be removed and returned.
    // Defect(s) Found: None – test passed successfully.
    public void TestPriorityQueue_MultipleHighPriority()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("G", 8);
        priorityQueue.Enqueue("H", 8);
        priorityQueue.Enqueue("I", 8);
        priorityQueue.Enqueue("J", 7);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("G", result);
        //Debug to see if dequeue is removing items
        //To implement this change the PriorityItem class to public
        System.Diagnostics.Debug.WriteLine(string.Join(", ", priorityQueue.Items.Select(i => $"{i.Value}: {i.Priority}")));
    }

    [TestMethod]
    // Scenario: Enqueue a single item and then dequeue it.
    // Expected Result: The same item "K" should be returned.
    // Defect(s) Found: None – test passed successfully.
    public void TestPriorityQueue_SingleItemInQueue()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("K", 8);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("K", result);
        //Debug to see if dequeue is removing items
        //To implement this change the PriorityItem class to public
        System.Diagnostics.Debug.WriteLine(string.Join(", ", priorityQueue.Items.Select(i => $"{i.Value}: {i.Priority}")));


    }
}