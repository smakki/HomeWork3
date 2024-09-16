using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////
            /// Начал 16 сентября 2024г.,11:34:14
            ///////////////////////
            int indexForSearch = 496753;
            Console.WriteLine("Запись 1000000 записей с помощью рандом в различные коллекции");
            Console.WriteLine();
            Random random = new Random();
            Stopwatch sw = new Stopwatch();


            List<int> list = new List<int>();

            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                list.Add(random.Next());
            }
            sw.Stop();
            Console.WriteLine("List: {0} миллисекунд", sw.ElapsedMilliseconds);
            Console.WriteLine("Количество записей в List: {0}", list.Count);
            Console.WriteLine();


            LinkedList<int> linkedList = new LinkedList<int>();

            sw.Reset();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                linkedList.AddLast(random.Next());
            }
            sw.Stop();
            Console.WriteLine("LinkedList: {0} миллисекунд", sw.ElapsedMilliseconds);
            Console.WriteLine("Количество записей в LinkedList: {0}", linkedList.Count);
            Console.WriteLine();


            ArrayList arrayList = new ArrayList();

            sw.Reset();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                arrayList.Add(random.Next());
            }
            sw.Stop();
            Console.WriteLine("ArrayList: {0} миллисекунд", sw.ElapsedMilliseconds);
            Console.WriteLine("Количество записей в ArrayList: {0}", arrayList.Count);
            Console.WriteLine();
            Console.WriteLine();


            //Search
            Console.WriteLine("Поиск значения по заданному индексу");
            Console.WriteLine();


            sw.Reset();
            sw.Start ();
            int found = list[indexForSearch];
            sw.Stop ();
            Console.WriteLine("Найденное число: {0}", found);
            Console.WriteLine("Время затраченное на поиск в List: {0}", sw.ElapsedMilliseconds);
            Console.WriteLine();


            sw.Reset();
            sw.Start();
            found = linkedList.ElementAt(indexForSearch);
            sw.Stop();
            Console.WriteLine("Найденное число: {0}", found);
            Console.WriteLine("Время затраченное на поиск в LinkedList: {0}", sw.ElapsedMilliseconds);
            Console.WriteLine();


            sw.Reset();
            sw.Start();
            found = int.Parse(arrayList[indexForSearch].ToString());
            sw.Stop();
            Console.WriteLine("Найденное число: {0}", found);
            Console.WriteLine("Время затраченное на поиск в ArrayList: {0}", sw.ElapsedMilliseconds);
            Console.WriteLine();
            Console.WriteLine();




            ///Проверка на делимость

            Console.WriteLine("Перебор всех элементов всех типов коллекций и проверка их делимости без остатка на 777, вывод этих значений");
            sw.Reset ();
            sw.Start ();
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] % 777 == 0) { Console.WriteLine(list[i]); }
            }
            sw.Stop();
            Console.WriteLine("Время затраченное на проверку всех элемпентов коллекции List: {0}",sw.ElapsedMilliseconds);
            Console.WriteLine();

            sw.Reset();
            sw.Start();

            var currentNode = linkedList.First;
            while (currentNode != null)
            {
                if (currentNode.Value%777 == 0) { Console.WriteLine(currentNode.Value); }
                currentNode = currentNode.Next;
            }



            sw.Stop();
            Console.WriteLine("Время затраченное на проверку всех элемпентов коллекции LinkedList: {0}", sw.ElapsedMilliseconds);
            Console.WriteLine();

            sw.Reset();
            sw.Start();
            for (int i = 0; i < arrayList.Count - 1; i++)
            {
                if (int.Parse(arrayList[i].ToString()) % 777 == 0) { Console.WriteLine(arrayList[i]); }
            }
            sw.Stop();
            Console.WriteLine("Время затраченное на проверку всех элемпентов коллекции ArrayList: {0}", sw.ElapsedMilliseconds);
            Console.WriteLine();



            Console.ReadKey();


            ///////////////////////
            /// Закончил 16 сентября 2024г.,13:46:14
            ///////////////////////
        }
    }
}
