using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien1
{
    class Program
    {
            static void Main(string[] args)
            {
                int n;
                Console.WriteLine("Nhap maSV:");
                n = Int32.Parse(Console.ReadLine());
                SinhVien[] sv = new SinhVien[n];
                for (int i = 0; i < n; i++)
                {
                    sv[i] = new SinhVien();
                    sv[i].nhap();
                    sv[i].IN();
                }
                float min = sv[0].DTB();
                for (int i = 1; i < n; i++)
                {
                    if (sv[i].DTB() < min)
                        min = sv[i].DTB();
                }
                Console.WriteLine("sv co diem thap nhat la{0}", min);

                for (int j = 0; j < n; j++)
                {
                    for (int a = j + 1; a < n; a++)
                    {
                        if (sv[a].DTB() < sv[j].DTB())
                        {
                            SinhVien s = new SinhVien();
                            s = sv[j];
                            sv[j] = sv[a];
                            sv[a] = s;
                        }
                    }
                }
                Console.WriteLine("  sinh vien sau khi xap sep tang dan la:");
                for (int j = 0; j < n; j++)
                    Console.WriteLine("sinh vien ma {0} co diem TB la : {1}", sv[j].maSV, sv[j].DTB());

                for (int i = 0; i < n; i++)
                {
                    if (sv[i].maSV.Contains("IT"))
                        Console.WriteLine("sinh vien ma {0} co diem TB la:{1}", sv[i].maSV, sv[i].DTB());

                }
                Console.ReadLine();
            }
        }
    }


