using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> tuDienAnhViet = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        int luaChon;
        do
        {
            Console.WriteLine("1. Thêm từ mới vào từ điển");
            Console.WriteLine("2. Tra cứu nghĩa của từ");
            Console.WriteLine("3. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    ThemTuMoi();
                    break;
                case 2:
                    TraCuuNghiaTu();
                    break;
                case 3:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại.");
                    break;
            }
        } while (luaChon != 3);
    }

    static void ThemTuMoi()
    {
        Console.Write("Nhập từ tiếng Anh: ");
        string tuTiengAnh = Console.ReadLine();
        if (tuDienAnhViet.ContainsKey(tuTiengAnh))
        {
            Console.WriteLine("Từ này đã có trong từ điển.");
            return;
        }

        Console.Write("Nhập nghĩa tiếng Việt: ");
        string nghiaTiengViet = Console.ReadLine();

        tuDienAnhViet[tuTiengAnh] = nghiaTiengViet;
        Console.WriteLine("Đã thêm từ thành công!");
    }

    static void TraCuuNghiaTu()
    {
        Console.Write("Nhập từ tiếng Anh cần tra cứu: ");
        string tuTiengAnh = Console.ReadLine();

        if (tuDienAnhViet.TryGetValue(tuTiengAnh, out string nghiaTiengViet))
        {
            Console.WriteLine($"Nghĩa tiếng Việt của từ '{tuTiengAnh}' là: {nghiaTiengViet}");
        }
        else
        {
            Console.WriteLine("Từ này không có trong từ điển.");
        }
    }
}
