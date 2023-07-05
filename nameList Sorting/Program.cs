using System;
using System.Collections.Generic;

namespace nameList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();

            bool flag = true;
            var action = "yes";


            while (flag)
            {
                if (action.ToLower() == "yes")
                {
                    Console.WriteLine("What name do you want to add : ");
                    string anotherName = Console.ReadLine();
                    nameList.Add(anotherName);
                    Console.WriteLine("Do you want to continue (yes/no): ");
                    action = Console.ReadLine();
                    nameList.Sort();
                }
                else if (action.ToLower() == "no")
                {
                    Console.WriteLine("See you later.");
                    flag = false;

                }

            }

            foreach (string i in nameList)
            {
                Console.WriteLine(i);

            }
        }
    }
}