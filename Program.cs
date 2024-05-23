


using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;


class myclass
{
    //public int index;
    
    public int maxvaluefinder(out int max,out int index)
    {
        Console.WriteLine("\nenter the Array");
        int[] Arr = { 10, 20, 30 };
        max = 0;
        index = 0;
        for (int i = 0;i<Arr.Length;i++)
        {
            if (Arr[i] > max)
            {
                max = Arr[i];
                index = i;
            }
           
        }
        return max;
    }

    public int dividefun(int x, int y, out int rem,out int que)
    {
        rem = x % y;
         que = x / y;
        return que;

    }


    //Let ABC be a triangle such that the length of the 3 sides of the triangle is AB = c, BC = a and CA = b.

    // The semi-perimeter of triangle ABC = s = (a + b + c) / 2
    
    // Then, the area of triangle ABC = √[s × (s – a) × (s – b) × (s – c)].
    //sqrt()
    public double  triareacalculator(int s1, int s2,int s3,out double area,out double perarea) 
    {
        int s = s1 + s2 + s3/2;
        area=Math.Sqrt((s * (s - s1) * (s - s2) * (s - s3)));

        perarea = s1 + s2 + s3;
         return area;
        
                
    }
    
    public int calculatefactrorial(int num,out int fact)
    {
         fact = 1;

       for(int i = 1;i<=num;i++)
        {
            fact = fact * i;
        }
        return fact;
    }
    
}

internal class Program
{
    private static void Main(string[] args)
    {
       myclass obj= new myclass();

        //1

        // obj.maxvaluefinder(out int Max,out int index);
        // Console.WriteLine("maximum number is :"+Max+"on index is :"+index);

        //2

        //int a, b, rem, que;
        //Console.WriteLine("\nenter the numbers :");
        //a=Convert.ToInt32(Console.ReadLine());
        //b=Convert.ToInt32(Console.ReadLine());
        //obj.dividefun(a, b,out rem,out que);
        //Console.WriteLine("rem is :"+rem+ "que is :"+que);

        //3

        //int s1, s2, s3;
        //double area,peri;
        //Console.WriteLine("\nenter the sides of Trinagle");
        //s1 =Convert.ToInt32(Console.ReadLine());
        //s2=Convert.ToInt32(Console.ReadLine());
        //s3=Convert.ToInt32(Console.ReadLine());
        //obj.triareacalculator(s1,s2,s3,out area,out peri);
        //Console.WriteLine("Area of triangle is :"+area+"perimiter of triangle :"+peri);

        //4

        //int num, fact;
        //Console.WriteLine("\nenter the number :");
        //num= Convert.ToInt32(Console.ReadLine());
        //obj.calculatefactrorial(num,out fact);
        //Console.WriteLine("the factorial of {0} is {1} ", num, fact);


    }
}