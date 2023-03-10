// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolMenu.DAL;

#nullable disable

namespace SchoolMenu.DAL.Migrations
{
    [DbContext(typeof(SchoolMenuContext))]
    [Migration("20221216112425_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DayMenuMeal", b =>
                {
                    b.Property<Guid>("DayMenusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MealsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DayMenusId", "MealsId");

                    b.HasIndex("MealsId");

                    b.ToTable("DayMenuMeal");
                });

            modelBuilder.Entity("MealProduct", b =>
                {
                    b.Property<Guid>("MealsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MealsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("MealProduct");
                });

            modelBuilder.Entity("SchoolMenu.DAL.Entities.DayMenu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MenuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("WeekDay")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("DayMenus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d3a414f8-3ae5-4afc-95d5-d093e4131f47"),
                            MenuId = new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"),
                            WeekDay = 0
                        },
                        new
                        {
                            Id = new Guid("b65f2cfe-e142-4a42-8632-cd54cc2c7c57"),
                            MenuId = new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"),
                            WeekDay = 1
                        },
                        new
                        {
                            Id = new Guid("abeb0367-ab7e-465b-9ed5-b2ed55808234"),
                            MenuId = new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"),
                            WeekDay = 2
                        },
                        new
                        {
                            Id = new Guid("a5ef10f8-fa47-4f9f-a46b-07088573ea85"),
                            MenuId = new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"),
                            WeekDay = 3
                        },
                        new
                        {
                            Id = new Guid("75b1bd80-7113-4565-937c-0fcbe3db5fec"),
                            MenuId = new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"),
                            WeekDay = 4
                        },
                        new
                        {
                            Id = new Guid("5ffcad55-46d5-4846-bb8e-b02f49623fe2"),
                            MenuId = new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"),
                            WeekDay = 5
                        },
                        new
                        {
                            Id = new Guid("9dde9792-9d9f-4233-9836-290ae71e9864"),
                            MenuId = new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"),
                            WeekDay = 6
                        });
                });

            modelBuilder.Entity("SchoolMenu.DAL.Entities.DayMenuMeal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DayMenuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MealId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DayMenuId");

                    b.HasIndex("MealId");

                    b.ToTable("DayMenuMeals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("96b4d8dc-0d7d-4537-89f1-83563080167b"),
                            DayMenuId = new Guid("d3a414f8-3ae5-4afc-95d5-d093e4131f47"),
                            MealId = new Guid("c0bd97a3-4d2e-49d9-90fb-b2826c376172")
                        });
                });

            modelBuilder.Entity("SchoolMenu.DAL.Entities.Meal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c0bd97a3-4d2e-49d9-90fb-b2826c376172"),
                            Name = "Summer Asian Slaw",
                            Price = 2.20m,
                            RecipeId = new Guid("983dc06f-936f-4f1c-8934-59e4d4fb7276")
                        });
                });

            modelBuilder.Entity("SchoolMenu.DAL.Entities.MealProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MealId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MealId");

                    b.HasIndex("ProductId");

                    b.ToTable("MealProducts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f84ed766-10d1-4c3f-987f-16e9b690aa90"),
                            MealId = new Guid("c0bd97a3-4d2e-49d9-90fb-b2826c376172"),
                            ProductId = new Guid("dfcbbe34-5690-486e-b1d1-f1222c453c42")
                        },
                        new
                        {
                            Id = new Guid("a0598a8f-19b9-477b-808f-816cfddec4e8"),
                            MealId = new Guid("c0bd97a3-4d2e-49d9-90fb-b2826c376172"),
                            ProductId = new Guid("7b3f8ee9-c885-4332-8ccc-3d02cfe26173")
                        },
                        new
                        {
                            Id = new Guid("e7278a46-3723-47af-8498-a2f522d6a570"),
                            MealId = new Guid("c0bd97a3-4d2e-49d9-90fb-b2826c376172"),
                            ProductId = new Guid("a77b973f-412e-4d8f-920f-d548ace92be1")
                        });
                });

            modelBuilder.Entity("SchoolMenu.DAL.Entities.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DayMenuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"),
                            DayMenuId = new Guid("00000000-0000-0000-0000-000000000000"),
                            SchoolName = "Lviv school"
                        });
                });

            modelBuilder.Entity("SchoolMenu.DAL.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dfcbbe34-5690-486e-b1d1-f1222c453c42"),
                            Name = "Cabbage",
                            ProductPrice = 1.0m
                        },
                        new
                        {
                            Id = new Guid("7b3f8ee9-c885-4332-8ccc-3d02cfe26173"),
                            Name = "Pepper",
                            ProductPrice = 0.4m
                        },
                        new
                        {
                            Id = new Guid("a77b973f-412e-4d8f-920f-d548ace92be1"),
                            Name = "Peach",
                            ProductPrice = 1.6m
                        });
                });

            modelBuilder.Entity("SchoolMenu.DAL.Entities.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("983dc06f-936f-4f1c-8934-59e4d4fb7276"),
                            Content = "Make the dressing: In a small bowl, whisk together the cashew butter, miso paste, lime juice, sesame oil, and ginger. Whisk in enough water to create a drizzable consistency. Set aside.\r\nIn a dry cast-iron skillet over medium heat, char the peppers whole, rotating until the edges have a little char, about 2 minutes per side. Remove. When cool to the touch, slice in half lengthwise, remove the stem, ribbing, and seeds and slice horizontally into thin strips.\r\nIn a large bowl, combine the cabbage, peppers, scallions, cilantro, basil, chiles, and ¾ of the dressing. Toss until combined. Add the remaining dressing, if desired, and season to taste with a few pinches of sea salt. Serve topped with the toasted nuts, seeds, and sliced peaches."
                        });
                });

            modelBuilder.Entity("DayMenuMeal", b =>
                {
                    b.HasOne("SchoolMenu.DAL.Entities.DayMenu", null)
                        .WithMany()
                        .HasForeignKey("DayMenusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolMenu.DAL.Entities.Meal", null)
                        .WithMany()
                        .HasForeignKey("MealsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MealProduct", b =>
                {
                    b.HasOne("SchoolMenu.DAL.Entities.Meal", null)
                        .WithMany()
                        .HasForeignKey("MealsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolMenu.DAL.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolMenu.DAL.Entities.DayMenu", b =>
                {
                    b.HasOne("SchoolMenu.DAL.Entities.Menu", "Menu")
                        .WithMany("Days")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("SchoolMenu.DAL.Entities.DayMenuMeal", b =>
                {
                    b.HasOne("SchoolMenu.DAL.Entities.DayMenu", "DayMenu")
                        .WithMany()
                        .HasForeignKey("DayMenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolMenu.DAL.Entities.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DayMenu");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("SchoolMenu.DAL.Entities.Meal", b =>
                {
                    b.HasOne("SchoolMenu.DAL.Entities.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("SchoolMenu.DAL.Entities.MealProduct", b =>
                {
                    b.HasOne("SchoolMenu.DAL.Entities.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolMenu.DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meal");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SchoolMenu.DAL.Entities.Menu", b =>
                {
                    b.Navigation("Days");
                });
#pragma warning restore 612, 618
        }
    }
}
