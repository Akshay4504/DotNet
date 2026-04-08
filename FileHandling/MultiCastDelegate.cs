using System;

namespace FileHandling

{

    // Delegate declaration

    public delegate void MyDelegate(string msg);
    public delegate int MyIntDelegate();

    public class ClassA1

    {

        public static void MethodA1(string message)

        {

            Console.WriteLine("Method A1: " + message);

        }
        public static int MethodC()
        {
            return 200;
        }

    }

    public class ClassB1

    {

        public static void MethodB1(string message)

        {

            Console.WriteLine("Method B1: " + message);

        }
        public static int MethodD()
        {
            return 300;
        }

    }

    public class MultiCastDelegate

    {

        public void AcceptAndPrint()

        {

            // Create delegate instances

            MyDelegate del1 = ClassA1.MethodA1;

            MyDelegate del2 = ClassB1.MethodB1;

            // Combine delegates

            MyDelegate del = del1 + del2;

            Console.WriteLine("Calling combined delegate:");

            del("Hello World");

            // Add lambda expression

            MyDelegate del3 = (string msg) =>

            {

                Console.WriteLine("Lambda: " + msg);

            };

            del += del3;

            Console.WriteLine("\nAfter adding lambda:");

            del("Hello World");

            // Remove MethodB1

            del -= del2;

            Console.WriteLine("\nAfter removing MethodB1:");

            del("Hello World");

            // Remove MethodA1

            del -= del1;

            Console.WriteLine("\nAfter removing MethodA1:");

            del("Hello World");

            MyIntDelegate mc = ClassA1.MethodC;
            MyIntDelegate md = ClassB1.MethodD;
            MyIntDelegate multiCastD = mc + md;
            Console.WriteLine(multiCastD());

        }

    }

}