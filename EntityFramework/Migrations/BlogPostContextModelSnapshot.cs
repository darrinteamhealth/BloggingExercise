// <auto-generated />
using System;
using EntityFramework.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFramework.Migrations
{
    [DbContext(typeof(BlogPostContext))]
    partial class BlogPostContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("EntityFramework.Models.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTimePosted")
                        .HasColumnType("TEXT");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Body = "Fleece was white as snow.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 21, 50, 853, DateTimeKind.Local).AddTicks(1165),
                            SubjectId = 1,
                            Title = "Mary Had a Little Lamb"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Body = "Eating her curds and whey.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 20, 50, 855, DateTimeKind.Local).AddTicks(8171),
                            SubjectId = 1,
                            Title = "Little Miss Moffat"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Body = "Could eat no fat.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 19, 50, 855, DateTimeKind.Local).AddTicks(8201),
                            SubjectId = 1,
                            Title = "Jack Sprat"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            Body = "Nobody could put him together again.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 18, 50, 855, DateTimeKind.Local).AddTicks(8206),
                            SubjectId = 1,
                            Title = "Humpty Dumpty"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 1,
                            Body = "Yellow and has a peel.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 17, 50, 855, DateTimeKind.Local).AddTicks(8209),
                            SubjectId = 2,
                            Title = "Bananas"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 2,
                            Body = "Red or green.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 16, 50, 855, DateTimeKind.Local).AddTicks(8211),
                            SubjectId = 2,
                            Title = "Apples"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 3,
                            Body = "Pell them and split them into sections.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 15, 50, 855, DateTimeKind.Local).AddTicks(8214),
                            SubjectId = 2,
                            Title = "Oranges"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 4,
                            Body = "Big with a thick green rind, red on the inside.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 14, 50, 855, DateTimeKind.Local).AddTicks(8217),
                            SubjectId = 2,
                            Title = "Watermelon"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 1,
                            Body = "Wet droplets from the sky.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 13, 50, 855, DateTimeKind.Local).AddTicks(8219),
                            SubjectId = 3,
                            Title = "Rain"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 2,
                            Body = "White and fluffy.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 12, 50, 855, DateTimeKind.Local).AddTicks(8222),
                            SubjectId = 3,
                            Title = "Snow"
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = 3,
                            Body = "Cold and wet, like half snow, half rain.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 11, 50, 855, DateTimeKind.Local).AddTicks(8225),
                            SubjectId = 3,
                            Title = "Sleet"
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 4,
                            Body = "Frozen balls of ice that fall, ouch!",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 10, 50, 855, DateTimeKind.Local).AddTicks(8228),
                            SubjectId = 3,
                            Title = "Hail"
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 1,
                            Body = "Philips or flathead. Screws screws.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 9, 50, 855, DateTimeKind.Local).AddTicks(8231),
                            SubjectId = 4,
                            Title = "Screwdriver"
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = 2,
                            Body = "Whacks nails, can sometimes also remove them.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 8, 50, 855, DateTimeKind.Local).AddTicks(8234),
                            SubjectId = 4,
                            Title = "Hammer"
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = 3,
                            Body = "Drills holes, can sometimes work as a power screwdriver.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 7, 50, 855, DateTimeKind.Local).AddTicks(8237),
                            SubjectId = 4,
                            Title = "Drill"
                        },
                        new
                        {
                            Id = 16,
                            AuthorId = 4,
                            Body = "Can turn bolts.",
                            DateTimePosted = new DateTime(2022, 3, 22, 19, 6, 50, 855, DateTimeKind.Local).AddTicks(8240),
                            SubjectId = 4,
                            Title = "Wrench"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
