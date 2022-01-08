﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechWeekFatecSul.Data;

namespace ApiGladsGo.Migrations
{
    [DbContext(typeof(TechWeekFatecSulContext))]
    partial class TechWeekFatecSulContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("ApiMySql.Data.Entities.Positions.Position", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"),
                            Name = "Wide Reciver",
                            ShortName = "WR"
                        },
                        new
                        {
                            Id = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Name = "Quarterback",
                            ShortName = "QB"
                        },
                        new
                        {
                            Id = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Name = "Running Back",
                            ShortName = "RB"
                        });
                });

            modelBuilder.Entity("ApiMySql.Data.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CEP")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4");

                    b.Property<string>("Height")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<Guid>("PositionId")
                        .HasColumnType("char(36)");

                    b.Property<string>("RG")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Role")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Weight")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("687cd836-8c02-474c-bd8f-b710280b69c4"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player1@gmail.com",
                            Name = "Player 1 ",
                            Password = "adm",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"),
                            Role = "adm"
                        },
                        new
                        {
                            Id = new Guid("995c442a-a2f7-43a2-acbd-23ff4fff1e97"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player2@gmail.com",
                            Name = "Player 2 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("a913befe-73a6-44ca-8eed-68b28c8b6ca3"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player3@gmail.com",
                            Name = "Player 3 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("9970eab6-7272-4303-8a3e-58e3fd9f7c5a"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player4@gmail.com",
                            Name = "Player 4 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("0a6af707-410e-4138-b348-dd5dd1f129f9"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player5@gmail.com",
                            Name = "Player 5 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("4c6744c8-703c-4a30-8041-3eb68278bffd"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player6@gmail.com",
                            Name = "Player 6 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("d221ceab-1f97-4b7f-9a2e-fd6d13839633"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player7@gmail.com",
                            Name = "Player 7 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("22895d19-e670-4a2f-a085-3bb2670719f3"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player8@gmail.com",
                            Name = "Player 8 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("2d16d384-dcd5-415f-b612-eed24b0a5976"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player9@gmail.com",
                            Name = "Player 9 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("99c539b1-c5ba-4922-9c53-ee0e406898ea"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player10@gmail.com",
                            Name = "Player 10 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("3353afeb-5da2-4a80-9d4c-4fbb68b20069"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player11@gmail.com",
                            Name = "Player 11 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("ac69f199-6e4b-47ae-9126-7ea75b8c650c"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player12@gmail.com",
                            Name = "Player 12 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("b1fe228b-befd-4a0c-be4e-cc13f43ea2d9"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player13@gmail.com",
                            Name = "Player 13 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("2fcf5a9b-5cd4-4a77-b984-2a2ba1625bd7"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player14@gmail.com",
                            Name = "Player 14 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("ccff123b-384b-437f-b55c-8533836eed99"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player15@gmail.com",
                            Name = "Player 15 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("4c77b4e7-d01f-41b6-b83c-51692af2938d"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player16@gmail.com",
                            Name = "Player 16 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("72bdfe47-991c-485d-b205-e15222a836ad"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player17@gmail.com",
                            Name = "Player 17 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("126e3bb1-029e-4fa1-a913-e6361356ebed"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player18@gmail.com",
                            Name = "Player 18 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("2ab816f8-c3e5-4703-a015-a08648f19987"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player19@gmail.com",
                            Name = "Player 19 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("3bcdb5d1-7831-45a1-8606-ee2931900f74"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player20@gmail.com",
                            Name = "Player 20 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("bbe645ba-27e7-4e7a-8338-86a8f5cea1a8"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player21@gmail.com",
                            Name = "Player 21 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("436b8265-1c8c-4e37-b521-11c962a8d6c3"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player22@gmail.com",
                            Name = "Player 22 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("5ccb3297-dce8-471b-978b-08278a1db561"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player23@gmail.com",
                            Name = "Player 23 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("a405a5db-dd8b-4d52-8a24-163db93c13b5"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player24@gmail.com",
                            Name = "Player 24 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("b2950510-ff0a-4361-a311-36575423f1a9"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player25@gmail.com",
                            Name = "Player 25 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("4f77fe97-0ac6-44b4-9b56-4a75ea102b53"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player26@gmail.com",
                            Name = "Player 26 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("9ea521c1-1cb9-42a7-af15-43f365feb2ea"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player27@gmail.com",
                            Name = "Player 27 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("69110b3f-be1a-47e0-b564-1af46b4516e7"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player28@gmail.com",
                            Name = "Player 28 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("816fc028-b4b2-4369-b3cf-bd7e83c1d36d"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player29@gmail.com",
                            Name = "Player 29 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("3126e38e-9631-471d-a30a-3546f2929e0f"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player30@gmail.com",
                            Name = "Player 30 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("2306ed53-9f30-4d6d-876b-1d8fd90af4c1"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player31@gmail.com",
                            Name = "Player 31 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("68dcbe43-0847-4a24-b801-be580c4837f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("4578e563-1d0d-4d60-b8fd-62002c3fd148"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player32@gmail.com",
                            Name = "Player 32 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("79144993-b592-42c8-8fa9-539eb2397b75"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player33@gmail.com",
                            Name = "Player 33 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("2f3246a2-86bf-414b-bb2c-44d6ff82fd72"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player34@gmail.com",
                            Name = "Player 34 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("5ff18ab2-a9fa-4167-8470-7c6948a75a17"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player35@gmail.com",
                            Name = "Player 35 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("547b020f-8061-436d-9fc4-536e5913b56f"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("f224465b-2a5d-43db-b954-2db8d93040bc"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player36@gmail.com",
                            Name = "Player 36 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("d359a7c0-2fda-4510-8374-6a4fed668f2b"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player37@gmail.com",
                            Name = "Player 37 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("bda23413-a516-48e7-a450-2e2a456c127c"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player38@gmail.com",
                            Name = "Player 38 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("e528c727-6f9e-4ff7-a1a9-9223154163fd"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player39@gmail.com",
                            Name = "Player 39 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("263a9e0f-89a3-4df4-82b2-5232a49964f0"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player40@gmail.com",
                            Name = "Player 40 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("fe00c457-7530-4c58-a5a4-bae73cf65543"),
                            Role = "user"
                        });
                });

            modelBuilder.Entity("ApiMySql.Data.Entities.Users.User", b =>
                {
                    b.HasOne("ApiMySql.Data.Entities.Positions.Position", "Position")
                        .WithMany("Users")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("ApiMySql.Data.Entities.Positions.Position", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
