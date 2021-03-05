using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldfishClub.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed blogs
            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                BlogId = 1,
                BlogPath = "~/Views/Blog/January/JanuaryBlog.cshtml"
            });

            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                BlogId = 2,
                BlogPath = "~/Views/Blog/February/FebruaryBlog.cshtml"
            });

            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                BlogId = 3,
                BlogPath = "~/Views/Blog/March/MarchBlog.cshtml"
            });
        }

    }
}
