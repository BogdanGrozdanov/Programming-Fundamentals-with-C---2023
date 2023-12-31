﻿namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleInput = Console.ReadLine().Split(", ");

            string title = articleInput[0];
            string content = articleInput[1];
            string autor = articleInput[2];

            Article article = new Article(title, content, autor);

            int numOfComand = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfComand; i++)
            {
                string[] comand = Console.ReadLine().Split(": ");
                if (comand[0] == "Edit") { article.Edit(comand[1]); }
                else if (comand[0] == "ChangeAuthor") { article.ChangeAuthor(comand[1]); }
                else if (comand[0] == "Rename") { article.Rename(comand[1]); }
            }
        }
        public class Article
        {
            public Article(string title, string content, string autor)
            {
                Title = title;
                Content = content;
                Autor = autor;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Autor { get; set; }

            public string Edit(string newContent)
            { this.Content = newContent; return Content; }
            public string ChangeAuthor(string newAutor)
            { this.Autor = newAutor; return Autor; }
            public string Rename(string newTitle)
            { this.Title = newTitle; return Title; }
            public override string ToString()
            {
                return base.ToString();
            }


        }
    }
}
