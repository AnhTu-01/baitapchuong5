using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Tạo một Hashtable
        Hashtable hashtable = new Hashtable();

        // Thêm một số cặp key-giá trị vào Hashtable
        hashtable.Add("one", 1);
        hashtable.Add("two", 2);
        hashtable.Add("three", 3);
        hashtable.Add(4, "four");
        hashtable.Add(5, "five");

        // Kiểm tra sự tồn tại của một key
        string keyToCheck = "two";
        if (hashtable.ContainsKey(keyToCheck))
        {
            Console.WriteLine($"Key '{keyToCheck}' tồn tại trong Hashtable.");
        }
        else
        {
            Console.WriteLine($"Key '{keyToCheck}' không tồn tại trong Hashtable.");
        }

        // Kiểm tra sự tồn tại của một giá trị
        object valueToCheck = 3;
        if (hashtable.ContainsValue(valueToCheck))
        {
            Console.WriteLine($"Giá trị '{valueToCheck}' tồn tại trong Hashtable.");
        }
        else
        {
            Console.WriteLine($"Giá trị '{valueToCheck}' không tồn tại trong Hashtable.");
        }

        // Truy xuất giá trị bằng chỉ mục
        object keyToRetrieve = "one";
        if (hashtable.ContainsKey(keyToRetrieve))
        {
            Console.WriteLine($"Giá trị tương ứng với key '{keyToRetrieve}' là: {hashtable[keyToRetrieve]}");
        }

        // Sử dụng vòng lặp foreach để lặp qua các key và giá trị
        Console.WriteLine("\nCác cặp key-giá trị trong Hashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
