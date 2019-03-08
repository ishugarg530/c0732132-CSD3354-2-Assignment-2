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
        public class DelegateExercises
        {
            
            public delegate void MyDelegate();
            void Methodl()
            {
                
                Console.WriteLine("Method1");
                Console.ReadLine();
            }

            public void Method2()
            {
                MyDelegate myDelegate = new MyDelegate(Methodl);
                myDelegate();
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method2();
        }
    }
}