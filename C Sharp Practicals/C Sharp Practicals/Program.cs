using System;

namespace C_Sharp_Practicals
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;          
           
            Console.WriteLine("Enter Value 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter Value 2");
            b =int.Parse( Console.ReadLine());




            Class1 cs1 = new Class1();   //This is a creating an object class 1
            c = cs1.GetSum(a,b);  //assigning  GetSum method on class 1 to c variable
            Console.WriteLine("Summation: " + c); //calling GetSum method on class 1
       
            Console.ReadKey();




        }
    }
}
