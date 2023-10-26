using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Editticketschema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Tickets",
                newName: "TicketType");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TicketType",
                table: "Tickets",
                newName: "Status");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 115, DateTimeKind.Local).AddTicks(8571), new DateTime(2023, 10, 17, 23, 40, 33, 115, DateTimeKind.Local).AddTicks(8582), "joUz5qDoLS7mEPrTVtUYot6cLLoVeppbsliABFj0uNsOGoNd" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 119, DateTimeKind.Local).AddTicks(1467), new DateTime(2023, 10, 17, 23, 40, 33, 119, DateTimeKind.Local).AddTicks(1472), "x365ss6RHANrH4zamJS5sigxOr62IBua2bdglUXEASEP1iqN" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 122, DateTimeKind.Local).AddTicks(4646), new DateTime(2023, 10, 17, 23, 40, 33, 122, DateTimeKind.Local).AddTicks(4646), "6AbRCXJ7j6Z/xIQmyo07+1RwHwVZMgZZ5H9vwJsVp81UgoGw" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 125, DateTimeKind.Local).AddTicks(7151), new DateTime(2023, 10, 17, 23, 40, 33, 125, DateTimeKind.Local).AddTicks(7151), "tF10OyzY1YiuXlZyj+AiKAkoJxJZq7iJ2RZpTwr/xLhScno3" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 129, DateTimeKind.Local).AddTicks(253), new DateTime(2023, 10, 17, 23, 40, 33, 129, DateTimeKind.Local).AddTicks(254), "fVmO8LkkCFRDpluf1KDiT9Ub0fve/GlZIs4KaeKsENuxUN+t" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 132, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 10, 17, 23, 40, 33, 132, DateTimeKind.Local).AddTicks(2787), "gB2ftD7Sy7PmMeBzUx4+CcuqGU/CB5rITXEeetJI+ZZ9nUsJ" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8584), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8670), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8679), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8684), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8695), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8700), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8706), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8711), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8716), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8728), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8733), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8739), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8749), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8754), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8764), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8770), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(368), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(370), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(371), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(373), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3919), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3920), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3921), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3922), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3923), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3924), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3925), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3925), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3927), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3927), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3929), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3929), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3930), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3931), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3932), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3933), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3934), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3934), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3936), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3936), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3937), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3938), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3939), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3940), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3941), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3941), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3943), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3943), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3944), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3945), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3946), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3947), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3948), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3948), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3950), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3950), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3953), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3954), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1425), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1430), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1432), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1434), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1436), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1438), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1440), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1442), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1443), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1445), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9868), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9876), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9878), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9880), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9882), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9884), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9887), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9889), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9891), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8086), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8089), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8090), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8091), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8092), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8094), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8094), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8096), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8096), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8098), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8098), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8099), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8101), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8102), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8103), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8103), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8105), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8105), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8106), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8107), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8108), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8109), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8110), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8110), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8112), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8112), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8114), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8114), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8115), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8116), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8117), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8117), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8119), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8119), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8120), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8121), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8122), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8123), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8122) });
        }
    }
}
