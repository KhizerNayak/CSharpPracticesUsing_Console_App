using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace LearningcSharpOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Variables Var = new Variables();  //object for class Variable
            Loops lop   = new Loops();

        start:


            Console.WriteLine("Enter The Y for Yes ANd N For No");
            Var.YesOrNum = Console.ReadLine(); //for string
            Console.WriteLine("-----------------------------");
            Console.WriteLine("press 1 for odd & even, \n" +
                "press 2 for prime no, \n " +
                "press 3 for fibonacci series, \n" +
                "press 4 for armstrong no, \n" +
                "press 5 for For loops option");
            Console.WriteLine("-------------------------------------");
            try
            {
                Var.input = Convert.ToInt32(Console.ReadLine());
                if (Var.num > 0 || Var.num <= 5)
                {
                    switch (Var.input)
                    {
                        case 1:
                            Var.OddEven();
                            Console.WriteLine("------------------------------");
                            break;
                        case 2:
                            Var.PrimeOrNot();
                            break;
                        case 3:
                            Var.Fibonacci(); //parameter given in class method with num identifier
                            break;
                        case 4:
                            Var.Armstrong();
                            break;
                        case 5:
                            lop.Display(); //this is method used to call from loop 
                            break;
                        default:
                            Console.WriteLine("----------------------------------");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("The input u have given is not right Please put Correct input");
                }
            }
            catch(Exception e) 
            { 
                Console.WriteLine(e.Message); 
            }
           
               
            
           
          
           
            goto start;
            
            
                

        }
    }
}

