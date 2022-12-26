using Main_Test.Polimorphism;
using Main_Test.Indexer__yield__iEnumerable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main_Test.Linq;

namespace Main_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // тренеровка з дженеріками + реф параметр (дозволяє змінювати значення поля по силці в па'мяті)
            //Generic_test<int, string, bool> p1 = new Generic_test<int, string, bool>(1, "Bob", true);
            //p1.Renumber(ref p1, 10);
            //Console.WriteLine(p1.id);

            //метод класу з функціями
            //recursion a = new recursion();
            //рандомний метод для рандому чисел
            Random rand = new Random();
            //простий масив
            //int[] mas = new int[10];
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = rand.Next(1, 100);
            //}

            //факторіал тест 
            //int x = 15;
            //int b = a.Factorial(x);
            //Console.WriteLine(b);

            //функція фібоначі тест
            //int x = 12;
            //int b = a.Fib(x);
            //Console.WriteLine(b);

            //тест вивода масиву через рекурсію
            //Random rand = new Random();
            //int[] mas = new int[10];
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = rand.Next(0, 100);
            //}
            //a.ArrayPrint(mas, 0);

            //тест суми масиву через рекурсію
            //int b = 0;
            //b = a.ArrayElementSum(mas, 0, 0);



            //Супер важна тестіровка сортування злиттям
            //var msort = new MargeSort();
            //var list = new List<int>();
            //for (int i = 0; i < 100; i++)
            //{
            //    list.Add(rand.Next(0, 100));
            //}
            //list = msort.Sort(list);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(list[item]);
            //}

            //Тест віртуальних методів
            //VirtualMetodUser vmu = new VirtualMetodUser();
            //vmu.Print(new VirtualMetods());
            //vmu.Print(new VirtualMetods2());



            //Indexer, yeild operator and IEnumerable interface
            //var students = new List<Student>()
            //{
            //    new Student(1, "Bob", "A", new int [5] { 3, 3, 4, 4, 5}),
            //    new Student(2, "Bib", "B", new int [5] { 2, 5, 5, 5, 2}),
            //    new Student(3, "Beb", "C", new int [5] { 3, 3, 3, 4, 5}),
            //    new Student(4, "Boob", "A", new int [5] { 5, 5, 5, 3, 5})
            //};
            //var register = new register();
            //foreach (var student in students)
            //{
            //    register.AddStudents(student);
            //}

            //Console.WriteLine("Enter name of new students:");
            //string newGroup = Console.ReadLine();

            //register[4] = new Student(4, "Boobs", newGroup, new int[5] { 2, 2, 2, 2, 2 });
            //Console.WriteLine(register[4].Group);





            //Linq
            var products = new List<Products>();
            for (int i = 0; i < 10; i++)
            {
                var Name = $"Product {i}";
                var Energy = rand.Next(10, 13);
                products.Add(new Products(Name, Energy));
            }
            var result = from item in products
                         where item.Energy > 10
                         select item;

            Console.WriteLine("Colection where product energy > 10:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var result2 = products.OrderBy(item => item.Energy).ThenBy(item => item.Name);

            Console.WriteLine("OrderBy collection:");
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var GroupByCollection = products.GroupBy(item => item.Energy);

            Console.WriteLine("GrouBy collection:");
            foreach (var group in GroupByCollection)
            {
                Console.WriteLine($"Key: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"\t {item}");
                }
            }
            Console.WriteLine();

            var EnergyCollection = products.Select(item => item.Energy);

            Console.WriteLine("Select only energy:");
            foreach (var item in EnergyCollection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var array1 = new int[] { 1, 2, 3, 4, 5 };
            var array2 = new int[] { 3, 4, 5, 6, 7 };

            var union = array1.Union(array2);

            Console.WriteLine("Union two collection:");
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var intersect = array1.Intersect(array2);

            Console.WriteLine("Intersect two array:");
            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var max = products.Where(p => p.Energy > 10).Max(p => p.Energy);
            Console.WriteLine(max);

            var min = products.Min(p => p.Energy);
            Console.WriteLine(min);

            var aggregate = array1.Aggregate((x, y) => x*y);
            Console.WriteLine(aggregate + "\n");

            var takeAndSkip = array1.Skip(2).Take(2);

            Console.WriteLine("Take and skip test:");
            foreach (var item in takeAndSkip)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var nullArray = new int[5];

            var firstOrDefault = nullArray.FirstOrDefault();
            Console.WriteLine("First or default test: " + firstOrDefault);

            var first = array1.First();
            Console.WriteLine("First test: " + first);

            var firstParam = array2.First(a => a > 3);
            Console.WriteLine("First with params (item > 3) test: " + firstParam);
        }
    }
}
