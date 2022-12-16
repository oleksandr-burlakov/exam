using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolMenu.DAL.Migrations
{
    public partial class RemoveRecipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Recipes_RecipeId",
                table: "Meals");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Meals_RecipeId",
                table: "Meals");

            migrationBuilder.DeleteData(
                table: "DayMenuMeals",
                keyColumn: "Id",
                keyValue: new Guid("96b4d8dc-0d7d-4537-89f1-83563080167b"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("5ffcad55-46d5-4846-bb8e-b02f49623fe2"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("75b1bd80-7113-4565-937c-0fcbe3db5fec"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("9dde9792-9d9f-4233-9836-290ae71e9864"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("a5ef10f8-fa47-4f9f-a46b-07088573ea85"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("abeb0367-ab7e-465b-9ed5-b2ed55808234"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("b65f2cfe-e142-4a42-8632-cd54cc2c7c57"));

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: new Guid("a0598a8f-19b9-477b-808f-816cfddec4e8"));

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: new Guid("e7278a46-3723-47af-8498-a2f522d6a570"));

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: new Guid("f84ed766-10d1-4c3f-987f-16e9b690aa90"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("d3a414f8-3ae5-4afc-95d5-d093e4131f47"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("c0bd97a3-4d2e-49d9-90fb-b2826c376172"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b3f8ee9-c885-4332-8ccc-3d02cfe26173"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a77b973f-412e-4d8f-920f-d548ace92be1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfcbbe34-5690-486e-b1d1-f1222c453c42"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("c23f1280-faa4-47c5-9013-57a2520bf136"));

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "Meals");

            migrationBuilder.AddColumn<string>(
                name: "Recipe",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Name", "Price", "Recipe" },
                values: new object[] { new Guid("e7a51b06-c014-4818-8685-fc6df89ec110"), "Summer Asian Slaw", 2.20m, "Make the dressing: In a small bowl, whisk together the cashew butter, miso paste, lime juice, sesame oil, and ginger. Whisk in enough water to create a drizzable consistency. Set aside.\r\nIn a dry cast-iron skillet over medium heat, char the peppers whole, rotating until the edges have a little char, about 2 minutes per side. Remove. When cool to the touch, slice in half lengthwise, remove the stem, ribbing, and seeds and slice horizontally into thin strips.\r\nIn a large bowl, combine the cabbage, peppers, scallions, cilantro, basil, chiles, and ¾ of the dressing. Toss until combined. Add the remaining dressing, if desired, and season to taste with a few pinches of sea salt. Serve topped with the toasted nuts, seeds, and sliced peaches." });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "DayMenuId", "SchoolName" },
                values: new object[] { new Guid("4f7583d1-3663-4968-b6b4-b63fb7ff54ff"), new Guid("00000000-0000-0000-0000-000000000000"), "Lviv school" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "ProductPrice" },
                values: new object[,]
                {
                    { new Guid("23a56b97-b0d5-4bb3-87b5-26a07cfb8000"), "Pepper", 0.4m },
                    { new Guid("3e4e3a17-0fa9-4a19-9797-7499b200b187"), "Peach", 1.6m },
                    { new Guid("7562376f-960b-40d8-afb2-42461582c62f"), "Cabbage", 1.0m }
                });

            migrationBuilder.InsertData(
                table: "DayMenus",
                columns: new[] { "Id", "MenuId", "WeekDay" },
                values: new object[,]
                {
                    { new Guid("33a2f7c0-4845-44b8-bb2b-40728d9bd496"), new Guid("4f7583d1-3663-4968-b6b4-b63fb7ff54ff"), 4 },
                    { new Guid("6ab040f2-36c1-4f2a-ba76-851006c17d2a"), new Guid("4f7583d1-3663-4968-b6b4-b63fb7ff54ff"), 2 },
                    { new Guid("75d2d0e7-f643-4ba6-acab-6d25e9957272"), new Guid("4f7583d1-3663-4968-b6b4-b63fb7ff54ff"), 5 },
                    { new Guid("891f0651-0ff1-4588-b1a3-a20c22dcfc02"), new Guid("4f7583d1-3663-4968-b6b4-b63fb7ff54ff"), 0 },
                    { new Guid("8cc4b18a-4018-4ab7-bc0e-4a58d66e28d9"), new Guid("4f7583d1-3663-4968-b6b4-b63fb7ff54ff"), 6 },
                    { new Guid("9de297a1-05f5-496c-877f-ee17d361cb00"), new Guid("4f7583d1-3663-4968-b6b4-b63fb7ff54ff"), 1 },
                    { new Guid("bb02d3da-afd5-460b-9196-c562991264f9"), new Guid("4f7583d1-3663-4968-b6b4-b63fb7ff54ff"), 3 }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("1b7010a5-a24a-4f74-9fcb-b4555da7f330"), new Guid("e7a51b06-c014-4818-8685-fc6df89ec110"), new Guid("23a56b97-b0d5-4bb3-87b5-26a07cfb8000") },
                    { new Guid("42de64f7-a101-44da-8241-a864b3dee9cb"), new Guid("e7a51b06-c014-4818-8685-fc6df89ec110"), new Guid("7562376f-960b-40d8-afb2-42461582c62f") },
                    { new Guid("a9451b31-efe4-4c25-b11f-3b47c4d0abcd"), new Guid("e7a51b06-c014-4818-8685-fc6df89ec110"), new Guid("3e4e3a17-0fa9-4a19-9797-7499b200b187") }
                });

            migrationBuilder.InsertData(
                table: "DayMenuMeals",
                columns: new[] { "Id", "DayMenuId", "MealId" },
                values: new object[] { new Guid("64d84c5c-9ea7-4261-8907-07bcf3c3e500"), new Guid("891f0651-0ff1-4588-b1a3-a20c22dcfc02"), new Guid("e7a51b06-c014-4818-8685-fc6df89ec110") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DayMenuMeals",
                keyColumn: "Id",
                keyValue: new Guid("64d84c5c-9ea7-4261-8907-07bcf3c3e500"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("33a2f7c0-4845-44b8-bb2b-40728d9bd496"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("6ab040f2-36c1-4f2a-ba76-851006c17d2a"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("75d2d0e7-f643-4ba6-acab-6d25e9957272"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("8cc4b18a-4018-4ab7-bc0e-4a58d66e28d9"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("9de297a1-05f5-496c-877f-ee17d361cb00"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("bb02d3da-afd5-460b-9196-c562991264f9"));

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: new Guid("1b7010a5-a24a-4f74-9fcb-b4555da7f330"));

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: new Guid("42de64f7-a101-44da-8241-a864b3dee9cb"));

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: new Guid("a9451b31-efe4-4c25-b11f-3b47c4d0abcd"));

            migrationBuilder.DeleteData(
                table: "DayMenus",
                keyColumn: "Id",
                keyValue: new Guid("891f0651-0ff1-4588-b1a3-a20c22dcfc02"));

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: new Guid("e7a51b06-c014-4818-8685-fc6df89ec110"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23a56b97-b0d5-4bb3-87b5-26a07cfb8000"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e4e3a17-0fa9-4a19-9797-7499b200b187"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7562376f-960b-40d8-afb2-42461582c62f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("4f7583d1-3663-4968-b6b4-b63fb7ff54ff"));

            migrationBuilder.DropColumn(
                name: "Recipe",
                table: "Meals");

            migrationBuilder.AddColumn<Guid>(
                name: "RecipeId",
                table: "Meals",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "IX_Meals_RecipeId",
                table: "Meals",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Recipes_RecipeId",
                table: "Meals",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
