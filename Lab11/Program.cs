using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            Console.WriteLine(names[1]);
            Console.WriteLine(names[names.Length - 1]);

            //Question 2
            string[] months = new string[12] {"January", "Febuary", "March", "April"
                , "May", "June", "July", "August", "September", "October",
                "November", "December" };
            int count = 1;
            foreach (string s in months)
            {
                Console.WriteLine("{0} : {1}", s, count++);
            }

            // Question 3
            string[] seasons = new string[4] { "Winter", "Spring", "Summer", "Fall" };
            foreach (string s in seasons)
            {
                Console.WriteLine(s);
            }

            //Question 4
            int[] number = new int[1000];
            Random r = new Random();
            for (int x = 0; x < number.Length; x++)
            {
                number[x] = r.Next(0, 100);
            }
            foreach (int n in number)
            {
                Console.WriteLine(n);
            }

            //Question 5
            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine(names[i++]);
            }

            Console.ReadKey();
        }
    }
}
