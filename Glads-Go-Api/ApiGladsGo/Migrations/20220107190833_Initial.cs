using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiGladsGo.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(80) CHARACTER SET utf8mb4", maxLength: 80, nullable: false),
                    ShortName = table.Column<string>(type: "varchar(4) CHARACTER SET utf8mb4", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(80) CHARACTER SET utf8mb4", maxLength: 80, nullable: false),
                    ImageUrl = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Phone = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(80) CHARACTER SET utf8mb4", maxLength: 80, nullable: true),
                    Password = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Role = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CPF = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    RG = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Height = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Weight = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CEP = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AddressNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PositionId = table.Column<Guid>(type: "char(36)", nullable: false)
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
                values: new object[] { new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"), "Wide Reciver", "WR" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), "Quarterback", "QB" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), "Running Back", "RB" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "AddressNumber", "BirthDate", "CEP", "CPF", "Email", "Height", "ImageUrl", "Name", "Password", "Phone", "PositionId", "RG", "Role", "Weight" },
                values: new object[,]
                {
                    { new Guid("687cd836-8c02-474c-bd8f-b710280b69c4"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player1@gmail.com", null, null, "Player 1 ", "adm", "(47) 99630-5948", new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"), null, "adm", null },
                    { new Guid("f224465b-2a5d-43db-b954-2db8d93040bc"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player36@gmail.com", null, null, "Player 36 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("d359a7c0-2fda-4510-8374-6a4fed668f2b"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player37@gmail.com", null, null, "Player 37 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("bda23413-a516-48e7-a450-2e2a456c127c"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player38@gmail.com", null, null, "Player 38 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("e528c727-6f9e-4ff7-a1a9-9223154163fd"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player39@gmail.com", null, null, "Player 39 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("263a9e0f-89a3-4df4-82b2-5232a49964f0"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player40@gmail.com", null, null, "Player 40 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("a913befe-73a6-44ca-8eed-68b28c8b6ca3"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player3@gmail.com", null, null, "Player 3 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null },
                    { new Guid("9970eab6-7272-4303-8a3e-58e3fd9f7c5a"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player4@gmail.com", null, null, "Player 4 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null },
                    { new Guid("4578e563-1d0d-4d60-b8fd-62002c3fd148"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player32@gmail.com", null, null, "Player 32 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("0a6af707-410e-4138-b348-dd5dd1f129f9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player5@gmail.com", null, null, "Player 5 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null },
                    { new Guid("2fcf5a9b-5cd4-4a77-b984-2a2ba1625bd7"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player14@gmail.com", null, null, "Player 14 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null },
                    { new Guid("bbe645ba-27e7-4e7a-8338-86a8f5cea1a8"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player21@gmail.com", null, null, "Player 21 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null },
                    { new Guid("a405a5db-dd8b-4d52-8a24-163db93c13b5"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player24@gmail.com", null, null, "Player 24 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null },
                    { new Guid("4f77fe97-0ac6-44b4-9b56-4a75ea102b53"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player26@gmail.com", null, null, "Player 26 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null },
                    { new Guid("816fc028-b4b2-4369-b3cf-bd7e83c1d36d"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player29@gmail.com", null, null, "Player 29 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null },
                    { new Guid("3126e38e-9631-471d-a30a-3546f2929e0f"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player30@gmail.com", null, null, "Player 30 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null },
                    { new Guid("79144993-b592-42c8-8fa9-539eb2397b75"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player33@gmail.com", null, null, "Player 33 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null },
                    { new Guid("3353afeb-5da2-4a80-9d4c-4fbb68b20069"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player11@gmail.com", null, null, "Player 11 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null },
                    { new Guid("9ea521c1-1cb9-42a7-af15-43f365feb2ea"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player27@gmail.com", null, null, "Player 27 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("436b8265-1c8c-4e37-b521-11c962a8d6c3"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player22@gmail.com", null, null, "Player 22 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("72bdfe47-991c-485d-b205-e15222a836ad"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player17@gmail.com", null, null, "Player 17 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("99c539b1-c5ba-4922-9c53-ee0e406898ea"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player10@gmail.com", null, null, "Player 10 ", "user", "(47) 99630-5948", new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"), null, "user", null },
                    { new Guid("ac69f199-6e4b-47ae-9126-7ea75b8c650c"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player12@gmail.com", null, null, "Player 12 ", "user", "(47) 99630-5948", new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"), null, "user", null },
                    { new Guid("ccff123b-384b-437f-b55c-8533836eed99"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player15@gmail.com", null, null, "Player 15 ", "user", "(47) 99630-5948", new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"), null, "user", null },
                    { new Guid("126e3bb1-029e-4fa1-a913-e6361356ebed"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player18@gmail.com", null, null, "Player 18 ", "user", "(47) 99630-5948", new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"), null, "user", null },
                    { new Guid("2ab816f8-c3e5-4703-a015-a08648f19987"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player19@gmail.com", null, null, "Player 19 ", "user", "(47) 99630-5948", new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"), null, "user", null },
                    { new Guid("3bcdb5d1-7831-45a1-8606-ee2931900f74"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player20@gmail.com", null, null, "Player 20 ", "user", "(47) 99630-5948", new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"), null, "user", null },
                    { new Guid("5ccb3297-dce8-471b-978b-08278a1db561"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player23@gmail.com", null, null, "Player 23 ", "user", "(47) 99630-5948", new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"), null, "user", null },
                    { new Guid("b2950510-ff0a-4361-a311-36575423f1a9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player25@gmail.com", null, null, "Player 25 ", "user", "(47) 99630-5948", new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"), null, "user", null },
                    { new Guid("69110b3f-be1a-47e0-b564-1af46b4516e7"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player28@gmail.com", null, null, "Player 28 ", "user", "(47) 99630-5948", new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"), null, "user", null },
                    { new Guid("2306ed53-9f30-4d6d-876b-1d8fd90af4c1"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player31@gmail.com", null, null, "Player 31 ", "user", "(47) 99630-5948", new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"), null, "user", null },
                    { new Guid("995c442a-a2f7-43a2-acbd-23ff4fff1e97"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player2@gmail.com", null, null, "Player 2 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("4c6744c8-703c-4a30-8041-3eb68278bffd"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player6@gmail.com", null, null, "Player 6 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("d221ceab-1f97-4b7f-9a2e-fd6d13839633"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player7@gmail.com", null, null, "Player 7 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("22895d19-e670-4a2f-a085-3bb2670719f3"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player8@gmail.com", null, null, "Player 8 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("2d16d384-dcd5-415f-b612-eed24b0a5976"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player9@gmail.com", null, null, "Player 9 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("b1fe228b-befd-4a0c-be4e-cc13f43ea2d9"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player13@gmail.com", null, null, "Player 13 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("4c77b4e7-d01f-41b6-b83c-51692af2938d"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player16@gmail.com", null, null, "Player 16 ", "user", "(47) 99630-5948", new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"), null, "user", null },
                    { new Guid("2f3246a2-86bf-414b-bb2c-44d6ff82fd72"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player34@gmail.com", null, null, "Player 34 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null },
                    { new Guid("5ff18ab2-a9fa-4167-8470-7c6948a75a17"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Player35@gmail.com", null, null, "Player 35 ", "user", "(47) 99630-5948", new Guid("547b020f-8061-436d-9fc4-536e5913b56f"), null, "user", null }
                });

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
