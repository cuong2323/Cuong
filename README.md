# Cuong
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Baitap bt = new Baitap();
            bt.Bai1_Nhapmang_tinhtong();
            bt.Bai2_Diemkituchuoi();
            bt.Bai3_TimPhanTuLonNhat();
            bt.Bai4_DaoNguocChuoi();
            bt.Bai5_KiemTraMangDoiXung();
            bt.Bai6_DemSoLanXuatHienKyTu();
        }
    }
}
using System;
using System.Runtime.ConstrainedExecution;
using System.Text.Json.Serialization.Metadata;
namespace ConsoleApp1
{
    class Baitap
    {
        public Baitap()
        {
            Console.WriteLine("Tao ra mot bai tap");
        }
        public void Bai1_Nhapmang_tinhtong()
        {
            int n;
            Console.WriteLine("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu: " + (i + 1));
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mang da nhap: \n");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(" " + a[i]);
            }
            int count = 0;
            for(int i = 0; i < n; i++){
                count += a[i];
            }
            Console.WriteLine("Tong cac phan tu trong mang: " + count);
        }
        public void Bai2_Diemkituchuoi()
        {
            Console.Write("Nhap mot chuoi : ");
            string input = Console.ReadLine();

            int charCount = input.Count(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c));

            Console.WriteLine($"So luong phan tu cua chuoi(khong tinh khoang trang va dau cau) là: {charCount}");
        }
        public void Bai3_TimPhanTuLonNhat()
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array.Max();
            Console.WriteLine($"Phan tu lon nhat : {max}");
        }
        public void Bai4_DaoNguocChuoi()
        {
            Console.Write("Nhap mot chuoi : ");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            string reversedString = new string(charArray);

            Console.WriteLine($"Chuoi dao nguoc : {reversedString}");
        }

        // Bài 5: Kiểm tra mảng đối xứng (Palindrome)
        public void Bai5_KiemTraMangDoiXung()
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            bool isPalindrome = true;
            for (int i = 0; i < n / 2; i++)
            {
                if (array[i] != array[n - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
                Console.WriteLine("Mang la mang doi xung.");
            else
                Console.WriteLine("Mang khong phai mang doi xung.");
        }
        // Bài 6: Đếm số lần xuất hiện của một ký tự trong chuỗi
        public void Bai6_DemSoLanXuatHienKyTu()
        {
            Console.Write("Nhap moi chuoi: ");
            string input = Console.ReadLine();

            Console.Write("Nhap mot chuoi ki : ");
            char character = char.Parse(Console.ReadLine());

            int count = input.Count(c => c == character);

            Console.WriteLine($"So lan xuat hien cua ki tu '{character}' trong chuoi la: {count}");
        }
    }
}