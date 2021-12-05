﻿// <auto-generated />
using System;
using BoardGames_FinalProject.Models.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoardGames_FinalProject.Migrations
{
    [DbContext(typeof(BoardGameContext))]
    partial class BoardGameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoardGames_FinalProject.Models.BoardGame", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("max_players")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("min_age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("min_players")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BoardGames");

                    b.HasData(
                        new
                        {
                            ID = "TAAifFP590",
                            max_players = "4",
                            min_age = "10",
                            min_players = "2",
                            name = "Root",
                            price = "50.00"
                        },
                        new
                        {
                            ID = "yqR4PtpO8X",
                            max_players = "5",
                            min_age = "14",
                            min_players = "1",
                            name = "Scythe",
                            price = "54.92"
                        },
                        new
                        {
                            ID = "5H5JS0KLzK",
                            max_players = "5",
                            min_age = "10",
                            min_players = "1",
                            name = "Wingspan",
                            price = "47.99"
                        },
                        new
                        {
                            ID = "RLlDWHh7hR",
                            max_players = "4",
                            min_age = "12",
                            min_players = "1",
                            name = "Gloomhaven",
                            price = "99.99"
                        },
                        new
                        {
                            ID = "fDn9rQjH9O",
                            max_players = "5",
                            min_age = "12",
                            min_players = "1",
                            name = "Terraforming Mars",
                            price = "49.83"
                        },
                        new
                        {
                            ID = "i5Oqu5VZgP",
                            max_players = "4",
                            min_age = "8",
                            min_players = "2",
                            name = "Azul",
                            price = "24.97"
                        },
                        new
                        {
                            ID = "7NYbgH2Z2I",
                            max_players = "6",
                            min_age = "13",
                            min_players = "1",
                            name = "Viticulture: Essential Edition",
                            price = "41.97"
                        },
                        new
                        {
                            ID = "6FmFeux5xH",
                            max_players = "4",
                            min_age = "8",
                            min_players = "2",
                            name = "Pandemic",
                            price = "20.97"
                        },
                        new
                        {
                            ID = "kPDxpJZ8PD",
                            max_players = "4",
                            min_age = "13",
                            min_players = "1",
                            name = "Spirit Island",
                            price = "74.95"
                        },
                        new
                        {
                            ID = "j8LdPFmePE",
                            max_players = "2",
                            min_age = "10",
                            min_players = "2",
                            name = "7 Wonders Duel",
                            price = "17.50"
                        },
                        new
                        {
                            ID = "OF145SrX44",
                            max_players = "7",
                            min_age = "10",
                            min_players = "2",
                            name = "7 Wonders",
                            price = "44.99"
                        },
                        new
                        {
                            ID = "GP7Y2xOUzj",
                            max_players = "8",
                            min_age = "10",
                            min_players = "2",
                            name = "Codenames",
                            price = "13.49"
                        },
                        new
                        {
                            ID = "VNBC6yq1WO",
                            max_players = "4",
                            min_age = "12",
                            min_players = "2",
                            name = "The Castles of Burgundy",
                            price = "0.00"
                        },
                        new
                        {
                            ID = "oGVgRSAKwX",
                            max_players = "5",
                            min_age = "7",
                            min_players = "2",
                            name = "Carcassonne",
                            price = "31.49"
                        },
                        new
                        {
                            ID = "O0G8z5Wgz1",
                            max_players = "4",
                            min_age = "10",
                            min_players = "2",
                            name = "Splendor",
                            price = "25.19"
                        },
                        new
                        {
                            ID = "mce5HZPnF5",
                            max_players = "4",
                            min_age = "13",
                            min_players = "2",
                            name = "Pandemic Legacy: Season 1",
                            price = "41.99"
                        },
                        new
                        {
                            ID = "FCuXPSfhDR",
                            max_players = "5",
                            min_age = "13",
                            min_players = "2",
                            name = "Concordia",
                            price = "46.99"
                        },
                        new
                        {
                            ID = "8xos44jY7Q",
                            max_players = "4",
                            min_age = "14",
                            min_players = "1",
                            name = "Everdell",
                            price = "48.00"
                        },
                        new
                        {
                            ID = "AuBvbISHR6",
                            max_players = "5",
                            min_age = "8",
                            min_players = "2",
                            name = "Ticket to Ride",
                            price = "39.97"
                        },
                        new
                        {
                            ID = "3IPVIROfvl",
                            max_players = "4",
                            min_age = "14",
                            min_players = "2",
                            name = "Brass: Birmingham",
                            price = "69.95"
                        },
                        new
                        {
                            ID = "OIXt3DmJU0",
                            max_players = "4",
                            min_age = "10",
                            min_players = "3",
                            name = "Catan",
                            price = "29.99"
                        },
                        new
                        {
                            ID = "M7r9tO1GbX",
                            max_players = "4",
                            min_age = "10",
                            min_players = "2",
                            name = "The Quacks of Quedlinburg",
                            price = "39.99"
                        },
                        new
                        {
                            ID = "9iBOPn3lES",
                            max_players = "2",
                            min_age = "8",
                            min_players = "2",
                            name = "Patchwork",
                            price = "15.99"
                        },
                        new
                        {
                            ID = "E4ELA8cG85",
                            max_players = "4",
                            min_age = "14",
                            min_players = "2",
                            name = "Race for the Galaxy",
                            price = "23.99"
                        },
                        new
                        {
                            ID = "VibNUMwsqr",
                            max_players = "4",
                            min_age = "8",
                            min_players = "2",
                            name = "Santorini",
                            price = "27.12"
                        });
                });

            modelBuilder.Entity("BoardGames_FinalProject.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BoardGames_FinalProject.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BoardGames_FinalProject.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardGames_FinalProject.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BoardGames_FinalProject.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
