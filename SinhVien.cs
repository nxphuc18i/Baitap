using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien1
{
    class SinhVien
    {
        public String maSV;
        float toan;
        float ly;
        float hoa;
        //default constructors
        public SinhVien()
        {
            this.maSV = "01";
            this.toan = (float)7.5;
            this.ly = (float)8.5;
            this.hoa = (float)6.0;
        }
        public SinhVien(String masv, float toan, float ly, float hoa)
        {
            this.maSV = maSV;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
        }
        public void nhap()
        {
            Console.WriteLine("nhap maSV:");
            this.maSV = Console.ReadLine();
            Console.WriteLine("nhap diem toan:");
            this.toan = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem ly:");
            this.ly = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem hoa:");
            this.hoa = float.Parse(Console.ReadLine());
        }
        public float DTB()
        {
            return (float)(this.toan + this.ly + this.hoa) / 3;
        }
        public void IN()
        {
            Console.WriteLine("maSV {0} co DTB la {1}", this.maSV, this.DTB());
            Console.ReadLine();
        }
    }
}
