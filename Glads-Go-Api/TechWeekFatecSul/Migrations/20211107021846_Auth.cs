using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechWeekFatecSul.Migrations
{
    public partial class Auth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemUsers");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("39bf2ee4-97ad-47ba-8faf-fe2cdfcb34c3"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("607bee02-237e-4e29-bfcd-22324f405348"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("f9126193-54cc-4dba-b092-2a1c09bc1ee8"));

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
                values: new object[] { new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"), "Wide Reciver", "WR" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "Quarterback", "QB" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "Running Back", "RB" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("d3f1a843-3f26-4ee5-8e11-5826a0dc57d1"), "Player1@gmail.com", null, "Player 1 ", "adm", "(47) 99630-5948", new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"), "adm" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("a3c10012-4545-4e95-9fe1-194978e64198"), "Player36@gmail.com", null, "Player 36 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("5ccb9a8b-5b36-4a86-9148-3144232df979"), "Player37@gmail.com", null, "Player 37 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("3b182ca5-7ae1-46eb-b69e-ba29c69ad21a"), "Player38@gmail.com", null, "Player 38 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("10dfd9a6-ed04-46df-bc57-43b13e396ec4"), "Player39@gmail.com", null, "Player 39 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("34356936-69fc-4ece-ad74-ad9ffeb48a76"), "Player40@gmail.com", null, "Player 40 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("92d292e7-05e0-43ba-b377-ed5b4c88cca1"), "Player3@gmail.com", null, "Player 3 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("90e14dee-e677-4869-9869-a4a01154ce18"), "Player4@gmail.com", null, "Player 4 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("7163f8bc-aafa-4b3d-81d8-f1158759fdd6"), "Player32@gmail.com", null, "Player 32 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("54875180-9122-4825-9bfe-a102b7653cfd"), "Player5@gmail.com", null, "Player 5 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("247acd77-95e5-48ea-83b5-ebc250dfe304"), "Player14@gmail.com", null, "Player 14 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("52ea50ca-0aaf-429b-9319-afd8495ed046"), "Player21@gmail.com", null, "Player 21 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("85f29c08-0b6a-491e-a068-ab40f8e6268a"), "Player24@gmail.com", null, "Player 24 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("d8037002-3a6a-42ff-878f-ee12ae67bf72"), "Player26@gmail.com", null, "Player 26 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("3867fc7a-7e67-4b9e-8bbc-20c05520742c"), "Player29@gmail.com", null, "Player 29 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("c844f890-8a6b-48fa-8c78-b7d64efa3812"), "Player30@gmail.com", null, "Player 30 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("5681cdba-d364-40bf-a748-45026c7f7487"), "Player33@gmail.com", null, "Player 33 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("acdcc1d4-9bbf-477f-93ce-01b65470ec2e"), "Player11@gmail.com", null, "Player 11 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("d114b214-3c3d-4678-843e-874401c6a7ac"), "Player27@gmail.com", null, "Player 27 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("d3f1f268-7210-401e-bb8f-fc7bed310b7f"), "Player22@gmail.com", null, "Player 22 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("cc500e6c-e73b-446e-bf4c-22e1e5bdb798"), "Player17@gmail.com", null, "Player 17 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("c2748a63-2445-4366-af48-31d957ddcbef"), "Player10@gmail.com", null, "Player 10 ", "user", "(47) 99630-5948", new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("dd5dac2b-ed5d-4086-8c1a-f933d7a7cb1a"), "Player12@gmail.com", null, "Player 12 ", "user", "(47) 99630-5948", new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("fe0b1c93-482d-44c0-95c0-af7ed7221d0e"), "Player15@gmail.com", null, "Player 15 ", "user", "(47) 99630-5948", new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("6af444e3-b7cb-4313-8023-4a63c60caf3c"), "Player18@gmail.com", null, "Player 18 ", "user", "(47) 99630-5948", new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("b65d4603-5227-4b2e-8376-89cd0e7cf796"), "Player19@gmail.com", null, "Player 19 ", "user", "(47) 99630-5948", new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("ee7d24eb-a2b9-4ef5-b59a-b8b3f20267fd"), "Player20@gmail.com", null, "Player 20 ", "user", "(47) 99630-5948", new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("b3a0ec5c-7e7d-4342-8b54-d259852deaa9"), "Player23@gmail.com", null, "Player 23 ", "user", "(47) 99630-5948", new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("d4f34070-6f45-4c92-aed8-a6dbbad14bb4"), "Player25@gmail.com", null, "Player 25 ", "user", "(47) 99630-5948", new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("7364cf35-41c1-40a2-80dd-87ecbfa2f3ec"), "Player28@gmail.com", null, "Player 28 ", "user", "(47) 99630-5948", new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("7024774d-f6a9-420c-a99e-2670c912dce1"), "Player31@gmail.com", null, "Player 31 ", "user", "(47) 99630-5948", new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("aa9d9ab1-146c-44f9-b923-fb1e7dd89160"), "Player2@gmail.com", null, "Player 2 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("408a9b1b-6a63-4ba1-978f-136d146fb77e"), "Player6@gmail.com", null, "Player 6 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("b271f1ef-5113-4e33-b5f4-18141fd45632"), "Player7@gmail.com", null, "Player 7 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("95326ec0-f70a-4bc4-9121-3fbc8a2a2ab7"), "Player8@gmail.com", null, "Player 8 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("a48ba5bb-20b9-4616-8d21-78744db8c5e4"), "Player9@gmail.com", null, "Player 9 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("9b0a3902-90cf-4ce9-8a31-165c57bd4ba5"), "Player13@gmail.com", null, "Player 13 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("7eba9a7b-696f-4af6-8a6d-1e6b99dba9c5"), "Player16@gmail.com", null, "Player 16 ", "user", "(47) 99630-5948", new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("9192580f-8ac2-48ae-a285-ecdaa9b37f2e"), "Player34@gmail.com", null, "Player 34 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "ImageUrl", "Name", "Password", "Phone", "PositionId", "Role" },
                values: new object[] { new Guid("8e2a7813-4d67-43cd-94bf-bd6bc0e2f4b2"), "Player35@gmail.com", null, "Player 35 ", "user", "(47) 99630-5948", new Guid("294140b3-0f39-49fd-9160-16856a975c6b"), "user" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PositionId",
                table: "Users",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("294140b3-0f39-49fd-9160-16856a975c6b"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("4f6c0760-3487-4b35-a04a-d559a534f51b"));

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: new Guid("b04304f2-391e-415d-98a4-4d79057e8c60"));

            migrationBuilder.CreateTable(
                name: "SystemUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 80, nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PositionId = table.Column<Guid>(type: "TEXT", nullable: false)
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
    }
}
