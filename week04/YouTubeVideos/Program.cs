using System;
using System.Reflection;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

      

        List<Video> videos = new List<Video> ();

        Video video1 = new Video("Samsung Galaxy S26 Ultra Review","Lisa Gade","12:45 min");

        video1.AddComment(new Comment("Michael Johnson","The camera quality is impressive this year"));
        video1.AddComment(new Comment("Sarah Williams","Samsung finally improved the battery life"));
        video1.AddComment(new Comment("David Brown", "Great review. Very detailed and easy to understand"));

        videos.Add(video1);

        Video video2 = new Video("Galaxy Buds 4 Pro: Premium Audio Upgrade?","Chris Barraclough","14 min");
        video2.AddComment(new Comment("Emily Davis", "The noise cancellation sounds much better now"));
        video2.AddComment(new Comment("James Wilson","I'm upgrading from the buds 2 Pro after watching this"));
        video2.AddComment(new Comment("Olivia Martinez", "The sound test comparison was very helpful"));

        videos.Add(video2);

        Video video3 = new Video("Apple MacBook Neo Review","Lisa Gade","13 min");
        video3.AddComment(new Comment("Daniel Anderson", "Battery life is absolutely insane"));
        video3.AddComment(new Comment("Sophia Taylor", "Perfect laptop for developers and students"));
        video3.AddComment(new Comment("Matthew Thomas","Apple keeps pushing laptop performance forward"));

        videos.Add(video3);



        foreach (Video  video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}") ;
            Console.WriteLine($"Author:{ video.GetAuthor()}");
            Console.WriteLine($"Length:{video.GetLength()}");
            Console.WriteLine($"Number of Comments {video.GetNumberOfComments()}") ;
            Console.WriteLine("");

            foreach(Comment comment in video.GetComments())
            {
                  Console.WriteLine($"{comment.GetPersonName()}: {comment.GetComment()}");
                  
            }


            Console.WriteLine("");
            Console.WriteLine("");

            

        

        
        
         


        }


     
    }
}