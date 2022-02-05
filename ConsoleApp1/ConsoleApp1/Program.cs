using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] resault = new int[N];
            int count = 1;
            bool flag;
            Console.WriteLine("--------------------------------------------");
            if (N < 2) {
                Console.WriteLine("Нет простых чисел, которые меньше N = " + N);
                return;
            }
            Console.WriteLine("Все простые числа, которые меньше N = " + N);
            Console.WriteLine("2");
            for (int i = 3;i <= N;i += 2){
                flag = true;
                for (int j = 3;j <= Math.Sqrt(i);j += 2)
                {
                    if (i % j == 0) {
                        flag = false;
                        break;
                    }
                }
                if (flag){
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine("Количество: " + count);
        }
    }
}
