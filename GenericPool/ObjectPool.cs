using System;
using System.Collections.Generic;
using System.Text;

public class ObjectPool<T> where T : class, IPoolable, new()
{
    private List<T> _available;
    private List<T> _active;

    public int MaxSize { get; set; }
    public ObjectPool(int maxSize)
    {
        _available = new List<T>();
        _active = new List<T>();
        MaxSize = maxSize;
    }
    public T Get()
    {
        if (_available.Count == 0)
        {
            if (_available.Count + _active.Count >= MaxSize)
            {
                return default(T);
            }
            _active.Add(new T());
            return _active[_active.Count - 1];
        }
        _active.Add(_available[_available.Count - 1]);
        _available.RemoveAt(_available.Count - 1);
        return _active[_active.Count - 1];
    }

    public void Return(T item)
    {
        item.Reset();
        _active.Remove(item);
        _available.Add(item);
    }
    public int ActiveCount => _active.Count;
    public int AvailableCount => _available.Count;
}