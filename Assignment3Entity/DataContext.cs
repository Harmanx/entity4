using Core.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Entity
{
    public class DataContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogType> blogTypes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostType> postTypes { get; set; }

        public string DbPath { get; set; }
        public DataContext()
        {
            var path = AppContext.BaseDirectory;
            DbPath = Path.Join(path, "day3.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
