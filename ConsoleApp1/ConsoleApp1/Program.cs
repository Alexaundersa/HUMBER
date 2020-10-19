using System;
namespace ConsoleApp1
{
    class Program
    {
       private static void Main()
        {
            Console.WriteLine("Please enter a sum of 2 numbers(ex:1+3)");
            bool IsValid = false;
            string a = null;
            while(IsValid!=true)
            {
                a = Console.ReadLine();
                IsValid=validateInput(a);// Validate input using method validateInput
                if (IsValid==false)
                {
                    Console.WriteLine("The input is invalid! Please type again ");
                }

                
            }

            Console.WriteLine("The result is:{0}",calculate(a));


          static bool validateInput(String a)
            {
                String[]b=a.Split('+');
                if (b.Length != 2 )
                {
                    return false;
                }


                if (int.TryParse(b[0], out int num1) == false)
                {
                    return false;
                }
                if (int.TryParse(b[0], out int num2) == false)
                {
                    return false;
                }

                return true;


            }

            static int calculate(String a)
            {
                String[] b = a.Split('+');
                int num1 = int.Parse(b[0]);
                int num2 = int.Parse(b[1]);
                return num1 + num2;
            }


        }

                
        }
    }

