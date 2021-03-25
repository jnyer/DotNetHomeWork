using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GerericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GerericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> p = Head;
            if (p == null) throw new Exception("Error:The List is empty!");
            while (p!=null)
            {
                action(p.Data);
                p = p.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GerericList<int> testList = new GerericList<int>();
            testList.Add(100);
            testList.Add(3);
            testList.Add(4);
            testList.Add(10);
            testList.ForEach(item => Console.Write($"{item},"));
            int max = 0;
            testList.ForEach(item => { if (item >= max) max = item; });
            Console.WriteLine($"\nMax={max}");
            int min = testList.Head.Data;
            testList.ForEach(item => { if (item <= min) min = item; });
            Console.WriteLine($"Min={min}");
            int sum = 0;
            testList.ForEach(item => sum += item);
            Console.WriteLine($"Sum={sum}");
        }
    }
}
