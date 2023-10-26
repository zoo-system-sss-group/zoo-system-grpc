using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditTicketInfoShchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EffectiveDate",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 448, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 10, 25, 21, 28, 24, 448, DateTimeKind.Local).AddTicks(6634), "9LCakn55i/mSLz7SukrO9/JJ+qdQUALRJZngYmjAhIlLA1Ui" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 451, DateTimeKind.Local).AddTicks(8112), new DateTime(2023, 10, 25, 21, 28, 24, 451, DateTimeKind.Local).AddTicks(8113), "0F2+o4/UJOfCnmoqDg75iPW1VCnPEhXEXrwcBVFuVo/4anbP" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 454, DateTimeKind.Local).AddTicks(9191), new DateTime(2023, 10, 25, 21, 28, 24, 454, DateTimeKind.Local).AddTicks(9191), "wJD+up8MXv748fYpF3+PUnr4O2RUZQTsJVK9Uo5iLeIpv6f9" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 458, DateTimeKind.Local).AddTicks(573), new DateTime(2023, 10, 25, 21, 28, 24, 458, DateTimeKind.Local).AddTicks(573), "0sd/yrAhVBDKATbQxKGwWDs+T8qjAfsHQ/YR9TXPlXr4NczE" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 461, DateTimeKind.Local).AddTicks(1839), new DateTime(2023, 10, 25, 21, 28, 24, 461, DateTimeKind.Local).AddTicks(1841), "vyhMoQbSOl/e2420IrsGprjWgADBzu3RDCBsV1YdHb+OT5OE" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate", "Password" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 464, DateTimeKind.Local).AddTicks(3159), new DateTime(2023, 10, 25, 21, 28, 24, 464, DateTimeKind.Local).AddTicks(3160), "Koo6C1mIz5DbYZC4/zSO3K68l5slWeMMntSWn27LG+p8V9nu" });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9080), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9190), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9195), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9202), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9207), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9212), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9218), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9223), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9228), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9235), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9240), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9245), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9250), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9255), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9260), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9265), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9270), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9275), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 10, 25, 21, 28, 24, 467, DateTimeKind.Local).AddTicks(9281) });

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
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2837), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2839), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2843), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2846), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2848), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2850), new DateTime(2023, 10, 25, 21, 28, 24, 468, DateTimeKind.Local).AddTicks(2850) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }
    }
}
