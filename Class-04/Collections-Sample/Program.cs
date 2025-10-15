using System; 
using System.Collections.Generic;

static void DemoList()
{
    var list = new List<int> { 1, 2, 3 };
    list.Add(4);               // add
    list[0] = 10;              // update by index
    list.Remove(2);            // remove by value
    list.RemoveAt(1);

    Console.WriteLine("List<T> contents:");
    foreach (var x in list)
        Console.WriteLine(x);
}

static void DemoLinkedList()
{
    var ll = new LinkedList<string>();
    ll.AddLast("a");
    var nodeB = ll.AddLast("b");
    ll.AddBefore(nodeB, "x");      // insert before a node (O(1))
    ll.Remove("a");                // remove by value
    ll.

    Console.WriteLine("LinkedList<T> contents:");
    foreach (var s in ll)
        Console.WriteLine(s);
}

static void DemoSortedList()
{
    var sl = new SortedList<int, string>();
    sl.Add(2, "two");
    sl.Add(1, "one");
    sl[3] = "three";               // set via indexer by key

    Console.WriteLine("SortedList<TKey,TValue> contents (in key order):");
    foreach (var kvp in sl)
        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

static void DemoQueue()
{
    var q = new Queue<string>();
    q.Enqueue("first");
    q.Enqueue("second");

    Console.WriteLine("Queue<T> operations:");
    Console.WriteLine("Dequeue -> " + q.Dequeue()); // "first"
    Console.WriteLine("Peek  -> " + q.Peek());      // "second" (without removing)
}

static void DemoStack()
{
    var s = new Stack<int>();
    s.Push(1);
    s.Push(2);

    Console.WriteLine("Stack<T> operations:");
    Console.WriteLine("Pop  -> " + s.Pop());   // 2
    Console.WriteLine("Peek -> " + s.Peek());  // 1 (top but not removed)
}

DemoList();
Console.WriteLine(new string('-', 40));
DemoLinkedList();
Console.WriteLine(new string('-', 40));
DemoSortedList();
Console.WriteLine(new string('-', 40));
DemoQueue();
Console.WriteLine(new string('-', 40));
DemoStack();

