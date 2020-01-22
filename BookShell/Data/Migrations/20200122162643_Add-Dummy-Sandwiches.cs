using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShell.Data.Migrations
{
    public partial class AddDummySandwiches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21fb4a38-6c55-4be7-90d3-c9c404850e0b", "AQAAAAEAACcQAAAAEGfRiF48873OI4cmq/guMZIoew63o3Hvomr6JwIDzshcpep7BuytNWgsYTnH2lYpWQ==" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { 1, "00000000-ffff-ffff-ffff-ffffffffffff", "Jimmy John" },
                    { 2, "00000000-ffff-ffff-ffff-ffffffffffff", "Jersey Mike" },
                    { 3, "00000000-ffff-ffff-ffff-ffffffffffff", "Jared Fogel" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "Rating", "Title", "YearPublished" },
                values: new object[] { 1, "00000000-ffff-ffff-ffff-ffffffffffff", 1, "Sandwiches", 10, "Free Smells", 1990 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "Rating", "Title", "YearPublished" },
                values: new object[] { 2, "00000000-ffff-ffff-ffff-ffffffffffff", 2, "Sandwiches", 1, "Jersey Subs", 2020 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "Rating", "Title", "YearPublished" },
                values: new object[] { 3, "00000000-ffff-ffff-ffff-ffffffffffff", 3, "Instructional", 0, "How to make a prison sandwich", 2015 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text" },
                values: new object[] { 2, "00000000-ffff-ffff-ffff-ffffffffffff", 1, "what is even jimmy john's" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text" },
                values: new object[] { 1, "00000000-ffff-ffff-ffff-ffffffffffff", 2, "It smells like jersey" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text" },
                values: new object[] { 3, "00000000-ffff-ffff-ffff-ffffffffffff", 3, "how did he write this book?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5ff8e7a-a6ae-41fa-ba7d-948398230dc8", "AQAAAAEAACcQAAAAEN7hjLwi3PAIz4cihs9f/Lk3JY8STzkogyQpTzsD5iGKl2sTFN8S2picXsaq3yLgCA==" });
        }
    }
}
