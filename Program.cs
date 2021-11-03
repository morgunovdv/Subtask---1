using System;

namespace Subtask___1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[n];
            Console.WriteLine("Введите слово");
            string word = null;
            int i = 0;
            while ((word != "X") || (word != "x"))
            {
               if (i < words.Length)
                {
                    words[i] = Console.ReadLine();
                }

                i++;
            }

            Console.WriteLine(words);

            Console.ReadKey();
        }
    }
}
