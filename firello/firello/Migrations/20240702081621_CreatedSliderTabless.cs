using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace firello.Migrations
{
    public partial class CreatedSliderTabless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SliderInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SliderInfos",
                columns: new[] { "Id", "Description", "Signature", "Title" },
                values: new object[] { 1, "Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will make it special cursus a sit amet mauris.", "h2-sign-img.png", "<h1>Send<span>flowers</span>like</h1><h1>you mean it </h1>" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "h3-slider-background.jpg" },
                    { 2, "h3-slider-background-2.jpg" },
                    { 3, "h3-slider-background-3.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SliderInfos");

            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
