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
            while ((word != "stop"))
            {
                int i = 0;
                if (i < words.Length)
                {
                    words[i] = word;
                }
                i++;
                word = Console.ReadLine();
            }

            Console.WriteLine(words);

            Console.ReadKey();
        }
    }
}
