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
            if ((word != "X") || (word != "x"))
            {
                for (int i=0; i<words.Length; i++)
                {
                    
                    words[i] = word;
                }
                word = Console.ReadLine();
                return;
            }

            else
            {
                Console.WriteLine("Конец программы");
            }

            Console.WriteLine(words);

            Console.ReadKey();
        }
    }
}
