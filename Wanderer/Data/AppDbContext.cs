using Microsoft.EntityFrameworkCore;
using Wanderer.Models;

namespace Wanderer.Data
{
    public class AppDbContext : DbContext
    {
        //constructor for general syntax for establishing connection with entityframework
        public  AppDbContext (DbContextOptions<AppDbContext>options): base(options)
        {
        }
        //creating dbseet <Model name >table name create tables from models
        public DbSet<PostsViewModel> Posts { get; set; }
    }
}
