using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       Video video1 = new Video("C# for beginners","Eniola",600);

       Video video2 = new Video("How to code", "David", 500);

       Video video3 = new Video("C# OOP", "Rachel", 750 );

       Video video4 = new Video("Simple C# synthax", "Mary", 500);

       video1._comments.Add(new Comment("Grace", "Amazing tutorial"));
       video1._comments.Add(new Comment("John", "Awesome"));

       video2._comments.Add(new Comment("Ada", "Thanks, very helpful"));
       video2._comments.Add(new Comment("Rachel", "Thank you!"));

       video3._comments.Add(new Comment("Simon", "I understand OOP clearer now"));
       video3._comments.Add(new Comment("Dorcas", "Made OOP fun!"));

       video4._comments.Add(new Comment("Lanre", "VerY easy to remember"));
       video4._comments.Add(new Comment("Joy", "Thanks alot"));

       List<Video> videos = new List<Video>();
       videos.Add(video1);
       videos.Add(video2);
       videos.Add(video3);
       videos.Add(video4);

       foreach(Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of Comments: " + video.NumberOfComments());
            Console.WriteLine("Comments: ");

            foreach(Comment comment in video._comments)
            {
                Console.WriteLine("- " + comment._name + ": " + comment._text);
            }
            Console.WriteLine();
        }
    }
}
