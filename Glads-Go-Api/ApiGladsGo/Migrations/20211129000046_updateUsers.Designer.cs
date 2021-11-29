﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechWeekFatecSul.Data;

namespace TechWeekFatecSul.Migrations
{
    [DbContext(typeof(TechWeekFatecSulContext))]
    [Migration("20211129000046_updateUsers")]
    partial class updateUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("ApiMySql.Data.Entities.Positions.Position", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(80);

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(4);

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3f2c9509-823a-4af9-bb55-e8d560a504f6"),
                            Name = "Wide Reciver",
                            ShortName = "WR"
                        },
                        new
                        {
                            Id = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Name = "Quarterback",
                            ShortName = "QB"
                        },
                        new
                        {
                            Id = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Name = "Running Back",
                            ShortName = "RB"
                        });
                });

            modelBuilder.Entity("ApiMySql.Data.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressNumber")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CEP")
                        .HasColumnType("TEXT");

                    b.Property<string>("CPF")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(80);

                    b.Property<string>("Height")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(80);

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<Guid>("PositionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RG")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<string>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("be9a0f7b-551a-49b6-851f-c033d5146802"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player1@gmail.com",
                            Name = "Player 1 ",
                            Password = "adm",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("3f2c9509-823a-4af9-bb55-e8d560a504f6"),
                            Role = "adm"
                        },
                        new
                        {
                            Id = new Guid("20183200-0a19-4377-b933-a7a9e89c7a9f"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player2@gmail.com",
                            Name = "Player 2 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("116150be-de26-4ad3-9368-fd7d4a7dac15"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player3@gmail.com",
                            Name = "Player 3 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("6462d163-d8e3-490d-8425-d1d8ba2f035b"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player4@gmail.com",
                            Name = "Player 4 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("68afb65a-cb2c-4dee-9c2a-84974daf3730"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player5@gmail.com",
                            Name = "Player 5 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("27384ce3-18e4-48bc-83fc-ae9169e647e4"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player6@gmail.com",
                            Name = "Player 6 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("b37f1f10-91cb-48df-ae75-949fab51de55"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player7@gmail.com",
                            Name = "Player 7 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("0f4b6b8c-4d9b-4c74-9036-ea318ac4fefe"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player8@gmail.com",
                            Name = "Player 8 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("f3b66971-51ac-4d75-906c-f40fa2bd7707"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player9@gmail.com",
                            Name = "Player 9 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("afcdb200-2217-4b09-a636-d1bdd478ecd4"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player10@gmail.com",
                            Name = "Player 10 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("3f2c9509-823a-4af9-bb55-e8d560a504f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("151349ff-3f08-48d8-86d7-df38a1332c00"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player11@gmail.com",
                            Name = "Player 11 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("f0239048-df82-44bb-b225-241ccc5b4eaa"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player12@gmail.com",
                            Name = "Player 12 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("3f2c9509-823a-4af9-bb55-e8d560a504f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("30ccc769-4144-4925-84e1-67f9ad546316"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player13@gmail.com",
                            Name = "Player 13 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("50fe70f9-e010-4937-8483-830a528e021d"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player14@gmail.com",
                            Name = "Player 14 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("d6707047-0612-422a-bc3b-bee92aef9b6b"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player15@gmail.com",
                            Name = "Player 15 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("3f2c9509-823a-4af9-bb55-e8d560a504f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("6d21aba7-0682-46e6-8819-29a4734bf2f7"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player16@gmail.com",
                            Name = "Player 16 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("c7ced3b8-8c7d-43f1-8298-24592e3dad7e"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player17@gmail.com",
                            Name = "Player 17 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("9b1cbbd6-e87a-4aa6-ad48-766bddff3c86"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player18@gmail.com",
                            Name = "Player 18 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("3f2c9509-823a-4af9-bb55-e8d560a504f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("b59fb499-86a6-49a3-bdd1-fd1be6ab8650"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player19@gmail.com",
                            Name = "Player 19 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("3f2c9509-823a-4af9-bb55-e8d560a504f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("44142be2-3bbe-419a-8a17-bf083e923b16"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player20@gmail.com",
                            Name = "Player 20 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("3f2c9509-823a-4af9-bb55-e8d560a504f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("fa35eb75-6726-47ea-8126-31a5a02de8b5"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player21@gmail.com",
                            Name = "Player 21 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("33de5c31-1795-4249-a0ed-85dcb5e6cce8"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player22@gmail.com",
                            Name = "Player 22 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("3be4f0f3-a077-4963-9742-1b528cd3cc88"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player23@gmail.com",
                            Name = "Player 23 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("3f2c9509-823a-4af9-bb55-e8d560a504f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("9891d959-0bb8-4f08-bdb1-a936fe42f8ac"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player24@gmail.com",
                            Name = "Player 24 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("e184ee8b-307e-474e-ac11-169aebe2e28b"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player25@gmail.com",
                            Name = "Player 25 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("3f2c9509-823a-4af9-bb55-e8d560a504f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("9d97607d-9f73-4132-9f77-e9f5ebacb7af"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player26@gmail.com",
                            Name = "Player 26 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("0a9f7b6a-5104-4da5-830d-8e2c5a207b75"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player27@gmail.com",
                            Name = "Player 27 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("28ac0fc7-be7e-49ad-bdc4-29d000a424fe"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player28@gmail.com",
                            Name = "Player 28 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("3f2c9509-823a-4af9-bb55-e8d560a504f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("2920c616-a844-45ea-b82a-79e177d9f90c"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player29@gmail.com",
                            Name = "Player 29 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("0763bdaa-678a-4167-9cd6-b540d6c7fc3b"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player30@gmail.com",
                            Name = "Player 30 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("b5480cc6-083c-4839-b3a2-83744160fa56"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player31@gmail.com",
                            Name = "Player 31 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("3f2c9509-823a-4af9-bb55-e8d560a504f6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("d815d8d9-816c-49be-8572-afd2d7131839"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player32@gmail.com",
                            Name = "Player 32 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("e17bd24a-78fd-436a-8aa4-0174e1ad855f"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player33@gmail.com",
                            Name = "Player 33 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("96ee4001-3afc-48c0-af2a-b188744b117b"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player34@gmail.com",
                            Name = "Player 34 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("b9863b0e-2c0f-4ff1-8443-3cabb1a5afec"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player35@gmail.com",
                            Name = "Player 35 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("f67bfd73-a8e4-4cec-af67-abce0d0f7fc6"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("caa42594-230c-4764-b0a6-cded765a05e1"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player36@gmail.com",
                            Name = "Player 36 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("940f59a6-9c40-424e-9ace-1e4c3ea7d8b9"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player37@gmail.com",
                            Name = "Player 37 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("e8532e96-909a-47a3-8588-39c253382b4f"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player38@gmail.com",
                            Name = "Player 38 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("24a3875d-90ca-46fb-b089-b2eea6ee2fdb"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player39@gmail.com",
                            Name = "Player 39 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
                            Role = "user"
                        },
                        new
                        {
                            Id = new Guid("330ca865-eb98-405f-a9a5-91f4fb919282"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Player40@gmail.com",
                            Name = "Player 40 ",
                            Password = "user",
                            Phone = "(47) 99630-5948",
                            PositionId = new Guid("87b3011f-2b73-411e-8a90-9e407ac148e8"),
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
                });
#pragma warning restore 612, 618
        }
    }
}