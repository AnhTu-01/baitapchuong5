using System;
using System.Collections.Generic;

class SinhVien
{
    public string Ten { get; set; }
    public string Lop { get; set; }
    public double Diem { get; set; }

    public SinhVien(string ten, string lop, double diem)
    {
        Ten = ten;
        Lop = lop;
        Diem = diem;
    }

    public override string ToString()
    {
        return $"Tên: {Ten}, Lớp: {Lop}, Điểm: {Diem}";
    }
}

class Program
{
    static List<SinhVien> danhSachSinhVien = new List<SinhVien>();

    static void Main(string[] args)
    {
        int luaChon;
        do
        {
            Console.WriteLine("1. Thêm sinh viên mới");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("3. Tính tổng điểm của tất cả sinh viên");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    ThemSinhVienMoi();
                    break;
                case 2:
                    HienThiDanhSachSinhVien();
                    break;
                case 3:
                    TinhTongDiem();
                    break;
                case 4:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại.");
                    break;
            }
        } while (luaChon != 4);
    }

    static void ThemSinhVienMoi()
    {
        Console.Write("Nhập tên sinh viên: ");
        string ten = Console.ReadLine();
        Console.Write("Nhập lớp sinh viên: ");
        string lop = Console.ReadLine();
        Console.Write("Nhập điểm của sinh viên: ");
        double diem = double.Parse(Console.ReadLine());

        SinhVien sv = new SinhVien(ten, lop, diem);
        danhSachSinhVien.Add(sv);
        Console.WriteLine("Đã thêm sinh viên thành công!");
    }

    static void HienThiDanhSachSinhVien()
    {
        Console.WriteLine("Danh sách sinh viên:");
        foreach (var sv in danhSachSinhVien)
        {
            Console.WriteLine(sv);
        }
    }

    static void TinhTongDiem()
    {
        double tongDiem = 0;
        foreach (var sv in danhSachSinhVien)
        {
            tongDiem += sv.Diem;
        }
        Console.WriteLine($"Tổng điểm của tất cả sinh viên: {tongDiem}");
    }
}
