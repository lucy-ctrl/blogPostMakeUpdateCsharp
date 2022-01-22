using System;
using System.IO;
using System.Text.Json;

namespace blogPostMakeUpdateCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Post blogPost = new Post();
            blogPost.setDateTime();
            blogPost.setFileName();
            Console.WriteLine("enter title for this post: \n");
            string title = Console.ReadLine();
            blogPost.setTitle(title);
            Console.WriteLine("enter body of this post: \n");
            string body = Console.ReadLine();
            blogPost.setBody(body);

            


            string fileName = blogPost.getFileName();

            string jsonString = JsonSerializer.Serialize(blogPost);

            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));


        }
    }
}
