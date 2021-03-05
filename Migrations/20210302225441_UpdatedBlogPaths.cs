using Microsoft.EntityFrameworkCore.Migrations;

namespace GoldfishClub.Migrations
{
    public partial class UpdatedBlogPaths : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "BlogPath",
                value: "~/Views/Blog/January/JanuaryBlog.cshtml");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "BlogPath",
                value: "~/Views/Blog/February/FebruaryBlog.cshtml");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "BlogPath",
                value: "~/Views/Blog/March/MarchBlog.cshtml");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "BlogPath",
                value: "~/Views/Blogs/January/JanuaryBlog.cshtml");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "BlogPath",
                value: "~/Views/Blogs/February/FebruaryBlog.cshtml");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "BlogPath",
                value: "~/Views/Blogs/March/MarchBlog.cshtml");
        }
    }
}
