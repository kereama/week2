﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello, please enter your name: ");
            //string input = Console.ReadLine();
            //Console.WriteLine("Hello, {0}", input);

            //Console.WriteLine("what is your age: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Do you have a Raho or a Teme?: ");
            //string input2 = Console.ReadLine();

            //Console.WriteLine("kei hea to Kainga?: ");
            //string input3 = Console.ReadLine();

            //Console.WriteLine("the information gathered: ");
            //Console.WriteLine("Name: {0}", input);
            //Console.WriteLine("Number: {0}", number);
            //Console.WriteLine("Gender: {0}", input2);
            //Console.WriteLine("Kainga: {0}", input3);

            //task2ask the user for two numbers
            //Console.WriteLine("Please enter a number: ");
            //int Num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter another number: ");
            //int Num2 = int.Parse(Console.ReadLine());
            ////add two numbers together
            //Console.WriteLine("{0} + {1} = {2}", Num1, Num2, (Num1 + Num2));

            //// subtraction
            //Console.WriteLine("{0} - {1} = {2}", Num1, Num2, (Num1 - Num2));

            ////multiply 
            //Console.WriteLine("{0} * {1} = {2}", Num1, Num2, (Num1 * Num2));

            ////devide 
            //Console.WriteLine("{0} / {1} = {2}", Num1, Num2, (Num1 / Num2));

            //Console.WriteLine("Task two complete - please press enter to complete");
            //Console.ReadLine();

            // task three. ask for users first and last name then display them together
            //Console.WriteLine("task3 He aha to ingoa tuatahi: ");
            //string fname = Console.ReadLine();
            //Console.WriteLine("he aha to ingoa whanau: ");
            //string lname = Console.ReadLine();
            //// Display the full name together 
            //Console.WriteLine("Tena koe {0} {1}", fname, lname);

            //Console.WriteLine("Please enter a number");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter another number");
            //int num2 = int.Parse(Console.ReadLine());

            //if (num1 > num2)
            //{
            //    Console.WriteLine("{0} is larger", num1);//1
            //    Console.WriteLine($"{num1} is bigger");//2
            //    Console.WriteLine(num1 + " is bigger");//3
            //}
            //else
            //    Console.WriteLine($"{num2} is bigger");


            //int Mynum, UserNum; //this declares your variables. comma aftter each vaiable to add 
            //Console.WriteLine("enter my numer: ");
            //Mynum = int.Parse(Console.ReadLine());
            //Console.WriteLine("guess my number: ");
            //UserNum = int.Parse(Console.ReadLine());

            //if (Mynum > UserNum)
            //{
            //    Console.WriteLine($"{Mynum} is bigger");
            //    Console.ReadLine();
            //}

            //else if (Mynum == UserNum)
            //{
            //    Console.WriteLine("cracked it");
            //    Console.ReadLine();
            //}

            //else if (Mynum < UserNum)
            //{
            //    Console.WriteLine("{0}less than", Mynum);
            //    Console.ReadLine();
            //}

            //int Grade;
            //Console.WriteLine("Enter your grade");

            //Grade = int.Parse(Console.ReadLine());

            //if (Grade >= 90 && Grade <=100)
            //    Console.WriteLine("A+");

            //else if (Grade >= 80 && Grade <=89)
            //    Console.WriteLine("A");

            //else if (Grade >= 70 && Grade <=79)
            //    Console.WriteLine("B+");

            //else if (Grade >= 60 && Grade <=69)
            //    Console.WriteLine("B");

            //else if (Grade >= 50 && Grade <=59)
            //    Console.WriteLine("C");

            //else if (Grade <= 50 && Grade <=49
            //    )
            //    Console.WriteLine("F");

            /*---Question 3---*/
            //this was my att
            //    Console.WriteLine("Enter a number");
            //    Number = int.Parse(Console.ReadLine());
            //    if (Number %2 == 0)
            //    {
            //        Console.Write("Entered Number is an Even Number: ");
            //        Console.Read();
            //    }
            //    //else
            //    //{
            //    //    Console.Write("Entered Number is an Odd Number");
            //    //    Console.Read();
            //    //}
            //}

            //Question6();











            //    Console.WriteLine("Kua mutu, Nga mihi");
            //Console.ReadLine(); 







            //    Console.ReadLine();

            //}

            //public static void Question6()
            //{
            //    Console.Write("Enter a Number : ");
            //    int num = int.Parse(Console.ReadLine());
            //    if (num % 2 == 0)
            //    {
            //        Console.Write("Entered Number is an Even Number");
            //        Console.Read();
            //    }
            //    else
            //    {
            //        Console.Write("Entered Number is an Odd Number");
            //        Console.Read();
            //    }
            //}
            //public static int Question5()
            //{
            //    int temp = 0;
            //    return temp;
            //}

            Console.WriteLine("He aha taku kararehe tino pai rawa atu?");
            Console.ReadLine();

             void Main()
            {
                string value = "Kurii";
            
                switch (value)
                {
                    case "Kurii":
                        Console.WriteLine("Ae, Kei te tika koe!");
                        break;
                    case "Ngeru":

                    case "Raiona":

                    case "ika":
                        Console.WriteLine("Kao");
                        break;

                    default:
                        Console.WriteLine("Default kao");
                }
                Console.ReadLine();

            }
