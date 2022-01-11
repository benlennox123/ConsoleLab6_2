using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab6_1
{
    class Lab6_2
    {
        static void Main(string[] args)
        {
            string Predlozenie = Console.ReadLine();
            string slovo1 = Predlozenie.ToLower();
            string[] Massiv1 = slovo1.Split();
            string slovo2 = "";
            string slovo3 = "";
            foreach (string s in Massiv1)
            {
                slovo2 += s;
            }
            StringBuilder Massiv2 = new StringBuilder(slovo2);
            int L = slovo2.Length;
            for (int i = L-1; i >=0; i--)
            {
                slovo3 += Massiv2[i].ToString();
            }
            Console.WriteLine(slovo1);
            Console.WriteLine();
            Console.WriteLine(slovo2);
            Console.WriteLine();
            Console.WriteLine(slovo3);
            Console.WriteLine();
            if (slovo2 == slovo3)
            {
                Console.WriteLine("Данная строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Данная строка НЕ является палиндромом");
            }
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
