using System;
using System.Collections.Generic;

class Article
{
    public string Title { get; private set; }
    public string Content { get; private set; }
    public string Author { get; private set; }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        int numArticles = int.Parse(Console.ReadLine());
        List<Article> articles = new List<Article>();

        for (int i = 0; i < numArticles; i++)
        {
            string[] articleInfo = Console.ReadLine().Split(", ");
            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            articles.Add(new Article(title, content, author));
        }

        foreach (Article article in articles)
        {
            Console.WriteLine(article);
        }
    }
}
