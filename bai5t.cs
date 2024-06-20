using System;
using System.Collections.Generic;

class MyStack<T>
{
    private List<T> elements = new List<T>();

    // Phương thức thêm phần tử vào ngăn xếp
    public void Push(T item)
    {
        elements.Add(item);
    }

    // Phương thức loại bỏ và trả về phần tử trên cùng của ngăn xếp
    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Ngăn xếp trống.");
        }

        T item = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return item;
    }

    // Phương thức kiểm tra ngăn xếp có trống hay không
    public bool IsEmpty()
    {
        return elements.Count == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Kiểm tra MyStack với kiểu dữ liệu int
        MyStack<int> intStack = new MyStack<int>();
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);
        Console.WriteLine("Pop từ intStack: " + intStack.Pop()); // 30
        Console.WriteLine("Pop từ intStack: " + intStack.Pop()); // 20
        Console.WriteLine("Pop từ intStack: " + intStack.Pop()); // 10

        // Kiểm tra MyStack với kiểu dữ liệu string
        MyStack<string> stringStack = new MyStack<string>();
        stringStack.Push("apple");
        stringStack.Push("banana");
        stringStack.Push("cherry");
        Console.WriteLine("Pop từ stringStack: " + stringStack.Pop()); // cherry
        Console.WriteLine("Pop từ stringStack: " + stringStack.Pop()); // banana
        Console.WriteLine("Pop từ stringStack: " + stringStack.Pop()); // apple

        // Kiểm tra với ngăn xếp trống
        try
        {
            Console.WriteLine("Pop từ intStack: " + intStack.Pop());
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Lỗi: " + e.Message);
        }
    }
}
