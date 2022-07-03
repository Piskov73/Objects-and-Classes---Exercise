using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // { title}, { content}, { author}
            List<Article> atricle=new List<Article>();
            int numComand = int.Parse(Console.ReadLine());
            for (int i = 0; i < numComand; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = input[0];
                string content = input[1];
                string author = input[2];
                Article newArticle = new Article();
                newArticle.Title = title;
                newArticle.Content = content;
                newArticle.Author = author;
                atricle.Add(newArticle);
            }
            //string comand=Console.ReadLine();

            //List<Article> filterArticle = new List<Article>();
            //switch (comand)
            //{
            //    //title", "content" or an "author
            //    case "title":
            //        filterArticle = atricle.OrderByDescending(x => x.Title).ToList();
            //        break;
            //    case "content":
            //         filterArticle = atricle.OrderByDescending(x => x.Content).ToList();
            //        break;
            //    case "author":
            //        filterArticle = atricle.OrderByDescending(x => x.Author).ToList();
            //        break;

            //}
            foreach (var article in atricle)
            {
                Console.WriteLine(article);
            }

        }
        class Article
        {

           
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            //Edit (new content)
            public void Edit(string newConter)
            {
                Content = newConter;
            }
            //•	ChangeAuthor (new author) 
            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }
            public void Rename(string newtitle)
            {
                Title = newtitle;
            }
            //"{title} - {content}: {author}"
            //	Override the ToString 
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }


        }
    }

}
