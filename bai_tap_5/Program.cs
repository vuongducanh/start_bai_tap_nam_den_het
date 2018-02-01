using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
namespace bai_tap_5
{
    class Program
    {
        static void bai5_1()
        {
            try
            {
                List<int> numbersInput = new List<int>();
                Console.Write("nhap do dai cu chuoi xua ban n = ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("nhap moi so nguyen input = ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    numbersInput.Add(input);
                }
                var num = from s in numbersInput where s%2==0 select s;
                System.Console.WriteLine("mang cac so chan la");
                foreach (var item in num)
                {
                    System.Console.Write(item+" ");
                }
            }
            catch (System.FormatException)
            {

                System.Console.WriteLine("ban nhap vao phai la so");
            }
        }
        static void bai5_2()
        {
            string num = "Student";
            
            char[] array = num.ToCharArray();
            Console.Write("nhap ki tu day tien input = ");
            char input = Convert.ToChar(Console.ReadLine());
            System.Console.Write("nhap ki tu cuoi cung input2 = ");
            char input2 = Convert.ToChar(Console.ReadLine());
            int n = array.Length;
            while(input!= array[0])
            {
             Console.Write("nhap ki tu day tien input = ");
             input = Convert.ToChar(Console.ReadLine());
             System.Console.Write("nhap ki tu cuoi cung input2 = ");
              input2 = Convert.ToChar(Console.ReadLine());
            }
            for (int i = 0; i <n; i++)
            {
                if(input == array[0] && input2 == array[n-1])
                {
                    System.Console.Write(array[i]);
                }
            }
        
        }
        static void bai5_3()
        {
            try
            {
                List<int> value = new List<int>();
                Console.Write("nhap do dai cua chuoi xua ban n = ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("nhap moi so nguyen input = ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    value.Add(input);
                }
                value.Sort();
                value.Reverse();
                for (int i = 0; i < value.Count; i++)
                {
                    for (int j = i+1; j < value.Count; j++)
                    {
                        if(value[i] == value[j])
                        value.Remove(value[j]); 
                    }
                    System.Console.Write(value[i]+" ");
                }
                
                // System.Console.Write("nhap phan tu ban muon tim lon thu n = ");
                // int nhap = Convert.ToInt32(Console.ReadLine());
                // int num = 0;
                // for (int i =1; i < value.Count; i++)
                // {
                //     num = value[nhap];
                // }
                // System.Console.WriteLine(num);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                System.Console.WriteLine("so ban nhap qua lon");
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("ban nhap vao phai la so");
            }
        }
        static void bai5_4()
        {
            try
            {
                List<string> sort = new List<string>();
                Console.Write("nhap vao so luong ki tu n = ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("phan tu thu {0} = ", i);
                    string input = Convert.ToString(Console.ReadLine());
                    sort.Add(input);
                }
                for (int i = 0; i < sort.Count; i++)
                {
                    for (int j = i + 1; j < sort.Count; j++)
                    {
                        if (sort[i] == sort[j])
                        {
                            sort.Remove(sort[j]);
                        }
                    }
                }
                var orderByResult = from s in sort
                orderby s 
                select s;
                Console.WriteLine("so phan tu sau khi sap xep la");
                foreach (var std in orderByResult)
                Console.WriteLine(std);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void bai5_5()
        {
            FileInfo file = new FileInfo("test");
            long FileLength = file.Length;
            Console.WriteLine(FileLength);
        }
        static void Main(string[] args)
        {
            // bai5_1();
            // bai5_2();
            bai5_3();
            // bai5_4();
            // bai5_5();
            // bai 6 lam o phan khac.
        }
    }
}
