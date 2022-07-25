using System;
using System.Collections.Generic;
using System.Text;

namespace OverRidingDemo
{
    class Matrix:Object
    {
        int a, b, c, d;
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;this.b = b;this.c = c;this.d = d;
        }
        public override string ToString()       //method overriding
        {
            return a + " " + b + "\n" + c + " " + d+"\n";
        }
        public static Matrix operator +(Matrix obj1, Matrix obj2)        //method overloading
        {
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }
        public static Matrix operator -(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }

    }
    class TestMatrix
    {
        static void Main()
        {
            Matrix m1 = new Matrix(20, 18, 16, 14);
            Matrix m2 = new Matrix(10, 8, 6, 4);
            Matrix m3 = m1 + m2;
            Matrix m4 = m1 - m2;

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.Write(m4);

            Console.ReadLine();

        }
    }
}
