using System;

class Program
{
    // Hàm generic Max để tìm giá trị lớn nhất giữa hai giá trị
    public static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    static void Main(string[] args)
    {
        // Kiểm tra hàm Max với các kiểu dữ liệu khác nhau

        // Số nguyên
        int int1 = 5;
        int int2 = 10;
        Console.WriteLine($"Max giữa {int1} và {int2} là: {Max(int1, int2)}");

        // Số thực
        double double1 = 5.5;
        double double2 = 10.5;
        Console.WriteLine($"Max giữa {double1} và {double2} là: {Max(double1, double2)}");

        // Chuỗi
        string str1 = "apple";
        string str2 = "banana";
        Console.WriteLine($"Max giữa \"{str1}\" và \"{str2}\" là: \"{Max(str1, str2)}\"");

        // Các kiểu dữ liệu khác cũng có thể được kiểm tra tương tự
    }
}
