using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace Generics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var indexForSearch = 496753;
            var list = new List<int>(1000000);
            var linkedList = new LinkedList<int>();
            var arrayList = new ArrayList(1000000);
            CollectionWorker.Add(list);
            CollectionWorker.Add(linkedList);
            CollectionWorker.Add(arrayList);
            Console.WriteLine(" ");
            
            CollectionWorker.Find<int>(list, indexForSearch);
            CollectionWorker.Find<int>(linkedList, indexForSearch);
            CollectionWorker.Find<int>(arrayList, indexForSearch);
            Console.WriteLine(" ");
            
            CollectionWorker.IsDivided(list);
            CollectionWorker.IsDivided(linkedList);
            CollectionWorker.IsDivided(arrayList);
        }
    }


    public class CollectionWorker
    {
        static Stopwatch _sw = new Stopwatch();
        static Random _random = new Random();

        public static void Add(ICollection collection)
        {
            Console.WriteLine("Запись 1000000 записей с помощью рандом в различные коллекции");
            _sw.Start();
            for (var i = 0; i < 1000000; i++)
            {
                var element = _random.Next();
                switch (collection)
                {
                    case LinkedList<int> linkedList:
                        linkedList.AddLast(element);
                        break;
                    case IList list:
                        list.Add(element);
                        break;
                    default:
                        throw new ArgumentException("Неподдерживаемый тип коллекции.");
                }
            }
            _sw.Stop();
            Console.WriteLine("{0}: {1} миллисекунд",collection.GetType().Name, _sw.ElapsedMilliseconds);
            Console.WriteLine("Количество записей в {0}: {1}", collection.GetType().Name,  collection.Count);
            Console.WriteLine(" ");
            _sw.Reset();
        }


        public static void Find<T>(object collection, int index)
        {
            T found;
            Console.WriteLine("Поиск значения по заданному индексу");
            _sw.Start();
            found = collection switch
            {
                LinkedList<T> linkedList => linkedList.ElementAt(index),
                IList list => (T)list[index],
                _ => throw new ArgumentException("Неподдерживаемый тип коллекции.")
            };
            _sw.Stop();
            Console.WriteLine("Найденное число: {0}", found);
            Console.WriteLine("Время затраченное на поиск в {0}: {1}",collection.GetType().Name, _sw.ElapsedMilliseconds);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            _sw.Reset();
        }


        public static void IsDivided(IEnumerable collection)
        {
            _sw.Start();
            foreach (var item in collection)
            {
                if ((int)item % 777 == 0)
                {
                    Console.WriteLine(item);  
                }   
            }
            _sw.Stop();
            Console.WriteLine("Время затраченное на проверку всех элементов коллекции {0}: {1}",
                collection.GetType().Name, _sw.ElapsedMilliseconds);
            Console.WriteLine();
            _sw.Reset();
        }
    }
}

///////////////////////
/// Начал 27 сентября 2024г.,17:02:14
///////////////////////
///////////////////////
/// Прервался 27 сентября 2024г.,17:43:14
///////////////////////
///////////////////////
/// Продолжил 30 сентября 2024г.,10:47:14
///////////////////////
//////////////////////////
/// Закончил 30 сентября 2024г.,15:53:14
///////////////////////