using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolMenu.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DayMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SchoolName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DayMenus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WeekDay = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DayMenus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DayMenuMeal",
                columns: table => new
                {
                    DayMenusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayMenuMeal", x => new { x.DayMenusId, x.MealsId });
                    table.ForeignKey(
                        name: "FK_DayMenuMeal_DayMenus_DayMenusId",
                        column: x => x.DayMenusId,
                        principalTable: "DayMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DayMenuMeal_Meals_MealsId",
                        column: x => x.MealsId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DayMenuMeals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DayMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayMenuMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DayMenuMeals_DayMenus_DayMenuId",
                        column: x => x.DayMenuId,
                        principalTable: "DayMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DayMenuMeals_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealProduct",
                columns: table => new
                {
                    MealsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealProduct", x => new { x.MealsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_MealProduct_Meals_MealsId",
                        column: x => x.MealsId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealProducts_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "DayMenuId", "SchoolName" },
                values: new object[] { new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"), new Guid("00000000-0000-0000-0000-000000000000"), "Lviv school" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "ProductPrice" },
                values: new object[,]
                {
                    { new Guid("7b3f8ee9-c885-4332-8ccc-3d02cfe26173"), "Pepper", 0.4m },
                    { new Guid("a77b973f-412e-4d8f-920f-d548ace92be1"), "Peach", 1.6m },
                    { new Guid("dfcbbe34-5690-486e-b1d1-f1222c453c42"), "Cabbage", 1.0m }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Content" },
                values: new object[] { new Guid("983dc06f-936f-4f1c-8934-59e4d4fb7276"), "Make the dressing: In a small bowl, whisk together the cashew butter, miso paste, lime juice, sesame oil, and ginger. Whisk in enough water to create a drizzable consistency. Set aside.\r\nIn a dry cast-iron skillet over medium heat, char the peppers whole, rotating until the edges have a little char, about 2 minutes per side. Remove. When cool to the touch, slice in half lengthwise, remove the stem, ribbing, and seeds and slice horizontally into thin strips.\r\nIn a large bowl, combine the cabbage, peppers, scallions, cilantro, basil, chiles, and ¾ of the dressing. Toss until combined. Add the remaining dressing, if desired, and season to taste with a few pinches of sea salt. Serve topped with the toasted nuts, seeds, and sliced peaches." });

            migrationBuilder.InsertData(
                table: "DayMenus",
                columns: new[] { "Id", "MenuId", "WeekDay" },
                values: new object[,]
                {
                    { new Guid("5ffcad55-46d5-4846-bb8e-b02f49623fe2"), new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"), 5 },
                    { new Guid("75b1bd80-7113-4565-937c-0fcbe3db5fec"), new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"), 4 },
                    { new Guid("9dde9792-9d9f-4233-9836-290ae71e9864"), new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"), 6 },
                    { new Guid("a5ef10f8-fa47-4f9f-a46b-07088573ea85"), new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"), 3 },
                    { new Guid("abeb0367-ab7e-465b-9ed5-b2ed55808234"), new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"), 2 },
                    { new Guid("b65f2cfe-e142-4a42-8632-cd54cc2c7c57"), new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"), 1 },
                    { new Guid("d3a414f8-3ae5-4afc-95d5-d093e4131f47"), new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Name", "Price", "RecipeId" },
                values: new object[] { new Guid("c0bd97a3-4d2e-49d9-90fb-b2826c376172"), "Summer Asian Slaw", 2.20m, new Guid("983dc06f-936f-4f1c-8934-59e4d4fb7276") });

            migrationBuilder.InsertData(
                table: "DayMenuMeals",
                columns: new[] { "Id", "DayMenuId", "MealId" },
                values: new object[] { new Guid("96b4d8dc-0d7d-4537-89f1-83563080167b"), new Guid("d3a414f8-3ae5-4afc-95d5-d093e4131f47"), new Guid("c0bd97a3-4d2e-49d9-90fb-b2826c376172") });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("a0598a8f-19b9-477b-808f-816cfddec4e8"), new Guid("c0bd97a3-4d2e-49d9-90fb-b2826c376172"), new Guid("7b3f8ee9-c885-4332-8ccc-3d02cfe26173") },
                    { new Guid("e7278a46-3723-47af-8498-a2f522d6a570"), new Guid("c0bd97a3-4d2e-49d9-90fb-b2826c376172"), new Guid("a77b973f-412e-4d8f-920f-d548ace92be1") },
                    { new Guid("f84ed766-10d1-4c3f-987f-16e9b690aa90"), new Guid("c0bd97a3-4d2e-49d9-90fb-b2826c376172"), new Guid("dfcbbe34-5690-486e-b1d1-f1222c453c42") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DayMenuMeal_MealsId",
                table: "DayMenuMeal",
                column: "MealsId");

            migrationBuilder.CreateIndex(
                name: "IX_DayMenuMeals_DayMenuId",
                table: "DayMenuMeals",
                column: "DayMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_DayMenuMeals_MealId",
                table: "DayMenuMeals",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_DayMenus_MenuId",
                table: "DayMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MealProduct_ProductsId",
                table: "MealProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_MealProducts_MealId",
                table: "MealProducts",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_MealProducts_ProductId",
                table: "MealProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_RecipeId",
                table: "Meals",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayMenuMeal");

            migrationBuilder.DropTable(
                name: "DayMenuMeals");

            migrationBuilder.DropTable(
                name: "MealProduct");

            migrationBuilder.DropTable(
                name: "MealProducts");

            migrationBuilder.DropTable(
                name: "DayMenus");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
