using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapBuoi5
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            Console.WriteLine(" Nhap vao n phan tu ma ban muon nhap: ");
            while (!uint.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine(" Hay nhap so lon hon 0 va so nguyen duong");
            }
            Console.WriteLine("So nguyen ban vua nhap la " + n);
            double[] arr = new double[n];
            Console.WriteLine("Cau 1: Doc va in cac phan tu trong mang vua nhap !");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" Hay nhap phan tu thu {0}:", i);
                arr[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" Phan tu thu {0} = {1}", i, arr[i]);
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Cau 2: In mang du lieu tren theo chieu dao nguoc !");
            Console.WriteLine("Mang dao chieu nhu sau:");
            foreach (var item in arr.Reverse())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Cau 3: Tim so phan tu giong nhau trong mang va hien thi so luong giong nhau ra man hinh !");
            Array.Sort(arr);// sap xep arr ve theo thu tu
            int count = 1;
            for (int i= 1; i< arr.Length; i++)
            {
                if(arr[i]==arr[i-1]) count++;

                else
                {
                    Console.WriteLine($"So {arr[i - 1]} xuat hien {count} lan.");
                    count = 1;
                }
            }
            Console.WriteLine($"So {arr[arr.Length - 1]} xuat hien {count} lan.");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Cau 4: In cac phan tu duy nhat trong bang !");
            count = 1;
            for (int i1 = 1; i1 < arr.Length; i1++)
            {
                if (arr[i1] == arr[i1 - 1]) count++;
                else
                {
                    if(count==1)
                    {
                    Console.Write(arr[i1 - 1] + "\t");
                    }
                    count = 1;
                }
            }
            if (count == 1) Console.WriteLine(arr[arr.Length - 1]);
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Cau 5: chia du lieu mang ban dau thanh mang chan va le");
            double[] ArrChan = new double[n];
            double[] ArrLe = new double[n];

            int CountChan = 0;
            int CountLe = 0;

            foreach (var num in arr)
            {
                if (num % 2 == 0)
                {
                    ArrChan[CountChan] = num;
                    CountChan++;
                }
                else
                {
                    ArrLe[CountLe] = num;
                    CountLe++;
                }
            }

            Console.WriteLine("Mang chan:");
            for (int i2 = 0; i2 < CountChan; i2++)
            {
                Console.Write(ArrChan[i2] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Mang le:");
            for (int i3 = 0; i3 < CountLe; i3++)
            {
                Console.Write(ArrLe[i3] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Cau 6: Sap xep mang theo thu tu giam dan");
            Array.Reverse(arr);// Reverse lai ham array da sort
                foreach (var item1 in arr)
                {
                    Console.WriteLine(item1);
                }

            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Cau 7: Tim phan tu lon thu 2 trong mang");
            // Da sort mang thanh chuoi co so tu thap den lon
            for (int i4 = 1; i4 < arr.Length; i4++)
            {
                if (arr[i4] < arr[i4 - 1])
                {
                    Console.WriteLine("So lon thu 2 trong mang la so: {0} ", arr[i4]);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
