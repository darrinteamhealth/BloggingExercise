using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Body = table.Column<string>(type: "TEXT", nullable: true),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateTimePosted = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 1, 1, "Fleece was white as snow.", new DateTime(2022, 3, 22, 19, 21, 50, 853, DateTimeKind.Local).AddTicks(1165), 1, "Mary Had a Little Lamb" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 2, 2, "Eating her curds and whey.", new DateTime(2022, 3, 22, 19, 20, 50, 855, DateTimeKind.Local).AddTicks(8171), 1, "Little Miss Moffat" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 3, 3, "Could eat no fat.", new DateTime(2022, 3, 22, 19, 19, 50, 855, DateTimeKind.Local).AddTicks(8201), 1, "Jack Sprat" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 4, 4, "Nobody could put him together again.", new DateTime(2022, 3, 22, 19, 18, 50, 855, DateTimeKind.Local).AddTicks(8206), 1, "Humpty Dumpty" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 5, 1, "Yellow and has a peel.", new DateTime(2022, 3, 22, 19, 17, 50, 855, DateTimeKind.Local).AddTicks(8209), 2, "Bananas" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 6, 2, "Red or green.", new DateTime(2022, 3, 22, 19, 16, 50, 855, DateTimeKind.Local).AddTicks(8211), 2, "Apples" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 7, 3, "Pell them and split them into sections.", new DateTime(2022, 3, 22, 19, 15, 50, 855, DateTimeKind.Local).AddTicks(8214), 2, "Oranges" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 8, 4, "Big with a thick green rind, red on the inside.", new DateTime(2022, 3, 22, 19, 14, 50, 855, DateTimeKind.Local).AddTicks(8217), 2, "Watermelon" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 9, 1, "Wet droplets from the sky.", new DateTime(2022, 3, 22, 19, 13, 50, 855, DateTimeKind.Local).AddTicks(8219), 3, "Rain" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 10, 2, "White and fluffy.", new DateTime(2022, 3, 22, 19, 12, 50, 855, DateTimeKind.Local).AddTicks(8222), 3, "Snow" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 11, 3, "Cold and wet, like half snow, half rain.", new DateTime(2022, 3, 22, 19, 11, 50, 855, DateTimeKind.Local).AddTicks(8225), 3, "Sleet" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 12, 4, "Frozen balls of ice that fall, ouch!", new DateTime(2022, 3, 22, 19, 10, 50, 855, DateTimeKind.Local).AddTicks(8228), 3, "Hail" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 13, 1, "Philips or flathead. Screws screws.", new DateTime(2022, 3, 22, 19, 9, 50, 855, DateTimeKind.Local).AddTicks(8231), 4, "Screwdriver" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 14, 2, "Whacks nails, can sometimes also remove them.", new DateTime(2022, 3, 22, 19, 8, 50, 855, DateTimeKind.Local).AddTicks(8234), 4, "Hammer" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 15, 3, "Drills holes, can sometimes work as a power screwdriver.", new DateTime(2022, 3, 22, 19, 7, 50, 855, DateTimeKind.Local).AddTicks(8237), 4, "Drill" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "DateTimePosted", "SubjectId", "Title" },
                values: new object[] { 16, 4, "Can turn bolts.", new DateTime(2022, 3, 22, 19, 6, 50, 855, DateTimeKind.Local).AddTicks(8240), 4, "Wrench" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");
        }
    }
}
