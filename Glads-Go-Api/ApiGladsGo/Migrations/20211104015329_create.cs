using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechWeekFatecSul.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_EXAMPLE");

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
                name: "SystemUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 80, nullable: true),
                    PositionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemUsers_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8"), "Wide Reciver", "WR" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3"), "Quarterback", "QB" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("607bee02-237e-4e29-bfcd-22324f405348"), "Running Back", "RB" });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("bec7c4d4-7b9d-43be-9486-d330df7eecb3"), "Player1@gmail.com", null, "Player 1 ", "(47) 99630-5948", new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("2c237f4f-fa8a-47f4-b9bd-76bb6a50dbdc"), "Player36@gmail.com", null, "Player 36 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("8cb94908-e3ab-4719-9993-40aa8034cab6"), "Player37@gmail.com", null, "Player 37 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("79307878-0d15-4590-b80b-93eecdf1664d"), "Player38@gmail.com", null, "Player 38 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("2d9af057-bf4b-4300-bc62-ffbdd4d25fcd"), "Player39@gmail.com", null, "Player 39 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("c26779fa-c5e0-40ca-8b20-de754fae81a7"), "Player40@gmail.com", null, "Player 40 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("1059b6c7-fe0f-47f3-abd8-8fb28fc7d5d2"), "Player3@gmail.com", null, "Player 3 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("fe74cef3-2b3d-4c25-81a8-c53554a0c772"), "Player4@gmail.com", null, "Player 4 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("698dc34d-c663-473c-926c-8b930c130998"), "Player32@gmail.com", null, "Player 32 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("7cf2f0cc-a141-40c4-81f3-82851c20f958"), "Player5@gmail.com", null, "Player 5 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("114ce200-bdb2-4bac-b71d-b464de2bd962"), "Player14@gmail.com", null, "Player 14 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("871ecaaf-5b4d-4732-95cb-c6cbb810bd44"), "Player21@gmail.com", null, "Player 21 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("a7348a99-7595-4fb0-a729-899cfdace166"), "Player24@gmail.com", null, "Player 24 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("5916064d-5da6-40d7-afe4-c74439209b4e"), "Player26@gmail.com", null, "Player 26 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("1e48887d-a0bf-4ac8-843c-c7394cd29081"), "Player29@gmail.com", null, "Player 29 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("c549a547-edc3-421d-94ea-2c13293172a9"), "Player30@gmail.com", null, "Player 30 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("ba517172-a21f-46e1-bb94-5f35f8d1831a"), "Player33@gmail.com", null, "Player 33 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("eebec909-89d7-4744-8a7a-fc421345307a"), "Player11@gmail.com", null, "Player 11 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("90a44f03-ddbd-4ff4-9676-fe866253361f"), "Player27@gmail.com", null, "Player 27 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("303a9550-517c-4300-92cd-2a673ddfa286"), "Player22@gmail.com", null, "Player 22 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("fda6cf1d-af6c-435a-9c35-a779b00d4e2c"), "Player17@gmail.com", null, "Player 17 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("d6a6120b-1051-4b3f-8e0c-c5eb4ee7c210"), "Player10@gmail.com", null, "Player 10 ", "(47) 99630-5948", new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("ba6cb9f9-ffd5-4f07-9a4f-9895289a409a"), "Player12@gmail.com", null, "Player 12 ", "(47) 99630-5948", new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("ac4b15ba-f19e-4cc1-930c-fb9a5160ade5"), "Player15@gmail.com", null, "Player 15 ", "(47) 99630-5948", new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("8e02c517-6972-45e5-a33a-06fa9eba3a88"), "Player18@gmail.com", null, "Player 18 ", "(47) 99630-5948", new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("57fdb557-ec63-4533-aed6-b29141952bae"), "Player19@gmail.com", null, "Player 19 ", "(47) 99630-5948", new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("ee576ed2-4ef5-466c-971c-d685ce80265c"), "Player20@gmail.com", null, "Player 20 ", "(47) 99630-5948", new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("7c9b7685-a1b3-4ab9-a310-fb1df53bc128"), "Player23@gmail.com", null, "Player 23 ", "(47) 99630-5948", new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("9d34bc8d-9d85-4c48-8b01-33f9f313d6ab"), "Player25@gmail.com", null, "Player 25 ", "(47) 99630-5948", new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("b505d4a7-c66e-4a6f-b2d7-8fef8f9689da"), "Player28@gmail.com", null, "Player 28 ", "(47) 99630-5948", new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("7824c8fa-4c5b-45b5-bba8-2c9cc7983a01"), "Player31@gmail.com", null, "Player 31 ", "(47) 99630-5948", new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("ce10cb70-fd07-40cd-91b0-eca67b605ec8"), "Player2@gmail.com", null, "Player 2 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("e15c412c-124c-455a-a7d6-700fed1a326e"), "Player6@gmail.com", null, "Player 6 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("9528147b-d960-471c-a1ee-e84bd2e58268"), "Player7@gmail.com", null, "Player 7 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("5c28c14e-8785-436c-b036-de3ce5cf7474"), "Player8@gmail.com", null, "Player 8 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("6bd5dfc4-9306-4ce1-b94e-c434abe65366"), "Player9@gmail.com", null, "Player 9 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("b2f3d679-8596-49bd-abea-6b9abac0dade"), "Player13@gmail.com", null, "Player 13 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("a66ae7f2-dc58-421e-9bc2-464e1f4d1056"), "Player16@gmail.com", null, "Player 16 ", "(47) 99630-5948", new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("bf15e88d-f089-4c7b-9e09-26f011f9ff9b"), "Player34@gmail.com", null, "Player 34 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Phone", "PositionId" },
                values: new object[] { new Guid("d8ff9499-32f0-466b-b9c4-891b861d2a92"), "Player35@gmail.com", null, "Player 35 ", "(47) 99630-5948", new Guid("607bee02-237e-4e29-bfcd-22324f405348") });

            migrationBuilder.CreateIndex(
                name: "IX_SystemUsers_PositionId",
                table: "SystemUsers",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemUsers");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.CreateTable(
                name: "TB_EXAMPLE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Attended = table.Column<bool>(type: "INTEGER", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Registration = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_EXAMPLE", x => x.Id);
                });
        }
    }
}
