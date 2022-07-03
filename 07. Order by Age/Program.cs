using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class OrderAge
    {

        public string Name { get; set; }
        public string ID { get; set; }

        public int Age { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<OrderAge> orderAges = new List<OrderAge>();
            AddOrderAge(orderAges);
            PrintOrderAge(orderAges);

        }



        static void AddOrderAge(List<OrderAge> orderAges)
        {
            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] infoMembar = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = infoMembar[0];
                string iD = infoMembar[1];
                int age = int.Parse(infoMembar[2]);

                OrderAge ubdeitOrder = orderAges.FirstOrDefault(x => x.ID == iD);
                if (ubdeitOrder != null)
                {
                    ubdeitOrder.Age = age;
                    ubdeitOrder.Name = name;
                    comand = Console.ReadLine();
                    continue;
                }
                OrderAge newOrder = new OrderAge();
                newOrder.Age = age;
                newOrder.Name = name;
                newOrder.ID = iD;
                orderAges.Add(newOrder);
                comand = Console.ReadLine();
            }
            return;
        }

        static void PrintOrderAge(List<OrderAge> orderAges)
        {
            //Robert with ID: 523444 is 11 years old.
            foreach (var membar in orderAges.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{membar.Name} with ID: {membar.ID} is {membar.Age} years old.");
            }
        }
    }
}
