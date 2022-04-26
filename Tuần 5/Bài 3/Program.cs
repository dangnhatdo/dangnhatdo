using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    internal class Program
    {
        static int n, k;
        static int[] ToHop;
        static bool[] Check;
        static void Print()
        {
            for (int j = 1; j <= k; j++)
                Console.Write(ToHop[j] + " ");
            Console.WriteLine();
        }      
        static void Try(int i)
        {
            for (int j = ToHop[i - 1] + 1; j <= n -k+i; j++) //Tổ Hợp Thì số sau luôn lớn hơn số trước
                //vi dụ: 124? thì số ? phải là từ 5->n-k+i với n nhập vào là 6
            {
                ToHop[i] = j;
                if (i == k)
                {
                    Print();
                }
                else
                {
                    Try(i + 1);
                }
            }
        }
        static int GiaiThua(int n)
        {
            int GiaiThua = 1;
            for (int i = 2; i <= n; i++)
            {
                GiaiThua *= i;
            }
            return GiaiThua;
        }
        static int TinhToHop(int n, int k)
        {
            return GiaiThua(n) / (GiaiThua(k) * GiaiThua(n - k));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n, k: ");
            string[] token = Console.ReadLine().Split();
            n = int.Parse(token[0]);
            k = int.Parse(token[1]);     
            ToHop = new int[n + 1];
            Console.WriteLine(TinhToHop(n, k));
            Try(1);
            Console.ReadKey();
        }
    }
}
