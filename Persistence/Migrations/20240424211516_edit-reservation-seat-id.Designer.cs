﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contexts;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20240424211516_edit-reservation-seat-id")]
    partial class editreservationseatid
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<Guid>("SeatId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("SeatId");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2")
                        .HasColumnName("Time");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.ToTable("Reservations", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("Capacity");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Rooms", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"),
                            Capacity = 8,
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8494),
                            Name = "Salon 1"
                        },
                        new
                        {
                            Id = new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"),
                            Capacity = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Salon 2"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Seat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<bool>("IsReserved")
                        .HasColumnType("bit")
                        .HasColumnName("IsReserved");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<Guid>("TableId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TableId");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("Seats", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("caef130f-19e4-4c56-ac2e-4e7663c77903"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "1A",
                            TableId = new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd")
                        },
                        new
                        {
                            Id = new Guid("15d5e543-844d-4fe6-a273-db0d2c1a96b6"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "1B",
                            TableId = new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd")
                        },
                        new
                        {
                            Id = new Guid("89a2e1bf-6347-41b8-b3fb-b6bc33e93db8"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "2A",
                            TableId = new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0")
                        },
                        new
                        {
                            Id = new Guid("23b94c8d-5e8c-4fcb-97ab-acaa9528a02d"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "2B",
                            TableId = new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0")
                        },
                        new
                        {
                            Id = new Guid("72ed544d-fe60-4393-aa7e-cb730119c49e"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "3A",
                            TableId = new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237")
                        },
                        new
                        {
                            Id = new Guid("a4169076-6678-4eac-a950-f0f19e4953f5"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "3B",
                            TableId = new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237")
                        },
                        new
                        {
                            Id = new Guid("862ada42-60cc-4109-959e-5dd3a5ebe391"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "4A",
                            TableId = new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6")
                        },
                        new
                        {
                            Id = new Guid("4290b5b5-e8d6-44f6-aa58-675c3fd19916"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "4B",
                            TableId = new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6")
                        },
                        new
                        {
                            Id = new Guid("1a1e29e0-d086-451b-923b-9ce56e9200f4"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "5A",
                            TableId = new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e")
                        },
                        new
                        {
                            Id = new Guid("83811700-07f4-483d-88ad-f95ff7b93120"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "5B",
                            TableId = new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e")
                        },
                        new
                        {
                            Id = new Guid("c8a5d646-db65-45c4-a31c-93dd05bcd9b2"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "6A",
                            TableId = new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c")
                        },
                        new
                        {
                            Id = new Guid("763312a3-305c-42e0-b2fc-923066298a97"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "6B",
                            TableId = new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c")
                        },
                        new
                        {
                            Id = new Guid("7ac7adea-e04f-4ad3-b349-964d28b3bc27"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "7A",
                            TableId = new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c")
                        },
                        new
                        {
                            Id = new Guid("fef0ba82-4e8f-43cb-bbc5-6a51e185c80d"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "7B",
                            TableId = new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c")
                        },
                        new
                        {
                            Id = new Guid("9c77540d-c6c1-44d1-9264-abe06003c7be"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "8A",
                            TableId = new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a")
                        },
                        new
                        {
                            Id = new Guid("37571e34-a8f0-4cb4-b778-07374aa9197a"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "8B",
                            TableId = new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a")
                        },
                        new
                        {
                            Id = new Guid("b4247322-7880-4672-af56-1548e39eb445"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "1A",
                            TableId = new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015")
                        },
                        new
                        {
                            Id = new Guid("1d43e535-1622-4528-b29f-6911dc919f41"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "1B",
                            TableId = new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015")
                        },
                        new
                        {
                            Id = new Guid("66513f72-c4ce-4c27-8a68-083ef98f6272"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "2A",
                            TableId = new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2")
                        },
                        new
                        {
                            Id = new Guid("a0e4386d-f5d6-4313-92d5-3bcd37698a08"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "2B",
                            TableId = new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2")
                        },
                        new
                        {
                            Id = new Guid("06d90e0f-46e2-466e-8e33-d03328dd6caa"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "3A",
                            TableId = new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97")
                        },
                        new
                        {
                            Id = new Guid("eabd269d-f1ea-47d2-9581-3335e3b6eff9"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "3B",
                            TableId = new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97")
                        },
                        new
                        {
                            Id = new Guid("6981fdce-2b22-4b9b-be1f-412ce1aa216c"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "4A",
                            TableId = new Guid("4953a8fa-782e-474d-a556-47a225111a20")
                        },
                        new
                        {
                            Id = new Guid("5f55c452-66d0-4e2d-9a6b-2b8853fb84f8"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "4B",
                            TableId = new Guid("4953a8fa-782e-474d-a556-47a225111a20")
                        },
                        new
                        {
                            Id = new Guid("143c5800-7219-4607-8a39-2d5653593787"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "5A",
                            TableId = new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9")
                        },
                        new
                        {
                            Id = new Guid("9fa5bbe3-0d2d-4155-919c-1aead14fdf86"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReserved = false,
                            Name = "5B",
                            TableId = new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9")
                        });
                });

            modelBuilder.Entity("Domain.Entities.Table", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<int>("Number")
                        .HasColumnType("int")
                        .HasColumnName("Number");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Tables", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8621),
                            Number = 1,
                            RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584")
                        },
                        new
                        {
                            Id = new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8624),
                            Number = 2,
                            RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584")
                        },
                        new
                        {
                            Id = new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8627),
                            Number = 3,
                            RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584")
                        },
                        new
                        {
                            Id = new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8630),
                            Number = 4,
                            RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584")
                        },
                        new
                        {
                            Id = new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8632),
                            Number = 5,
                            RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584")
                        },
                        new
                        {
                            Id = new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8633),
                            Number = 6,
                            RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584")
                        },
                        new
                        {
                            Id = new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8637),
                            Number = 7,
                            RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584")
                        },
                        new
                        {
                            Id = new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8639),
                            Number = 8,
                            RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584")
                        },
                        new
                        {
                            Id = new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8641),
                            Number = 1,
                            RoomId = new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6")
                        },
                        new
                        {
                            Id = new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8645),
                            Number = 2,
                            RoomId = new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6")
                        },
                        new
                        {
                            Id = new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8647),
                            Number = 3,
                            RoomId = new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6")
                        },
                        new
                        {
                            Id = new Guid("4953a8fa-782e-474d-a556-47a225111a20"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8649),
                            Number = 4,
                            RoomId = new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6")
                        },
                        new
                        {
                            Id = new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8650),
                            Number = 5,
                            RoomId = new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6")
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("81c202d7-de16-487b-8d2f-f76d7c6f5731"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8744),
                            FirstName = "Deneme",
                            LastName = "Deneme",
                            Password = "Deneme",
                            UserName = "Deneme"
                        },
                        new
                        {
                            Id = new Guid("0342d92e-7075-4e46-a873-a2df245635c8"),
                            CreatedDate = new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8746),
                            FirstName = "Deneme1",
                            LastName = "Deneme1",
                            Password = "Deneme1",
                            UserName = "Deneme1"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Seat", b =>
                {
                    b.HasOne("Domain.Entities.Table", "Table")
                        .WithMany("Seats")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Domain.Entities.Table", b =>
                {
                    b.HasOne("Domain.Entities.Room", "Room")
                        .WithMany("Tables")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Domain.Entities.Room", b =>
                {
                    b.Navigation("Tables");
                });

            modelBuilder.Entity("Domain.Entities.Table", b =>
                {
                    b.Navigation("Seats");
                });
#pragma warning restore 612, 618
        }
    }
}
