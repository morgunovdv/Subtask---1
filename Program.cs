using System;

namespace Subtask___1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк, которые хотите использовать");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[n]; 
            int i = 0;
            while (i < words.Length)
            {
                words[i] = Console.ReadLine();
                i++;
            }
            Console.WriteLine("Все строки введены, выберите строку для отображения");
            string word = Console.ReadLine();
            while (word != "X")
            {
                int index = Convert.ToInt32(word);
                if (index < words.Length)
                {
                    Console.WriteLine(words[index]);
                }

                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
            Console.WriteLine("Работа завершена");
            Console.ReadKey();
        }
    }
}
