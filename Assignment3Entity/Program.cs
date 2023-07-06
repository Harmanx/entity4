using Core.entities;
using EF3Data.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Assignment3Entity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var context= new DataContext();
            

            Console.WriteLine("Hello world");
            var active=context.Posts.Where(post => post.PostType.status != Statuses.InActive)
                         .Where(post => post.Blog.BlogType.status != Statuses.InActive)
                         .OrderBy(post => post.User.Name).Include(x=>x.Blog.BlogType).Include(x=>x.User).Include(x=>x.PostType);
            foreach(var post in active)
            {
                Console.WriteLine("Blog Url: " + post.Blog.Url);
                Console.WriteLine("Blog IsPublic: " + post.Blog.IsPublic);
                Console.WriteLine("Blog Type Name: " + post.Blog.BlogType.Name);
                Console.WriteLine("Post User Name: " + post.User.Name);
                Console.WriteLine("Post User Email: " + post.User.Email);
                Console.WriteLine("Total Post: " + post.User.Posts.Count);
                Console.WriteLine("Post Name: " + post.PostType.Name);

            }
            Console.ReadLine();




        }
    }
}