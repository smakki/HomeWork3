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
            Console.WriteLine("Количество записей в List: {0}", list.Count());
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
            Console.WriteLine("Количество записей в LinkedList: {0}", linkedList.Count());
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


            Console.ReadKey();
        }
    }
}
