using System;

SimpleQueue<int> sqi = new SimpleQueue<int>(3);
Console.WriteLine("=== int 큐 (용량: 3) ===");
Console.WriteLine("Enqueue: 10, 20, 30");
sqi.Enqueue(10);
sqi.Enqueue(20);
sqi.Enqueue(30);
Console.WriteLine($"Count: {sqi.Count}, IsFull: {sqi.IsFull}");
sqi.Enqueue(50);
Console.WriteLine($"Peek: {sqi.Peek()}");
Console.WriteLine($"Dequeue: {sqi.Dequeue()}");
Console.WriteLine($"Dequeue: {sqi.Dequeue()}");
Console.WriteLine($"Count: {sqi.Count}, IsFull: {sqi.IsFull}");

SimpleQueue<string> sqs = new SimpleQueue<string>(2);
Console.WriteLine("\n=== string 큐 (용량: 2) ===");
Console.WriteLine("Enqueue: Hello, World");
sqs.Enqueue("Hello");
sqs.Enqueue("World");
Console.WriteLine($"Count: {sqs.Count}, IsFull: {sqs.IsFull}");
Console.WriteLine($"Dequeue: {sqs.Dequeue()}");
Console.WriteLine($"Dequeue: {sqs.Dequeue()}");
sqs.Dequeue();
Console.WriteLine($"IsEmpty: {sqs.IsEmpty}");
