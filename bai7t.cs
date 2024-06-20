using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Tạo một Dictionary
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Thêm một số cặp key-giá trị vào Dictionary
        dictionary.Add("one", 1);
        dictionary.Add("two", 2);
        dictionary.Add("three", 3);
        dictionary.Add("four", 4);
        dictionary.Add("five", 5);

        // Kiểm tra sự tồn tại của một key
        string keyToCheck = "two";
        if (dictionary.ContainsKey(keyToCheck))
        {
            Console.WriteLine($"Key '{keyToCheck}' tồn tại trong Dictionary.");
        }
        else
        {
            Console.WriteLine($"Key '{keyToCheck}' không tồn tại trong Dictionary.");
        }

        // Sử dụng TryGetValue để truy xuất giá trị được liên kết với một key nhất định một cách an toàn
        string keyToRetrieve = "three";
        if (dictionary.TryGetValue(keyToRetrieve, out int value))
        {
            Console.WriteLine($"Giá trị tương ứng với key '{keyToRetrieve}' là: {value}");
        }
        else
        {
            Console.WriteLine($"Key '{keyToRetrieve}' không tồn tại trong Dictionary.");
        }

        // Sử dụng vòng lặp foreach để lặp qua các mục KeyValuePair<TKey, TValue> trong Dictionary và in chúng
        Console.WriteLine("\nCác cặp key-giá trị trong Dictionary:");
        foreach (KeyValuePair<string, int> kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}
