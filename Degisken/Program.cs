
using System;

namespace degisken{
class Program{
    static void Main(string[] args){
       

        byte b = 5; // 1byte
        sbyte c = 5; //1byte

        short s = 5; //2byte
        ushort us = 5; //2byte

        Int16 i16 = 5; //2byte
        int i = 5; //4byte
        Int32 i32 = 5; //4byte
        Int64 i64 = 5; //8byte

        uint ui = 2; //4byte
        long l= 5; //8byte
        ulong ul= 5; //8byte

        float f= 5; //4byte
        double d=5; //8byte
        decimal dc = 5; //16btye

        char ch = '2'; //2byte
        string str = "Goktug"; //sınırsız

        bool b1 = true; 
        bool b2 = false;

        DateTime dt = DateTime.Now;
        //Console.WriteLine(dt);


        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.3;

        //string ifadeler

        string str1 = string.Empty;
        str1= "Goktug Gumus";
        string ad = "Goktug";
        string soyad = "Gumus";
        string tamAd = ad + " " + soyad;
        Console.WriteLine(tamAd);

        //integer tanımlama şekilleri

        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        //boolean

        bool bool1 = 10>2;

        //Değişken Dönüşümleri

        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString();
        Console.WriteLine(yeniDeger); //çıktısı 2020

        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21); //çıktısı 40

        int int22 = int20 + int.Parse(str20);
        Console.WriteLine(int22); //çıktısı 40

        //dateTime

        string dateTime = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(dateTime); 

        string hour =DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);


    }
}

}

