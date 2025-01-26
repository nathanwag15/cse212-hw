using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following people and priorities: Steve(1), Ryan(3), Elphaba(5), Eric(2) 
    // Expected Result: Elphaba, Ryan, Eric, Steve
    // Defect(s) Found: Assert.AreEqual failed. Expected:<Ryan>. Actual:<Elphaba>.
    // The index started at 1 and only went up to the total count of the queue minues one. Basically meaning it never got to eric to test it's priority. 
    public void TestPriorityQueue_1()
    {
        var steve = new PriorityItem("Steve", 1);
        var ryan = new PriorityItem("Ryan", 3);
        var elphaba = new PriorityItem("Elphaba", 5);
        var eric = new PriorityItem("Eric", 2);
        

        PriorityItem[] expectedResult = [elphaba, ryan, eric, steve];
    
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(steve.Value, steve.Priority);
        priorityQueue.Enqueue(ryan.Value, ryan.Priority);
        priorityQueue.Enqueue(elphaba.Value, elphaba.Priority);
        priorityQueue.Enqueue(eric.Value, eric.Priority);

        int i = 0;
        while (i < 4)
        {
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }

    }

    [TestMethod]
    // Scenario: Scenario: Create a queue with the following people and priorities: Steve(1), Ryan(3), Elphaba(5), Eric(5) 
    // Expected Result: Elphaba, Eric, Ryan, Steve
    // Defect(s) Found: Assert.AreEqual failed. Expected:<Elphaba>. Actual:<Eric>. 
    // It needed to have the if statment check if the Priority is higher instead of checking if the priority is greater than or equal to. 
    public void TestPriorityQueue_2()
    {
        var steve = new PriorityItem("Steve", 1);
        var ryan = new PriorityItem("Ryan", 3);
        var elphaba = new PriorityItem("Elphaba", 5);
        var eric = new PriorityItem("Eric", 5);
        

        PriorityItem[] expectedResult = [elphaba, eric, ryan, steve];
    
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(steve.Value, steve.Priority);
        priorityQueue.Enqueue(ryan.Value, ryan.Priority);
        priorityQueue.Enqueue(elphaba.Value, elphaba.Priority);
        priorityQueue.Enqueue(eric.Value, eric.Priority);

        int i = 0;
        while (i < 4)
        {
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }
    }

    // Add more test cases as needed below.
}