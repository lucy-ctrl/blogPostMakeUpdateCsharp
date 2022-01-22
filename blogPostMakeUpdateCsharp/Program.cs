using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;




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


            var filePath = blogP.fileName;
            var jsonData = System.IO.File.ReadAllText(filePath);
            //read the content of the exisiting json file

            var blogPostList = JsonConvert.DeserializeObject<List<Post>>(jsonData)?? new List<Post>(); //this is broken
            //If the file exists and contains info, then put it into list of post objects, else create me a new blank list

            blogPostList.Add(blogP);
            //Add my new post object to the list


            jsonData = System.Text.Json.JsonSerializer.Serialize(blogPostList);
                //converts value in the blogP object into a json object

            System.IO.File.WriteAllText(filePath, jsonData);
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


