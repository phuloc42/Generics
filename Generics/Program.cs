using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        /*static void swap<T>(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }*/
       class Product<A>
        {
            A ID;
            public void SetId(A id)
            {
                this.ID = id;
            }
            public void Printinf()
            {
                Console.WriteLine($"ID = {this.ID}");
            }
        }
        static void Main(string[] args)
        {
            /*string a = "abc";
            string b = "xyz";

             Console.WriteLine($"a={a},b={b}");
             swap(ref a, ref b);
             Console.WriteLine($"a={a},b={b}");*/

            

            Product<int> sanpham1 = new Product<int>();
            sanpham1.SetId(123);
            sanpham1.Printinf();

            Product<string> sanpham2 = new Product<string>();
            sanpham2.SetId("abc");
            sanpham2.Printinf();
        }
    }
}
