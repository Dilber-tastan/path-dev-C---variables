using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte b = 5; // 1 byte
            //sbyte c = 5; // 1byte


            //short s = 5; // 2 byte
            //ushort us = 5; // 2 byte

            //Int16 i16 = 2;// 2 byte
            //int i = 2;  // 4 byte
            //Int32 i32 = 2; // 4 byte
            //Int64 i64 = 2; // 8 byte


            //uint u = 2; //4 byte
            //long l = 2; // 8 byte
            //ulong ul = 2; // 8 byte


            // float f = 2; // 4 byte
            //double d = 2; // 8 byte
            //decimal de = 2;// 16 byte

            //char ch = '2';// byte
            //String str = "dilber";// sınırsız


            //bool b1 = true;
            //bool b2 = false;

            //            DateTime dt1 = DateTime.Now;
            //            Console.WriteLine(dt1);// o anın tarihini tutar


            //            //object o1 = "x";// string
            //            //object o2 = 2;// int
            //            //object o3 = '2';// char
            //            //object o4 = 3.4;//double
            //            // tüm değişken tipleri birer objedir
            //            // obje kendinden türeyen bir üst türdür ve diğer verileri saklar

            //// string
            //            string str =string.Empty;// nul ile aynı işleve sahiptir
            //            str = "dilber taştan";
            //            string ad = "dilber";
            //            string soyad = "taştan";
            //            string tamad =ad+" "+soyad;

            ////int
            //            int i1 = 5;
            //            int i2 = 4;
            //            int i3 = i2 + i1;

            //            //boolean
            //            bool b1 = 10 < 2;
            // değişken dönüşümleri
            // string s1 = "20";
            // int integer = 23;
            //string yenideger = s1 + integer.ToString();// tip dönüşümü için tostring kullanıldı
            // //to string int stringe çevirmekte yardımcı olur
            // Console.WriteLine(yenideger);

            // int yenideger2=integer+Convert.ToInt32(s1);
            // //convert int çevirmede yardımcı olur
            // Console.WriteLine(yenideger2);

            // int yenideger3=integer+yenideger2+int.Parse(s1);

            // Console.WriteLine(yenideger3);

            //datatime
            string datetime = DateTime.Now.ToString("dd.mm.yy");
            Console.WriteLine(datetime);


            string datetime2 = DateTime.Now.ToString("dd/mm/yy");
            Console.WriteLine(datetime2);












            Console.ReadLine();

             
        }
        
    }
}
