using System;

namespace lab1ex11
{
    /*Folosind instructiunea “switch”, scrieti un program care citind de la tastatura un numar intreg va verifica urmatoarele
    “unu” daca numarul citit este 1
    “doi” daca numarul citit este 2
    “trei” daca numarul citit este 3
    “cinci” daca numarul citit este 5
    “opt” daca numarul citit este 8
    “neidentificat” pentru orice alt caz*/
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti numarul (1,2,3,5 sau 8):");
            var nr = int.Parse(Console.ReadLine());

            switch (nr)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 5:
                    Console.WriteLine("4");
                    break;
                case 8:
                    Console.WriteLine("8");
                    break;
                default:
                    Console.WriteLine("neidentificat");
                    break;

            }
        }
    }
}
