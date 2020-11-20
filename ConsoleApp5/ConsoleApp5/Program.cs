using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {   
            Adult adult = new Adult("Alex", "Samuel");
            Child child = new Child("Amalia", "Samuel");
            string[] adultChild =
                { adult.FirstName,adult.LastName,child.FirstName,child.LastName};
            for (int i = 0; i < adultChild.Length; i++)
            {
                Console.WriteLine(adultChild[i]);
            }

        }
    }
}



public class Adult
{ public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public Adult(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

    }
}


public class Child
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Child(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

    }
}