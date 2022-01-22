using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;




namespace blogPostMakeUpdateCsharp
{

    class Program
    {


         static void Main(string[] args)
        {
            Console.WriteLine("Do you want to perform an action to do with blog posts(b) or project posts(p)");
            string userChoice = Console.ReadLine();
            string lowerCaseChoice = userChoice.ToLower();
            makeChoice(lowerCaseChoice);
        }
            

             static void makeChoice(string choice)
            {

                switch (choice)
                {
                    case "b":
                        createNewBlogPost();
                        break;

                    case "p":
                        createNewProjectPost();
                        break;

                    default:
                        Console.WriteLine("Invalid charachter.");
                        break;


                }
            }


            static void createNewBlogPost()
            {
                Console.WriteLine("enter title for this post: \n");
                string title = Console.ReadLine();
                Console.WriteLine("enter body of this post: \n");
                string body = Console.ReadLine();

                var blogP = new Post
                {
                    dateTime = DateTime.Now,
                    fileName = "C:/Users/hlucy/Documents/blogPostMakeUpdateCsharp/blogPostMakeUpdateCsharp/json1.json",
                    title = title,
                    body = body
                };

                string jsonString = JsonSerializer.Serialize(blogP);
                //converts value in the blogP object into a json object

                File.WriteAllText(blogP.fileName, jsonString);
                //writes the newly created json object to the json file provided

                Console.WriteLine(File.ReadAllText(blogP.fileName));
                //displays content of the file

            }

            static void createNewProjectPost()
            {
                Console.WriteLine("Under development");
            }
        }
    }


