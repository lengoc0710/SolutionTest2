﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SolutionTest2.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeoA",
                table: "ProductTests");

            migrationBuilder.AlterColumn<bool>(
                name: "OnHome",
                table: "CategorieTests",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is homepage of SolutionTest" },
                    { "HomeKeyword", "This is  keyword of SolutionTest" },
                    { "HomeDescription", "This is description of SolutionTest" }
                });

            migrationBuilder.InsertData(
                table: "CategorieTests",
                columns: new[] { "ID", "OnHome", "ParentID", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, null, 1, 1 },
                    { 2, true, null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Tiếng Việt" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "ProductTests",
                columns: new[] { "ID", "DateCreated", "FirstPrice", "Price" },
                values: new object[] { 1, new DateTime(2022, 4, 16, 20, 25, 4, 58, DateTimeKind.Local).AddTicks(8076), 100000m, 200000m });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "vi", "Áo nam", "ao-nam", "Sản phẩm áo thời trang nam", "Sản phẩm áo thời trang nam" },
                    { 2, 1, "en", "Men Shirt", "men-shirt", "The shirt products for men", "The shirt products for men" },
                    { 3, 2, "vi", "Áo nữ", "ao-nu", "Sản phẩm áo thời trang nữ", "Sản phẩm áo thời trang women" },
                    { 4, 2, "en", "Women Shirt", "women-shirt", "The shirt products for women", "The shirt products for women" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, "Áo sơ mi nam trắng hiện đại ", "Áo sơ mi nam trắng hiện đại", "vi", "Áo sơ mi nam trắng hiện đại", 1, "ao-so-mi-nam-trang-hien-dai ", "Áo sơ mi nam trắng hiện đại ", "Áo sơ mi nam trắng hiện đại " },
                    { 2, "Modern Men T-Shirt", "Modern Men T-Shirt", "en", "Modern men T-Shirt", 1, "modern-men-t-shirt", "Modern  Men T-Shirt", "Modern Men T-Shirt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi-VN");

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategorieTests",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategorieTests",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTests",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "SeoA",
                table: "ProductTests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "OnHome",
                table: "CategorieTests",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
