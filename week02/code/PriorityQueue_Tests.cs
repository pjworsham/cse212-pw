using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities, with the highest priority item added last.
    // Expected Result: The item with the highest priority, C, should be removed first
    // Defect(s) Found: The last item in the queue was not being checked
    // Changed _queue.Count -1 to _queue.Count so all items are checked
     public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 5);

        Assert.AreEqual("C", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add two items with the same highest priority, with A added before B.
    // Expected Result: A should be removed before B because equal priorities follow FIFO order.
    // Defect(s) Found: The >= caused the later item with the same priority
    // to be selected. Changed >= to > so equal priorities follow FIFO
      public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

     [TestMethod]
    // Scenario: Add three items, remove the hightest priority item, then remove another item.
    // Expected Result: B should be removed first, and C should be removed second.
    // Defect(s) Found: Dequeue returned the highest priority item but did not remove it from the
    // queue. Added_RemoveAt(highPriorityIndex) before returning the value
      public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
    }

     [TestMethod]
    // Scenario: Try to dequeue from an empty queue
    // Expected Result: An InvalidOperationException should be thrown with the message "The queue is empty"
    // Defect(s) Found: The correct InvaidOperationException 
    // with the message "The queue is empty. "was already being thrown
     public void TestPriorityQueue_4()
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
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail($"Unexpected exception: {e.Message}");
        }
    }
}

