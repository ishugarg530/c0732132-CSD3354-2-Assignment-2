﻿using System;
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
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }


    }
}



public delegate void MyDelegate(ref int intValue);

public class DelegateExercises
{

    void Method1(ref int intValue)
    {

        intValue = intValue + 5;
        System.Console.WriteLine("Method1 " + intValue);
    }

    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        MyDelegate myDelegate1 = new MyDelegate(Method1);
        MyDelegate myDelegate2 = myDelegate + myDelegate1;
        int intParameter = 5;
        myDelegate2(ref intParameter);
    }
}








