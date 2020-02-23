using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Double x1, x2, y1, y2, p, s, x3, y3, side1, side2, side3;
            Console.WriteLine("nhap tung do cua diem 1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap hoanh do cua diem 1 ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap tung do cua diem 2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap hoanh do cua diem 2");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap tung do cua diem 3");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap hoanh do cua diem 3");
            y3 = Convert.ToDouble(Console.ReadLine());
            side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            p = (side1 + side2 + side3) / 2;
            Console.WriteLine(" chu vi tam gia nay la {0}", p);
            Console.ReadKey();
        }



        #region BAI_TAP

        /* BÀI 27
        string str;
        int dem = 0;

        Console.WriteLine("Nhap chuoi: ");
        str = Console.ReadLine();

        Console.WriteLine("So luong ky tu (bao gom khoang trang): " + str.Length);

        for (int i = 0; i < str.Length; i++)
        {
            if(str[i] != ' ')
            {
                dem++;
            }
        }

        Console.WriteLine("So luong ky tu (khong co khoang trang): " + dem);
        */
        /*
        // Viết chương trình nhập vào các số nguyên cho đến khi người dùng nhập vào số 0, 
        // chương trình xuất ra giá trị nguyên âm chẵn lớn nhất trong các số vừa nhập đó
        int a, max = 0;

        do
        {
            Console.WriteLine("Nhap so nguyen: ");
            a = int.Parse(Console.ReadLine());

            if (a < 0 && a % 2 == 0 && max == 0)
            {
                max = a;
            }

            if (a % 2 == 0 && a < 0 && max < a)
            {
                max = a;
            }

        } while (a != 0);

        if (max == 0)
        {
            Console.WriteLine("khong ton tai nguyen am chan lon nhat");
        }
        else
        {
            Console.WriteLine("So nguyen am lon nhat: " + max);
        }
        
         */
        /* BÀI 21
        int soBai, heSo, tongHeSo = 0;
        float soDiem, tongDiem = 0;

        // Nhập số lượng bài kiểm tra
        Console.Write("Nhap so luong bai: ");
        soBai = int.Parse(Console.ReadLine());

        // Nhập điểm & hệ số
        for(int i = 0; i < soBai; i++)
        {
            // Nhập số điểm bài kiểm tra
            Console.Write("Diem bai kiem tra: ");
            soDiem = float.Parse(Console.ReadLine());

            // Nhập hệ số bài kiểm tra
            Console.Write("He so: ");
            heSo = int.Parse(Console.ReadLine());

            tongDiem += soDiem * heSo;
            tongHeSo += heSo;
        }

        Console.WriteLine("Diem trung binh: " + tongDiem/tongHeSo);
        */

        /* BÀI 20
        // Viết chương trình yêu cầu người dùng nhập vào một số nguyên dương N (N > 0). In ra màn hình bảng cửu chương của N
        int N;

        // Kiểm tra N dương
        do
        {
            Console.Write("Nhap N (nguyen duong): ");
            N = int.Parse(Console.ReadLine());
        } while (N <= 0);

        // In bảng cửu chương
        int i = 1;

        for( ; ; )
        {
            if (i > 10)
            {
                break;
            }

            Console.WriteLine(string.Format("{0} x {1} = {2}", N, i, N * i));
            i++;
        }
        */
        /* BÀI 19
        // Viết chương trình nhập vào một số nguyên dương N 
        // (kiểm tra nhập đến khi là số nguyên dương), tính tổng các chữ số của N.
        // 54903 -> 21

        int N, tong = 0;

        do
        {
            Console.Write("Nhap N (nguyen duong): ");
            N = int.Parse(Console.ReadLine());
        } while (N <= 0);

        while(N > 0)
        {
            // Cộng giá trị ký số hàng đơn vị
            tong = tong + N % 10;
            // Thay đổi giá trị N
            N = N / 10;
        }

        Console.WriteLine("Tong cac chu so: " + tong);
         */

        /* BÀI 13
        // Giải phương trình ax + b = 0
        float a, b;

        Console.Write("Nhap a: ");
        a = float.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        b = float.Parse(Console.ReadLine());

        // a != 0 -> x = -b/a
        if (a != 0)
        {
            Console.WriteLine("PT co 1 nghiem: " + -b/a);
        }
        // a = 0 && b != 0 -> PT VN
        if (a == 0 && b != 0)
        {
            Console.WriteLine("PT VN");
        }
        // a = 0 && b = 0 -> PT VSN
        if (a == 0 && b == 0)
        {
            Console.WriteLine("PT VSN");
        }
        */

        /* BÀI 12
        int nam;

        Console.Write("Nhap gia tri nam: ");
        nam = int.Parse(Console.ReadLine());

        if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
        {
            Console.WriteLine("Day la nam nhuan.");
        }
        else
        {
            Console.WriteLine("Day khong la nam nhuan.");
        }
        */

        /* BÀI 10
        float a, b, c, d, max;

        Console.Write("Nhap so thu 1: ");
        a = float.Parse(Console.ReadLine());

        Console.Write("Nhap so thu 2: ");
        b = float.Parse(Console.ReadLine());

        Console.Write("Nhap so thu 3: ");
        c = float.Parse(Console.ReadLine());

        Console.Write("Nhap so thu 4: ");
        d = float.Parse(Console.ReadLine());

        max = a;

        if (b > max)
        {
            max = b;
        }

        if (c > max)
        {
            max = c;
        }

        if (d > max)
        {
            max = d;
        }

        // Cách 1 dùng if
        Console.WriteLine("So lon nhat: " + max);
        // Cách 2 dùng hàm Math.Max cho hai số
        Console.WriteLine("So lon nhat: " + Math.Max(Math.Max(Math.Max(a, b), c), d));
        */

        /* BÀI 09
        double x1, y1, x2, y2, x3, y3, s, p, side1, side2, side3;

        Console.Write("Nhap x1: ");
        x1 = float.Parse(Console.ReadLine());

        Console.Write("Nhap y1: ");
        y1 = float.Parse(Console.ReadLine());

        Console.Write("Nhap x2: ");
        x2 = float.Parse(Console.ReadLine());

        Console.Write("Nhap y2: ");
        y2 = float.Parse(Console.ReadLine());

        Console.Write("Nhap x3: ");
        x3 = float.Parse(Console.ReadLine());

        Console.Write("Nhap y3: ");
        y3 = float.Parse(Console.ReadLine());

        // Tính độ dài các cạnh tam giác
        side1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); // 12
        side2 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)); // 13
        side3 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)); // 23

        p = (side1 + side2 + side3) / 2;
        s = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));

        Console.WriteLine("Dien tich tam giac: " + s);

        */

        /* BÀI 08
        int soTien, tienDu, tien10, tien5, tien2;

        Console.Write("Nhap so tien can doi: ");
        soTien = Convert.ToInt32(Console.ReadLine());

        tien10 = soTien / 10;
        tienDu = soTien % 10;

        tien5 = tienDu / 5;
        tienDu = tienDu % 5;

        tien2 = tienDu / 2;
        tienDu = tienDu % 2;

        string ketQua = string.Format("Quy doi: {0} to 10d, {1} to 5d, {2} to 2d, {3} to 1d", tien10, tien5, tien2, tienDu);

        Console.WriteLine(ketQua);
        */

        /* BÀI 06
        int a, ketQua;

        Console.Write("Nhap gia tri so nguyen co 3 chu so: ");
        a = Convert.ToInt32(Console.ReadLine());

        // 437
        // 4 = 437 / 100
        // 3 = 437 % 100 / 10 
        // 7 = 437 % 10
        ketQua = a / 100 + a % 100 / 10 + a % 10;

        Console.WriteLine("Tong cac chu so: " + ketQua);  
        */

        /* BÀI 05
       
        int a, b, tam;

        // Nhập dữ liệu
        Console.Write("Nhap gia tri a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap gia tri b: ");
        b = Convert.ToInt32(Console.ReadLine());

        // Hoán vị hai số a, b
        tam = a;
        a = b;
        b = tam;

        Console.WriteLine("Hoan vi: " + a + ", " + b);

        */

        /* BÀI 04

        // Khai báo biến
        double x1, x2, y1, y2, ketQua;

        // Nhập dữ liệu
        Console.WriteLine("Nhap x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhap y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhap x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhap y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        ketQua = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

        // Xuất kết quả
        Console.WriteLine("Khoang cach giua hai diem: " + ketQua);

        */

        #endregion
    }
}
