using System;

namespace Main_Test
{
    class recursion
    {
        //факторіал
        public int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return n * Factorial(n - 1);
        }
        //числа фібоначі
        public int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if(n == 1)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }

        }
        //вивод масива рекурсією
        public void ArrayPrint(int []mas, int n)
        { 
            Console.WriteLine(mas[n]);
            n++;
            if (n <= mas.Length - 1) // -1 бо довжина масиву поченає рахунок з 1 і до 10, а n починає рахунок з 0 до 9
            {
                ArrayPrint(mas, n);
            }
        }
        //сума елементів масиву за допомогою рекурсії
        public int ArrayElementSum(int []mas, int n, int sum)
        {
            if (n >= mas.Length)
            {
                return sum;
            }
            else
            {
                sum += mas[n];
                return ArrayElementSum(mas, n + 1, sum);
            }
        }
    }
}
