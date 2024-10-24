/////////////////////////////////
//      README.md first!       //
//                             //
//      Лаба по АСВТ №2        //
//          Потоки             //
//     Горбачев Матвей 4305    //
/////////////////////////////////
using System;
using System.Threading;

class proga_asvt
{
    static long Factorial(int n)
    {
        long result = 1;
        if(n==0) return result;
        for(int i = 1; i<n; i++)
        {
            result *= i;
        }
        return result;
    }

    static void CalculatingFactorial(object number)
    {
        int num = (int)number;
        long result = Factorial(num);
        Console.WriteLine($"Факториал {num} = {result}");
    }

    static void Main(string[] args)
    {
        int[] numbers = {2, 4, 6, 20, 50};
        Thread[] threads = new Thread[numbers.Length];

        for(int i = 0; i < numbers.Length; i++)
        {
            threads[i] = new Thread(CalculatingFactorial);
            threads[i].Start(numbers[i]);
        }

        for(int i = 0; i < threads.Length; i++)
        {
            threads[i].Join();
        }
        Console.WriteLine("Работа программы завершена ставьте 5 за семестр(пожалуйста)");
    }

}