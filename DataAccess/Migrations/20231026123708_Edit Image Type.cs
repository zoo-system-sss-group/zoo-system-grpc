using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditImageType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Thumbnail",
                table: "News",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Cages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "AnimalInformations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Avatar",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 10, 26, 19, 37, 8, 34, DateTimeKind.Local).AddTicks(3752), new DateTime(2023, 10, 26, 19, 37, 8, 34, DateTimeKind.Local).AddTicks(3764), "nFJU23RQARg1LMfTngQ+XMqrZg47sjTnSCRA8GmJqYzQXC2S" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 10, 26, 19, 37, 8, 38, DateTimeKind.Local).AddTicks(5012), new DateTime(2023, 10, 26, 19, 37, 8, 38, DateTimeKind.Local).AddTicks(5014), "5VzDcLOApdpTWewVF3fb3+iDsURuDehDAPnffCm/8eUiRjqU" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 10, 26, 19, 37, 8, 42, DateTimeKind.Local).AddTicks(6312), new DateTime(2023, 10, 26, 19, 37, 8, 42, DateTimeKind.Local).AddTicks(6313), "8SRRAOvw1X6TU4BN1i8CyMVsHIWoWW9S/jw02Qnz+hFWTlUr" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 10, 26, 19, 37, 8, 46, DateTimeKind.Local).AddTicks(7456), new DateTime(2023, 10, 26, 19, 37, 8, 46, DateTimeKind.Local).AddTicks(7457), "h1DZMa8Je49M8HKcd5IuVl7pNT9auAWuGnc1QD3M5+9ikE+X" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 10, 26, 19, 37, 8, 51, DateTimeKind.Local).AddTicks(2781), new DateTime(2023, 10, 26, 19, 37, 8, 51, DateTimeKind.Local).AddTicks(2793), "cEhy3uXNgMWIdZfxxJIRRz6M/blDtEiqErfM7h1P3yOZ2fIP" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 10, 26, 19, 37, 8, 55, DateTimeKind.Local).AddTicks(3979), new DateTime(2023, 10, 26, 19, 37, 8, 55, DateTimeKind.Local).AddTicks(3982), "HDiFoYJ1qA36rIvTbyxW4s80ifPs2OzuDjyVDI4barjHLbZD" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9719), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9811), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9821), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9827), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9834), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9841), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9847), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9853), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9860), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9867), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9873), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9880), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9886), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9892), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9898), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9905), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9911), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9917), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9924), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9930), null, new DateTime(2023, 10, 26, 19, 37, 8, 59, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2778), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7851), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7852), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7854), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7855), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7856), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7857), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7861), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7861), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7865), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7866), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7867), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7868), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7869), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7870), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7872), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7872), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7876), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7878), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7881), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7883), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7883), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7887), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7891), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7892), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7894), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7894), new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4285), null, new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4291), null, new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4293), null, new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4296), null, new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4298), null, new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4300), null, new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4303), null, new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4305), null, new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4307), null, new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4310), null, new DateTime(2023, 10, 26, 19, 37, 8, 60, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6027), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6039), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6042), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6044), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6051), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6053), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6056), new DateTime(2023, 10, 26, 19, 37, 8, 61, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7948), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7951), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7952), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7953), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7954), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7955), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7956), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7960), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7960), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7962), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7962), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7966), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7967), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7968), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7969), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7975), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7977), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7978), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7982), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7982), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7984), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7984), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7988), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7989), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7990), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7991), new DateTime(2023, 10, 26, 19, 37, 8, 62, DateTimeKind.Local).AddTicks(7990) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Thumbnail",
                table: "News",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Cages",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "AnimalInformations",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Avatar",
                table: "Accounts",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 10, 25, 21, 28, 24, 448, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 10, 25, 21, 28, 24, 448, DateTimeKind.Local).AddTicks(6634), "9LCakn55i/mSLz7SukrO9/JJ+qdQUALRJZngYmjAhIlLA1Ui" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 10, 25, 21, 28, 24, 451, DateTimeKind.Local).AddTicks(8112), new DateTime(2023, 10, 25, 21, 28, 24, 451, DateTimeKind.Local).AddTicks(8113), "0F2+o4/UJOfCnmoqDg75iPW1VCnPEhXEXrwcBVFuVo/4anbP" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 10, 25, 21, 28, 24, 454, DateTimeKind.Local).AddTicks(9191), new DateTime(2023, 10, 25, 21, 28, 24, 454, DateTimeKind.Local).AddTicks(9191), "wJD+up8MXv748fYpF3+PUnr4O2RUZQTsJVK9Uo5iLeIpv6f9" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 10, 25, 21, 28, 24, 458, DateTimeKind.Local).AddTicks(573), new DateTime(2023, 10, 25, 21, 28, 24, 458, DateTimeKind.Local).AddTicks(573), "0sd/yrAhVBDKATbQxKGwWDs+T8qjAfsHQ/YR9TXPlXr4NczE" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 10, 25, 21, 28, 24, 461, DateTimeKind.Local).AddTicks(1839), new DateTime(2023, 10, 25, 21, 28, 24, 461, DateTimeKind.Local).AddTicks(1841), "vyhMoQbSOl/e2420IrsGprjWgADBzu3RDCBsV1YdHb+OT5OE" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Avatar", "CreationDate", "ModificationDate", "Password" },
                values: new object[] { null, new DateTime(2023, 10, 25, 21, 28, 24, 464, DateTimeKind.Local).AddTicks(3159), new DateTime(2023, 10, 25, 21, 28, 24, 464, DateTimeKind.Local).AddTicks(3160), "Koo6C1mIz5DbYZC4/zSO3K68l5slWeMMntSWn27LG+p8V9nu" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9080), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9182), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9190), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9195), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9202), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9207), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9212), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9218), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9223), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9228), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9235), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9240), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9245), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9250), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9255), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9260), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9265), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9270), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9275), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9280), null, new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(1500), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(1508), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(1510), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(1548), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(1550), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5495), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5496), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5497), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5498), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5499), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5500), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5501), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5501), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5503), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5503), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5504), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5505), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5506), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5507), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5508), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5508), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5512), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5512), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5513), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5514), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5515), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5516), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5517), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5517), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5519), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5519), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5520), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5521), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5522), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5523), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5524), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5524), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5526), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5526), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5527), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5528), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2830), null, new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2835), null, new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2837), null, new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2839), null, new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2841), null, new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2843), null, new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2844), null, new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2846), null, new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2848), null, new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "Image", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2850), null, new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1714), new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1724), new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1726), new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1728), new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1730), new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1732), new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1734), new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1735), new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1737), new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1739), new DateTime(2023, 10, 25, 21, 28, 24, 469, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(692), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(694), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(695), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(696), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(697), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(698), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(699), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(700), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(701), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(701), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(703), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(703), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(704), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(705), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(706), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(707), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(708), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(708), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(710), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(710), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(712), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(712), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(713), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(714), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(715), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(715), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(717), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(717), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(719), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(719), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(720), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(721), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(722), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(723), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(724), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(724), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(726), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(726), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(727), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(728), new DateTime(2023, 10, 25, 21, 28, 24, 470, DateTimeKind.Local).AddTicks(727) });
        }
    }
}
