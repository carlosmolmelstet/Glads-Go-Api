using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiGladsGo.Migrations
{
    public partial class carlosLindo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    ShortName = table.Column<string>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 80, nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    PositionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("5862b9b3-8f24-4bbc-82d7-00afa904f2a5"), "Wide Reciver", "WR" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "Quarterback", "QB" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "Running Back", "RB" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("9d5e1cf5-9a36-4fd2-b2af-d14371591873"), "Player1@gmail.com", null, "Player 1 ", "adm", "(47) 99630-5948", new Guid("5862b9b3-8f24-4bbc-82d7-00afa904f2a5"), "adm" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("adcd730c-2af4-42c0-80ec-b7652619a30a"), "Player36@gmail.com", null, "Player 36 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("186aedc4-b738-44b1-97a6-11c0a751163d"), "Player37@gmail.com", null, "Player 37 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("4a24c058-1389-45f9-829c-dbc124929668"), "Player38@gmail.com", null, "Player 38 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("e8f78da0-c114-43fc-bec7-86b043bb48b7"), "Player39@gmail.com", null, "Player 39 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("c89b5b89-30fe-48eb-9bf6-bb923800e791"), "Player40@gmail.com", null, "Player 40 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("db903e18-c74a-40af-b2a9-76877d7c7f41"), "Player3@gmail.com", null, "Player 3 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("9d65417c-18ae-4a55-be13-de1ac984db14"), "Player4@gmail.com", null, "Player 4 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("0da3f550-d95f-43b4-b11a-07358b635c7d"), "Player32@gmail.com", null, "Player 32 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("2711a363-26cc-4524-a26a-faaa8b897c4a"), "Player5@gmail.com", null, "Player 5 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("ed9248c3-f85a-4645-bb82-00f0d709be33"), "Player14@gmail.com", null, "Player 14 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("81967380-5645-4ac4-9dce-61c22ad88af7"), "Player21@gmail.com", null, "Player 21 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("08f800e2-5b87-4daa-806e-dcf86b9fe949"), "Player24@gmail.com", null, "Player 24 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("4e6f0e09-3b47-4dbe-a93d-9e852a549d6a"), "Player26@gmail.com", null, "Player 26 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("4048c397-f514-4ea1-82dd-9e9800e815e1"), "Player29@gmail.com", null, "Player 29 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("f6c47ff7-335a-40f5-b431-af0a58b2b9e6"), "Player30@gmail.com", null, "Player 30 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("15985f12-f0d5-43aa-b6ed-0aa3f55714ca"), "Player33@gmail.com", null, "Player 33 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("003df1db-07af-4154-9ea9-b6f86e167e0c"), "Player11@gmail.com", null, "Player 11 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("7ebf64ef-af0a-40bd-98d3-80912346144a"), "Player27@gmail.com", null, "Player 27 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("ac44cdb9-8d06-44a1-a2e9-fccd8d863de3"), "Player22@gmail.com", null, "Player 22 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("d6ea5435-244f-42c5-aa7f-83f89a52094e"), "Player17@gmail.com", null, "Player 17 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("1d3038ab-448f-46f0-9d69-1ab41315c606"), "Player10@gmail.com", null, "Player 10 ", "user", "(47) 99630-5948", new Guid("5862b9b3-8f24-4bbc-82d7-00afa904f2a5"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("ed406918-c48f-44f3-a897-5680214c834b"), "Player12@gmail.com", null, "Player 12 ", "user", "(47) 99630-5948", new Guid("5862b9b3-8f24-4bbc-82d7-00afa904f2a5"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("81d0e316-c80b-4f04-b040-4c13ddf48d0d"), "Player15@gmail.com", null, "Player 15 ", "user", "(47) 99630-5948", new Guid("5862b9b3-8f24-4bbc-82d7-00afa904f2a5"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("c2473cd5-3f80-4e63-8d5e-69b5ccc6ff5f"), "Player18@gmail.com", null, "Player 18 ", "user", "(47) 99630-5948", new Guid("5862b9b3-8f24-4bbc-82d7-00afa904f2a5"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("f8bfdc52-5b3b-48d2-a4c6-67ec57af0688"), "Player19@gmail.com", null, "Player 19 ", "user", "(47) 99630-5948", new Guid("5862b9b3-8f24-4bbc-82d7-00afa904f2a5"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("d456b25e-1a2d-4292-b973-c2c8e83fd953"), "Player20@gmail.com", null, "Player 20 ", "user", "(47) 99630-5948", new Guid("5862b9b3-8f24-4bbc-82d7-00afa904f2a5"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("c4451c94-571b-4a90-9eb5-1423a0bda09e"), "Player23@gmail.com", null, "Player 23 ", "user", "(47) 99630-5948", new Guid("5862b9b3-8f24-4bbc-82d7-00afa904f2a5"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("be9d6e0a-8139-4fdc-bfe5-156aedaef122"), "Player25@gmail.com", null, "Player 25 ", "user", "(47) 99630-5948", new Guid("5862b9b3-8f24-4bbc-82d7-00afa904f2a5"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("47004ae1-999e-4d1d-91f0-4f3e1a5e9da7"), "Player28@gmail.com", null, "Player 28 ", "user", "(47) 99630-5948", new Guid("5862b9b3-8f24-4bbc-82d7-00afa904f2a5"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("42c28349-53e3-4194-9614-50dd655474da"), "Player31@gmail.com", null, "Player 31 ", "user", "(47) 99630-5948", new Guid("5862b9b3-8f24-4bbc-82d7-00afa904f2a5"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("d8be9f87-562b-4ea5-9265-302985090bb2"), "Player2@gmail.com", null, "Player 2 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("a9f8a52e-4ad6-4c64-8d2b-f5b6839c0c3a"), "Player6@gmail.com", null, "Player 6 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("14f8a9c6-5012-490c-bceb-eb831fa605f3"), "Player7@gmail.com", null, "Player 7 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("8399da38-27a6-4562-ae9a-ee42b6531ab8"), "Player8@gmail.com", null, "Player 8 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("4013dfd4-1402-4ac7-9066-de3ac2481ee7"), "Player9@gmail.com", null, "Player 9 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("7c300731-4db7-4f4c-8362-c524f42166a4"), "Player13@gmail.com", null, "Player 13 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("cead14cd-fb29-497f-8f6d-4c88ac7a13cd"), "Player16@gmail.com", null, "Player 16 ", "user", "(47) 99630-5948", new Guid("b527b14b-a0cf-4763-b64f-07ec482cc784"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("1aae7de9-266d-4e51-926b-a07be092c743"), "Player34@gmail.com", null, "Player 34 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("a0c3c58b-845d-47ac-9e97-f848e7c506c8"), "Player35@gmail.com", null, "Player 35 ", "user", "(47) 99630-5948", new Guid("2a99cbf7-04c5-42d9-bf46-66ec8abb6bac"), "user" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PositionId",
                table: "Users",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
