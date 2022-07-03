using System;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // { title}, { content}, { author}
            string[] input = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);

            Article inputArticle = new Article(input[0], input[1], input[2]);
            int numComand = int.Parse(Console.ReadLine());
            for (int i = 0; i < numComand; i++)
            {
                //  "Edit: {new content}"
                //•	"ChangeAuthor: {new author}"
                //•	"Rename: {new title}"
                string[] comand = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
                string ection = comand[0];
                string text = comand[1];
                switch (ection)
                {
                    case "Edit":
                        inputArticle.Edit(text);
                        break;
                    case "ChangeAuthor":
                        inputArticle.ChangeAuthor(text);

                        break;
                    case "Rename":
                        inputArticle.Rename(text);
                        break;
                }
            }
            Console.WriteLine(inputArticle);

        }
        class Article
        {

            public Article(string title, string content, string author)
            {
                //"{title}, {content}, {author}". 
                this.Title = title;
                this.Content = content;
                this.Author = author;

            }
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
                return $"{Title} -{Content}:{Author}";
            }


        }
    }
  
}
