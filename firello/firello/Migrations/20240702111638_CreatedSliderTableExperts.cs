using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace firello.Migrations
{
    public partial class CreatedSliderTableExperts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expert",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expert", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurpriseImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupriseImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurpriseImage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurpriseText",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurpriseText", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Expert",
                columns: new[] { "Id", "Image", "Name", "Profession" },
                values: new object[,]
                {
                    { 1, "h3-team-img-1.png", "CRYSTAL BROOKS", "Florist" },
                    { 2, "h3-team-img-2.png", "SHIRLEY HARRIS", "Manager" },
                    { 3, "h3-team-img-3.png", "BEVERLY CLARK", "Florist" },
                    { 4, "h3-team-img-4.png", "AMANDA WATKINS", "Florist" }
                });

            migrationBuilder.InsertData(
                table: "SurpriseImage",
                columns: new[] { "Id", "SupriseImage" },
                values: new object[] { 1, "h3-video-img.jpg" });

            migrationBuilder.InsertData(
                table: "SurpriseText",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "Where flowers are our inspiration to create lasting memories. Whatever the occasion...", "<h1>Suprise Your<span>Valentine!</span> Let us arrange a smile.</h1>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expert");

            migrationBuilder.DropTable(
                name: "SurpriseImage");

            migrationBuilder.DropTable(
                name: "SurpriseText");
        }
    }
}
