using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace LearningcSharpOOP
{
    internal class Loops
    {

        Variables obj = new Variables();


        public void Display()
        {

            
            Console.WriteLine("Enter which type you want if u want to print * then press 1 and if you want to print no in hw format then print for \n hw:A \"2\" \n hw:B \"3\" \n hw:C \"4\"   \n hw:Pallindrome \"5\" ");

            Console.WriteLine("Enter the Loop function u want");
           

            Console.WriteLine("Enter the No");

            obj.num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------");

            if(obj.num > 0 || obj.num <=4) 
            {
                switch (obj.num)
                {
                    case 1:
                        No112(); //hw:a
                        break;
                    case 2:
                        No3321(); //hw:b
                        break;
                    case 3:
                        No123(); //hw:c
                        break;
                    case 4:
                        No124(); //hw:d
                        break;
                    case 5:
                        Pallin();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Enter the Correct digit");
            }

            
            

        }

        public void No112()
        //hw:A
        //1
        //12
        //123

        {
            Console.WriteLine("Enter the for loop no u want ");
            obj.num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= obj.num; i++) //the outer loop is column and inner loop is row
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public void No3321() //the first column no is always same
        {
            //hw:- B
            //3
            //32
            //321

            Console.WriteLine("Enter the for loop no u want ");
            obj.num = Convert.ToInt32(Console.ReadLine());
            int num = obj.num;
            for (int i = num; i > 0; i--)
            {
                for (int j = num; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public void No123()
        {
            //hw:C
            //1
            //22
            //33
            Console.WriteLine("Enter the for loop no u want ");
            obj.num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= obj.num; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");

            }
        }
        public void No124()
        {
            //hw:D
            //1
            //23
            //456
            Console.WriteLine("Enter the for loop no u want ");
            obj.num = Convert.ToInt32(Console.ReadLine()); 

            int rowCount = obj.num; // You can adjust the number of rows as needed

            int counter = 1;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{counter++}");
                }

                Console.WriteLine();
            }

        }
        private void Pallin()
        {
            string P = Console.ReadLine();
            int start = 0;
            int End = P.Length - 1;
            bool isPalindrome = true; // Assume palindrome initially

            while (start < End)
            {
                if (P[start] != P[End])
                {
                    isPalindrome = false;
                }
                start++;
                End--;

                
            }
            if (isPalindrome = true)
            {
                Console.WriteLine("This is Pallindrome");
            }
            else
            {
                Console.WriteLine("This is not pallindrome");
            }
        }
        
    }
}
