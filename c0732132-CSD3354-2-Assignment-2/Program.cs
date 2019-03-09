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
    public class program
    {
        public static void Main()
        {
            {
                DelegateExercises delegateExercises = new DelegateExercises();
                delegateExercises.Method3();
                Console.ReadLine();
            }
        }
        public delegate int MyDelegate(out int i);
        public class DelegateExercises
        {
            int Method1(out int i)
            {

                i = 100;
                System.Console.WriteLine("Method1" + i);
                return 0;
            }
            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                MyDelegate myDelegate1 = null;
                MyDelegate myDelegate2 = myDelegate + myDelegate1;
                int intValue;
                myDelegate2(out intValue);
            }


        }
    }
}








