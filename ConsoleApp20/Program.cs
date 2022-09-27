using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public class product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        public override string ToString()
        {
            return $"Product deatails:{id} {name},{price}";
        }
    }
    
    public  class Program
    {
        static void Main(string[] args)
        {
            //   List<product> products = new List<product>()
            //    {
            //        new product { id = 1, name = "lenovo", price = 25000 },
            //        new product { id = 2, name = "hp", price = 35000 },
            //        new product { id = 3, name = "dell", price = 45000 }
            //    };

            //    products.Insert(2,new product { id=4,name="reliance",price=5500});
            //    products.Add(new product { id = 5, name = "acer", price = 33000 });
            //    foreach(product item in products)
            //    {
            //        Console.WriteLine(item);
            //    }

            //Stack<int> stack1 = new Stack<int>();
            //Stack<int>stack=new Stack<int>();
            //stack.Push(20);
            //stack.Push(60);
            //stack.Push(70);
            //stack.Push(90);
            //stack.Pop();
            //stack.Clear();
            //// removes and returns the object at the top
            //Console.WriteLine(stack.Contains(20));
            //Console.WriteLine(stack.Max());
            //Console.WriteLine(stack.Count);
            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("ABC");
            //queue.Enqueue("EFG");
            //queue.Enqueue("HRQ");
            //queue.Reverse();
            //queue.Peek();
            
            //foreach(string i in queue)
            //{
            //    Console.WriteLine(i);

            //}

            Dictionary<string, int> abc = new Dictionary<string, int>();
            abc.Add("rahul", 500);
            abc.Add("mahesh", 600);
            abc.Add("nagesh", 700);
            Console.WriteLine(abc.ContainsKey("rahul"));
            Console.WriteLine(abc.Count());
            foreach(KeyValuePair<string,int>item in abc)
            {
                Console.WriteLine(item.Key+" " + item.Value);
            }
        }
    }
}
