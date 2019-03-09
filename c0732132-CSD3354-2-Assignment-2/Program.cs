using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0732132_CSD3354_2_Assignment_2
//Isha Garg c0732132
//Dheeraj Jain c0723560
//CSD3354 Section 3
//Assignment2
//March 6, 2019

{
    public class Program
    {
        
     static void Main(string[] args)

        {
            DelegateExcercises delegateExcercises = new DelegateExcercises();
            delegateExcercises.Method3();
            Console.ReadLine();
        }
    }
    public delegate void MyDelegate();

    public class DelegateExcercises
    {
        public delegate int MyDelegate(int intValue);

        int Method1(int intMethod1)
        {
            return intMethod1 * 4;
        }
        int Method2(int intMethod1)
     
        {
            return intMethod1 * 20;
        }
        public void Method4(MyDelegate myDelegate)
        {
            for (int i = 1; i <= 5; i++)
               
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            Method4(myDelegate);
            myDelegate = new MyDelegate(Method2);
            Method4(myDelegate);
          
        }

    }
}






