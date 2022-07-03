using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    //"{phrase} {event} {author} – {city}. "
    class Message
    {
        public string Phrase { get; set; }
        public string Events { get; set; }
        public string Authors { get; set; }
        public string Cities { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Phrases – Excellent product., Such a great product., I always use that product., Best product of its category., Exceptional product., I can’t live without this product.
            string[] phrsses = "Excellent product., Such a great product., I always use that product., Best product of its category., Exceptional product., I can’t live without this product.".
                Split(", ", StringSplitOptions.RemoveEmptyEntries);
            //•	Events – {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
            string[] events = "Now I feel good., I have succeeded with this product., Makes miracles. I am happy of the results!, I cannot believe but now I feel awesome., Try it yourself, I am very satisfied., I feel great!"
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            //•	Authors – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
            string[] authors = "Diana, Petya, Stella, Elena, Katya, Iva, Annie, Eva".
                Split(", ", StringSplitOptions.RemoveEmptyEntries);
            //•	Cities – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}
            string[] cities = "Burgas, Sofia, Plovdiv, Varna, Ruse".Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int numb=int.Parse(Console.ReadLine());
            List<Message> msgs = new List<Message>();

            for (int i = 0; i < numb; i++)
            {
                Random ranPhrases = new Random();
                Random ranEvents=new Random();
                Random ranAuthors=new Random();
                Random ranCitis = new Random();
                Message message = new Message();
                int ranPhr = ranPhrases.Next(0, phrsses.Length);
                int ranEve = ranEvents.Next(0, events.Length);
                int ranAut=ranAuthors.Next(0,authors.Length);
                int ranCit = ranCitis.Next(0, cities.Length);

                message.Phrase = phrsses[ranPhr];
                message.Events = events[ranEve];
                message.Authors=authors[ranAut];
                message.Cities=cities[ranCit];

                msgs.Add(message);

            }
            //"{phrase} {event} {author} – {city}."
            foreach (var mes in msgs)
            {
                Console.WriteLine($"{mes.Phrase} {mes.Events} {mes.Authors} – {mes.Cities}.");
            }
        }
    }
}
