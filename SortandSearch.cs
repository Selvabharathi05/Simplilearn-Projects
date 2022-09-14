using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortandSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            do
            {
                Console.WriteLine("Menu \n Press 1 to Sort \n Press 2 to Search");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string file = @"D:\Student Details.txt";

                        var contents = File.ReadAllLines(file);

                        Console.WriteLine("Before Sort");
                        foreach (string line in contents)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("-------------------------------");
                        Array.Sort(contents);
                        Console.WriteLine("After Sort");
                        foreach (string line in contents)
                        {
                            Console.WriteLine(line);
                            
                        }
                        Console.WriteLine("-----------------------------");
                        break;

                    case 2:
                        string[] samefile = File.ReadAllText(@"D:\Student Details.txt").Split(' ');
                        bool value = false;
                        Console.WriteLine("Enter the Name to Search");
                        string n = Console.ReadLine();
                        Console.WriteLine("------------------------------");
                        for (int i = 0; i < samefile.Length; i++)
                        {
                            if (samefile[i].Contains(n) == true)
                            {
                                value = true;
                                break;
                            }
                            else
                            {
                                value = false;
                            }
                        }
                        if (value == true)
                        {
                            
                            Console.WriteLine("Entered Student Name is Present");
                        }
                        else
                        {
                            
                            Console.WriteLine("Entered Student Name is Not Present");
                        }
                        break;
                       


                    default:
                        Environment.Exit(1);
                        break;

                        

                }
                num++;
                

            } while (num<2);
            

            
            Console.ReadLine();
        }
    }
}
