using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDemo
{
    public partial class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public System.DateTime DatePublished { get; set; }
    }

    public class BlogDbContext : DbContext {
        public DbSet<Post> Posts { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
