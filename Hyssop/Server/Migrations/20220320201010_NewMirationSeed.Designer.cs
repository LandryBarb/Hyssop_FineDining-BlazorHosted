﻿// <auto-generated />
using Hyssop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hyssop.Server.Migrations
{
    [DbContext(typeof(HyssopDbContext))]
    [Migration("20220320201010_NewMirationSeed")]
    partial class NewMirationSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hyssop.Shared.Menu.MealType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MealTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "../images/background/bg1.jpg",
                            Name = "Breakfast",
                            Url = "breakfast"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "../images/background/bg1.jpg",
                            Name = "Lunch",
                            Url = "lunch"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "../images/background/bg1.jpg",
                            Name = "Dinner",
                            Url = "dinner"
                        });
                });

            modelBuilder.Entity("Hyssop.Shared.Menu.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MealTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Special")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MealTypeId");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Doctrine—what Christians believe—directly influences how they live. The biblical truths about God, humanity, and the world are not merely about knowing more—they are also about loving God and making sense of this life and the life to come. But what happens when there is disparity between ther—putting the truths of God’s word on display for all the world to see",
                            ImageUrl = "../images/products/burger1.jpg",
                            MealTypeId = 3,
                            Name = "Beyond Burger",
                            Special = true
                        },
                        new
                        {
                            Id = 2,
                            Description = "Doctrine—what Christians believe—directly influences how they live. The biblical truths about God, humanity, and the world are not merely about knowing more—they are also about loving God and making sense of this life and the life to come. But what happens when there is disparity between what believers confess and how they live? In his latest book Do You Believe tor and Father—putting the truths of God’s word on display for all the world to see",
                            ImageUrl = "../images/products/burger2.jpg",
                            MealTypeId = 3,
                            Name = "Street Tacos",
                            Special = true
                        });
                });

            modelBuilder.Entity("Hyssop.Shared.Menu.MenuItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MenuItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Beef"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Chicken"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pork"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Beyond Meat"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Impossible Meat"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Tempeh"
                        });
                });

            modelBuilder.Entity("Hyssop.Shared.Menu.MenuItemVariant", b =>
                {
                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("MenuItemTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("NormalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MenuItemId", "MenuItemTypeId");

                    b.HasIndex("MenuItemTypeId");

                    b.ToTable("MenuItemVariants");

                    b.HasData(
                        new
                        {
                            MenuItemId = 1,
                            MenuItemTypeId = 1,
                            NormalPrice = 0m,
                            Price = 9.99m
                        },
                        new
                        {
                            MenuItemId = 1,
                            MenuItemTypeId = 2,
                            NormalPrice = 0m,
                            Price = 9.99m
                        },
                        new
                        {
                            MenuItemId = 1,
                            MenuItemTypeId = 4,
                            NormalPrice = 9.99m,
                            Price = 11.99m
                        },
                        new
                        {
                            MenuItemId = 1,
                            MenuItemTypeId = 5,
                            NormalPrice = 9.99m,
                            Price = 11.99m
                        },
                        new
                        {
                            MenuItemId = 1,
                            MenuItemTypeId = 6,
                            NormalPrice = 9.99m,
                            Price = 11.99m
                        },
                        new
                        {
                            MenuItemId = 2,
                            MenuItemTypeId = 1,
                            NormalPrice = 0m,
                            Price = 9.99m
                        },
                        new
                        {
                            MenuItemId = 2,
                            MenuItemTypeId = 2,
                            NormalPrice = 0m,
                            Price = 9.99m
                        },
                        new
                        {
                            MenuItemId = 2,
                            MenuItemTypeId = 4,
                            NormalPrice = 9.99m,
                            Price = 10.99m
                        },
                        new
                        {
                            MenuItemId = 2,
                            MenuItemTypeId = 5,
                            NormalPrice = 9.99m,
                            Price = 10.99m
                        },
                        new
                        {
                            MenuItemId = 2,
                            MenuItemTypeId = 6,
                            NormalPrice = 9.99m,
                            Price = 10.99m
                        });
                });

            modelBuilder.Entity("Hyssop.Shared.Menu.MenuItem", b =>
                {
                    b.HasOne("Hyssop.Shared.Menu.MealType", "MealType")
                        .WithMany()
                        .HasForeignKey("MealTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MealType");
                });

            modelBuilder.Entity("Hyssop.Shared.Menu.MenuItemVariant", b =>
                {
                    b.HasOne("Hyssop.Shared.Menu.MenuItem", "MenuItem")
                        .WithMany("MenuItemVariants")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hyssop.Shared.Menu.MenuItemType", "MenuItemType")
                        .WithMany()
                        .HasForeignKey("MenuItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("MenuItemType");
                });

            modelBuilder.Entity("Hyssop.Shared.Menu.MenuItem", b =>
                {
                    b.Navigation("MenuItemVariants");
                });
#pragma warning restore 612, 618
        }
    }
}