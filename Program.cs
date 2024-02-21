using System;
using System.Collections;
using System.Collections.Generic;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(4.5); list.Add(18);
            list.AddRange(new string[] { "Студент", "Петров" });
            ArrayList newList = new ArrayList();
            newList.Add(10); newList.Add(20); newList.Add(30); newList.Add(40);
            Console.WriteLine("Введите индекс, с которого начать вставку новой коллекции:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            list.InsertRange(n1, newList);
            int n = n1 / 2;
            Console.WriteLine("Введите количество элементов для удаления из нового списка:");
            int k = Convert.ToInt32(Console.ReadLine());
            newList.RemoveRange(n, k);
            Console.WriteLine("Новый список:");
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}