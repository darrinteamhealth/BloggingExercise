using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFramework.DataContext
{
    public class BlogPostContext : DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BlogPosts.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPost>().ToTable("BlogPosts");
            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost { Id = 1, Title = "Mary Had a Little Lamb", Body = "Fleece was white as snow.", AuthorId = 1, SubjectId = 1, DateTimePosted = DateTime.Now.AddMinutes(-1) },
                new BlogPost { Id = 2, Title = "Little Miss Moffat", Body = "Eating her curds and whey.", AuthorId = 2, SubjectId = 1, DateTimePosted = DateTime.Now.AddMinutes(-2) },
                new BlogPost { Id = 3, Title = "Jack Sprat", Body = "Could eat no fat.", AuthorId = 3, SubjectId = 1, DateTimePosted = DateTime.Now.AddMinutes(-3) },
                new BlogPost { Id = 4, Title = "Humpty Dumpty", Body = "Nobody could put him together again.", AuthorId = 4, SubjectId = 1, DateTimePosted = DateTime.Now.AddMinutes(-4) },

                new BlogPost { Id = 5, Title = "Bananas", Body = "Yellow and has a peel.", AuthorId = 1, SubjectId = 2, DateTimePosted = DateTime.Now.AddMinutes(-5) },
                new BlogPost { Id = 6, Title = "Apples", Body = "Red or green.", AuthorId = 2, SubjectId = 2, DateTimePosted = DateTime.Now.AddMinutes(-6) },
                new BlogPost { Id = 7, Title = "Oranges", Body = "Pell them and split them into sections.", AuthorId = 3, SubjectId = 2, DateTimePosted = DateTime.Now.AddMinutes(-7) },
                new BlogPost { Id = 8, Title = "Watermelon", Body = "Big with a thick green rind, red on the inside.", AuthorId = 4, SubjectId = 2, DateTimePosted = DateTime.Now.AddMinutes(-8) },

                new BlogPost { Id = 9, Title = "Rain", Body = "Wet droplets from the sky.", AuthorId = 1, SubjectId = 3, DateTimePosted = DateTime.Now.AddMinutes(-9) },
                new BlogPost { Id = 10, Title = "Snow", Body = "White and fluffy.", AuthorId = 2, SubjectId = 3, DateTimePosted = DateTime.Now.AddMinutes(-10) },
                new BlogPost { Id = 11, Title = "Sleet", Body = "Cold and wet, like half snow, half rain.", AuthorId = 3, SubjectId = 3, DateTimePosted = DateTime.Now.AddMinutes(-11) },
                new BlogPost { Id = 12, Title = "Hail", Body = "Frozen balls of ice that fall, ouch!", AuthorId = 4, SubjectId = 3, DateTimePosted = DateTime.Now.AddMinutes(-12) },

                new BlogPost { Id = 13, Title = "Screwdriver", Body = "Philips or flathead. Screws screws.", AuthorId = 1, SubjectId = 4, DateTimePosted = DateTime.Now.AddMinutes(-13) },
                new BlogPost { Id = 14, Title = "Hammer", Body = "Whacks nails, can sometimes also remove them.", AuthorId = 2, SubjectId = 4, DateTimePosted = DateTime.Now.AddMinutes(-14) },
                new BlogPost { Id = 15, Title = "Drill", Body = "Drills holes, can sometimes work as a power screwdriver.", AuthorId = 3, SubjectId = 4, DateTimePosted = DateTime.Now.AddMinutes(-15) },
                new BlogPost { Id = 16, Title = "Wrench", Body = "Can turn bolts.", AuthorId = 4, SubjectId = 4, DateTimePosted = DateTime.Now.AddMinutes(-16) }
                );
        }


    }
}
