using System;
using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add("loki");
            arrayList1.Add(false);
            arrayList1.Add(4.5);

            Console.WriteLine(arrayList1[3]);
            Console.WriteLine(arrayList1.Contains("Geetha"));
            Console.WriteLine(arrayList1.Count);

            arrayList1.Insert(2, "beema");
            foreach(var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            ArrayList arrayList2 = new ArrayList();
            arrayList2.Add("India");
            arrayList2.Add("Austrlia");
            arrayList2.Add("UAE");
            arrayList2.Add(230);
            arrayList2.Add(7.6);
            arrayList2.Add("france");
            arrayList2.Add("german");

            arrayList1.InsertRange(3,ArrayList2);

            Console.WriteLine("\n\n After insertRAnge arraylist1 values are");
            foreach(var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            arrayList1.Remove("German");

            Console.WriteLine("\n\n After remove german arraylist1 values arae");
            foreach(var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            arrayList1.RemoveAt(0);
            Console.WriteLine("\n\n after Removeat(0) arraylist1 values are");
            foreach(var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            arrayList1.Remove(3.2);
            Console.WriteLine("\n\n after RemoveRange(3,2) arrayLIst1 values are");
            foreach(var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            arrayList1.Clear();
            Console.WriteLine("\n\n After clear all elemnet" + arrayList1.Count);
            ArrayList clonedArrayList=(ArrayList)arrayList2.Clone();

            Console.WriteLine("cloned array list values");
            foreach(var item in clonedArrayList)
            {
                Console.WriteLine(item);
            }
            int[] myarray = new int[3];
            object[] arrayListcopy = new object[arrayList2.Count];

            arrayList2.CopyTo(arrayListcopy);
            Console.WriteLine("ArrayList Copy");
            foreach(var item in arrayListcopy)
            {
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("sort arrayList values");
                arrayList2.Sort();
                foreach(var item in arrayList2)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
