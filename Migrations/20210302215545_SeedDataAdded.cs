using Microsoft.EntityFrameworkCore.Migrations;

namespace GoldfishClub.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "BlogPath" },
                values: new object[] { 1, "~/Views/Blogs/January/JanuaryBlog.cshtml" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "BlogPath" },
                values: new object[] { 2, "~/Views/Blogs/February/FebruaryBlog.cshtml" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "BlogPath" },
                values: new object[] { 3, "~/Views/Blogs/March/MarchBlog.cshtml" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
