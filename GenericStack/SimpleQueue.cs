using System;
using System.Collections.Generic;
using System.Text;

public class SimpleQueue<T>
{
    private T[] values;
    private int _count = 0;
    private int MaxCount;
    public int Count { get { return _count; } }
    public bool IsFull => _count >= MaxCount;
    public bool IsEmpty => _count == 0;
    public SimpleQueue(int capacity)
    {
        MaxCount = capacity;
        values = new T[capacity];
    }

    public void Enqueue(T item)
    {
        if (_count >= MaxCount)
        {
            Console.WriteLine("출력이 가득 찼습니다.");
            return;
        }
        values[_count++] = item;
    }

    public T Dequeue()
    {
        if (_count == 0)
        {
            Console.WriteLine("큐가 비어있습니다..");
            return default(T);
        }
        T item = values[0];
        for (int i = 1; i < _count; i++)
        {
            values[i - 1] = values[i];
        }
        _count--;
        return item;
    }
    public T Peek()
    {
        if (_count == 0)
        {
            Console.WriteLine("큐가 비어있습니다..");
            return default(T);
        }
        return values[0];
    }
}