using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditAreaIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Areas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 678, DateTimeKind.Local).AddTicks(2457), new DateTime(2023, 10, 25, 20, 11, 39, 678, DateTimeKind.Local).AddTicks(2467), "UXO9d5MzvEKUQE571SS/tavN+mQKWj3JJ9iXlnoUB7LqQ002" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 681, DateTimeKind.Local).AddTicks(4229), new DateTime(2023, 10, 25, 20, 11, 39, 681, DateTimeKind.Local).AddTicks(4229), "xzBvnZw7bIXztLXtAc3l53LKb4lyEFMUm13umq6i9QZqz+UQ" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 684, DateTimeKind.Local).AddTicks(6083), new DateTime(2023, 10, 25, 20, 11, 39, 684, DateTimeKind.Local).AddTicks(6084), "eUQz59SaniQczx+Kx1HFTj4vDCfD1HHW21m0kHgQNeMEGd4C" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 687, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 10, 25, 20, 11, 39, 687, DateTimeKind.Local).AddTicks(7973), "7w4A3sqACF6ipqYyHS1OaaZ5jh2DPWYRybVOA3yAKuHOU1DH" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 690, DateTimeKind.Local).AddTicks(9491), new DateTime(2023, 10, 25, 20, 11, 39, 690, DateTimeKind.Local).AddTicks(9491), "201wZiNjk3mfiQGT2bWDylCNn+rNgcACFgp3q2Aeiquu2VsX" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 694, DateTimeKind.Local).AddTicks(814), new DateTime(2023, 10, 25, 20, 11, 39, 694, DateTimeKind.Local).AddTicks(814), "LbIo9XS+OvfKgzNn4co0VHSfyIDnfTq3nKXe7+jau//9w0qN" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6720), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6811), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6824), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6831), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6836), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6841), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6846), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6852), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6857), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6862), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6873), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6878), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6882), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6888), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6893), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6898), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6903), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6908), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(8919), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(8925), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(8928), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 10, 25, 20, 11, 39, 697, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2535), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2535), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2537), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2538), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2543), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2543), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2544), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2545), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2546), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2546), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2549), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2551), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2553), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2553), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2556), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2557), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2558), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2565), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2567), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2567), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(24), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(28), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(30), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(32), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(34), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(36), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(38), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(39), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(41), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(43), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9694), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9698), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9699), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9701), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9703), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9705), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9707), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9709), new DateTime(2023, 10, 25, 20, 11, 39, 698, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8471), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8472), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8474), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8474), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8475), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8476), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8477), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8478), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8479), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8479), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8481), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8481), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8482), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8483), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8484), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8485), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8486), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8486), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8488), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8488), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8489), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8491), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8492), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8493), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8493), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8495), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8495), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8496), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8497), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8498), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8498), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8500), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8500), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8501), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8502), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8503), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8504), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8505), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8505), new DateTime(2023, 10, 25, 20, 11, 39, 699, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_Code",
                table: "Areas",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Areas_Code",
                table: "Areas");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Areas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 141, DateTimeKind.Local).AddTicks(7123), new DateTime(2023, 10, 25, 20, 7, 43, 141, DateTimeKind.Local).AddTicks(7141), "e0t26z6ZPN0g4dWBTgNFQEympc24NcFRNl9ktnY/MUsqM15N" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 144, DateTimeKind.Local).AddTicks(9107), new DateTime(2023, 10, 25, 20, 7, 43, 144, DateTimeKind.Local).AddTicks(9108), "IDYOOPs4ZYZBdB5QcSM7Y0aoniiRMY1cBWNE1rOlxaSzrze3" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 148, DateTimeKind.Local).AddTicks(1110), new DateTime(2023, 10, 25, 20, 7, 43, 148, DateTimeKind.Local).AddTicks(1110), "5v4EfSgHrmp0igLyO52KzLD8UgfL/uVeD8DyTGAxJPvJIxgN" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 151, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 10, 25, 20, 7, 43, 151, DateTimeKind.Local).AddTicks(3240), "LWe0Akz3+qs13cClYeQU5kq69zeqayt564tOkRe/T2LtHqvC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 154, DateTimeKind.Local).AddTicks(5023), new DateTime(2023, 10, 25, 20, 7, 43, 154, DateTimeKind.Local).AddTicks(5023), "vGGLxolvfxE214Foa1XO7TUSbDyAKbtUEaRveMvpggF5Q62S" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 157, DateTimeKind.Local).AddTicks(6886), new DateTime(2023, 10, 25, 20, 7, 43, 157, DateTimeKind.Local).AddTicks(6886), "SIPMsUSGXS+q5IsO+A0BCA1BM736O2HXCvQ9ii9htqCShhO5" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2843), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2934), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2942), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2948), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2958), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2968), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2979), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2985), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2990), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2995), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3001), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3006), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3011), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3026), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3034), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3039), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(4390), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(4395), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(4397), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(4398), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(4400), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7857), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7858), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7860), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7861), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7861), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7864), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7865), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7866), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7867), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7868), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7868), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7870), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7870), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7871), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7872), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7873), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7875), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7875), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7902), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7902), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7904), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7904), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7905), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7906), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7907), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7908), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7912), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7913), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7914), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7915), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5389), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5394), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5395), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5397), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5399), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5401), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5403), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5405), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5406), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5408), new DateTime(2023, 10, 25, 20, 7, 43, 161, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3564), new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3570), new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3572), new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3574), new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3576), new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3577), new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3581), new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3583), new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3585), new DateTime(2023, 10, 25, 20, 7, 43, 162, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1766), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1768), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1770), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1771), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1772), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1772), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1774), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1774), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1776), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1776), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1777), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1778), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1779), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1780), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1781), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1782), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1783), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1783), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1785), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1785), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1786), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1787), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1788), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1789), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1813), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1813), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1815), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1815), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1817), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1817), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1818), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1819), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1820), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1820), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1822), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1822), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1824), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1824), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1825), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1826), new DateTime(2023, 10, 25, 20, 7, 43, 163, DateTimeKind.Local).AddTicks(1825) });
        }
    }
}
