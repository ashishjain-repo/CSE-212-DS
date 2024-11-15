using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: ["Task2", "Task4", "Task3", "Task1"]
    // Defect(s) Found: Dequeue function was not set properly, the variable types were fixed to match the conditions, and instead of using >= used <.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        var queue1 = new PriorityItem("Task1", 1);
        var queue2 = new PriorityItem("Task2", 3);
        var queue3 = new PriorityItem("Task3", 2);
        var queue4 = new PriorityItem("Task4", 3);
        string[] expectedResult = ["Task2", "Task4", "Task3", "Task1"];

        priorityQueue.Enqueue(queue1.Value, queue1.Priority);
        priorityQueue.Enqueue(queue2.Value, queue2.Priority);
        priorityQueue.Enqueue(queue3.Value, queue3.Priority);
        priorityQueue.Enqueue(queue4.Value, queue4.Priority);

        int i = 0;
        while (true)
        {
            try
            {
                // Dequeue the item and compare it to the expected result
                var dequeuedValue = priorityQueue.Dequeue();
                Console.WriteLine(dequeuedValue);
                Assert.AreEqual(expectedResult[i], dequeuedValue, $"Expected {expectedResult[i]} but got {dequeuedValue}.");
                i++;
            }
            catch (InvalidOperationException)
            {
                // Queue is empty, break the loop
                break;
            }
        }
        Assert.AreEqual(expectedResult.Length, i, "All expected items should have been dequeued.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        var queue1 = new PriorityItem("Task1", 1);
        var queue2 = new PriorityItem("Task2", 3);
        var queue3 = new PriorityItem("Task3", 2);
        var queue4 = new PriorityItem("Task4", 3);
        var queue5 = new PriorityItem("Task5", 4);
        var queue6 = new PriorityItem("Task6", 3);
        string[] expectedResult = ["Task5", "Task2", "Task4", "Task6", "Task3", "Task1"];

        priorityQueue.Enqueue(queue1.Value, queue1.Priority);
        priorityQueue.Enqueue(queue2.Value, queue2.Priority);
        priorityQueue.Enqueue(queue3.Value, queue3.Priority);
        priorityQueue.Enqueue(queue4.Value, queue4.Priority);
        priorityQueue.Enqueue(queue5.Value, queue5.Priority);
        priorityQueue.Enqueue(queue6.Value, queue6.Priority);

        int i = 0;
        while (true)
        {
            try
            {
                // Dequeue the item and compare it to the expected result
                var dequeuedValue = priorityQueue.Dequeue();
                Console.WriteLine(dequeuedValue);
                Assert.AreEqual(expectedResult[i], dequeuedValue, $"Expected {expectedResult[i]} but got {dequeuedValue}.");
                i++;
            }
            catch (InvalidOperationException)
            {
                // Queue is empty, break the loop
                break;
            }
        }
        Assert.AreEqual(expectedResult.Length, i, "All expected items should have been dequeued.");
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue3()
    {
        int queue4Priority = 0;
        var priorityQueue = new PriorityQueue();
        var queue1 = new PriorityItem("Task1", 1);
        var queue2 = new PriorityItem("Task2", 3);
        var queue3 = new PriorityItem("Task3", 2);
        var queue4 = new PriorityItem("Task4", queue4Priority);
        var queue5 = new PriorityItem("Task5", 4);
        var queue6 = new PriorityItem("Task6", 3);
        string[] expectedResult = ["Task5", "Task2", "Task6", "Task3", "Task1", "Task4"];

        priorityQueue.Enqueue(queue1.Value, queue1.Priority);
        priorityQueue.Enqueue(queue2.Value, queue2.Priority);
        priorityQueue.Enqueue(queue3.Value, queue3.Priority);
        priorityQueue.Enqueue(queue4.Value, queue4.Priority);
        priorityQueue.Enqueue(queue5.Value, queue5.Priority);
        priorityQueue.Enqueue(queue6.Value, queue6.Priority);

        int i = 0;
        while (true)
        {
            try
            {
                // Dequeue the item and compare it to the expected result
                var dequeuedValue = priorityQueue.Dequeue();
                Console.WriteLine(dequeuedValue);
                Assert.AreEqual(expectedResult[i], dequeuedValue, $"Expected {expectedResult[i]} but got {dequeuedValue}.");
                i++;
            }
            catch (InvalidOperationException)
            {
                // Queue is empty, break the loop
                break;
            }
        }
        Assert.AreEqual(expectedResult.Length, i, "All expected items should have been dequeued.");
    }
}