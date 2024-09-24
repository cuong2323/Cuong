using System;
class SinhVien
{
    public string HoTen { get; set; }
    public string MSSV { get; set; }
    public double DiemTrungBinh { get; set; }
    public void NhapThongTin()
    {
        Console.Write("Nhap ho va ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap ma so sinh vien: ");
        MSSV = Console.ReadLine();
        Console.Write("Nhap diem trung binh: ");
        DiemTrungBinh = double.Parse(Console.ReadLine());
    }
  
    public void HienThi()
    {
        Console.WriteLine("Ho ten: " + HoTen);
        Console.WriteLine("Ma sinh vien: " + MSSV);
        Console.WriteLine("Diem trung binh: " + DiemTrungBinh);
    }
}
class DSSV
{
    private SinhVien[] danhSachSV;
    private int soLuongSV;

    public void NhapDanhSachSinhVien()
    {
        Console.Write("Nhap so luong sinh vien: ");
        soLuongSV = int.Parse(Console.ReadLine());
        danhSachSV = new SinhVien[soLuongSV];

        for (int i = 0; i < soLuongSV; i++)
        {
            Console.WriteLine($"Nhap thong tin sinh vien thu {i + 1}:");
            danhSachSV[i] = new SinhVien();
            danhSachSV[i].NhapThongTin();
        }
    }
    public void HienThiDanhSachSinhVien()
    {
        Console.Write("\nDanh sach sinh vien:");
        for (int i = 0; i < soLuongSV; i++)
        {
            Console.WriteLine($"\nThong tin sinh vien thu {i + 1}:");
            danhSachSV[i].HienThi();
        }
    }
    public void TimKiemSinhVienTheoMSSV(string mssv)
    {
        int dem = 0;
        for (int i = 0; i < soLuongSV; i++)
        {
            if (danhSachSV[i].MSSV == mssv)
            {
                Console.WriteLine("\nSinh vien duoc tim thay:");
                danhSachSV[i].HienThi();
                dem++;
            }
        }
        if (dem==0)
        {
            Console.WriteLine("Khong tim thay sinh vien voi MSSV: " + mssv);
        }
    }
    public void DiemTrungBinhCaoNhat()
    {
        SinhVien maxtb = danhSachSV[0];
        for (int i = 0; i < soLuongSV; i++)
        {
            if (danhSachSV[i].DiemTrungBinh > maxtb.DiemTrungBinh)
            {
                maxtb = danhSachSV[i];
            }
        }
        Console.WriteLine("Sinh vien co diem trung binh cao nhat: ");
        maxtb.HienThi();
    }

}
class Program
{
    public static void Main(String[] args)
    {
        DSSV ds  = new DSSV();
        ds.NhapDanhSachSinhVien();
        ds.HienThiDanhSachSinhVien();
        Console.Write("Nhap MSSV cua sinh vien can tim: ");
        string mssv = Console.ReadLine();
        ds.TimKiemSinhVienTheoMSSV(mssv);
        ds.DiemTrungBinhCaoNhat();
        Console.ReadKey();
    }
}
    