using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LearningcSharpOOP
{
    internal class Variables
    {

        //in this class there is variables and methods
        public int num;
        public string YesOrNum;
        public int input;

        public void OddEven()
        {
            char Input_Odd_even;
            Console.WriteLine("Do u want to find odd or even no.press\"O\" for odd and \"E\" for even ");
            Console.WriteLine("--------------------------------");
            Input_Odd_even = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("Enter the No U want to try from which the odd will will specify. ");
            num = Convert.ToInt32(Console.ReadLine()); 
            switch (Input_Odd_even)
            {
                case 'O':
                    for (int i = 0; i < num; i++)
                    {
                        i = (i + 1) % num;
                        Console.WriteLine(i);

                    }
                    Console.WriteLine("Odd is now end.");
                    break;
                case 'E':
                    for (int i = 1; i <= num; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }

                    }
                    break;
                default:
                    Console.WriteLine("Please Enter the input");
                    break;
            }


        }
        public void PrimeOrNot()
        {


            bool is_Prime = true;

            Console.WriteLine("Enter The No You want to check");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    is_Prime = true;
                }
                else
                {
                    is_Prime = false;
                }
            }
            if (is_Prime) { Console.WriteLine("The No is Prime"); }
            else { Console.WriteLine("THe no is not prime"); }
        }

        public void Fibonacci()
        {
            Console.WriteLine("Enter the fibonnaci no");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
        }
        public void Armstrong()
        {
            Console.WriteLine("Enter the Armstrong no");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int temp = i;
                while (temp != 0)
                {
                    int digit = temp % 10;
                    sum += digit * digit * digit;
                    temp /= 10;
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }

        }
     
    }
}

