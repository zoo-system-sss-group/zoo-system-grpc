using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Areas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Avatar", "CreationDate", "DeletionDate", "Experiences", "Fullname", "ModificationDate", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 10, 17, 23, 40, 33, 115, DateTimeKind.Local).AddTicks(8571), null, null, "Lion Tamer", new DateTime(2023, 10, 17, 23, 40, 33, 115, DateTimeKind.Local).AddTicks(8582), "joUz5qDoLS7mEPrTVtUYot6cLLoVeppbsliABFj0uNsOGoNd", 1, "LionTamer" },
                    { 2, null, new DateTime(2023, 10, 17, 23, 40, 33, 119, DateTimeKind.Local).AddTicks(1467), null, null, "Pachyderm Pro", new DateTime(2023, 10, 17, 23, 40, 33, 119, DateTimeKind.Local).AddTicks(1472), "x365ss6RHANrH4zamJS5sigxOr62IBua2bdglUXEASEP1iqN", 1, "PachydermPro" },
                    { 3, null, new DateTime(2023, 10, 17, 23, 40, 33, 122, DateTimeKind.Local).AddTicks(4646), null, null, "Shark Whisperer", new DateTime(2023, 10, 17, 23, 40, 33, 122, DateTimeKind.Local).AddTicks(4646), "6AbRCXJ7j6Z/xIQmyo07+1RwHwVZMgZZ5H9vwJsVp81UgoGw", 1, "SharkWhisperer" },
                    { 4, null, new DateTime(2023, 10, 17, 23, 40, 33, 125, DateTimeKind.Local).AddTicks(7151), null, null, "Fox Friend", new DateTime(2023, 10, 17, 23, 40, 33, 125, DateTimeKind.Local).AddTicks(7151), "tF10OyzY1YiuXlZyj+AiKAkoJxJZq7iJ2RZpTwr/xLhScno3", 1, "FoxFriend" },
                    { 5, null, new DateTime(2023, 10, 17, 23, 40, 33, 129, DateTimeKind.Local).AddTicks(253), null, null, "Penguin Pal", new DateTime(2023, 10, 17, 23, 40, 33, 129, DateTimeKind.Local).AddTicks(254), "fVmO8LkkCFRDpluf1KDiT9Ub0fve/GlZIs4KaeKsENuxUN+t", 1, "PenguinPal" },
                    { 6, null, new DateTime(2023, 10, 17, 23, 40, 33, 132, DateTimeKind.Local).AddTicks(2783), null, null, "Nhân viên sở thú", new DateTime(2023, 10, 17, 23, 40, 33, 132, DateTimeKind.Local).AddTicks(2787), "gB2ftD7Sy7PmMeBzUx4+CcuqGU/CB5rITXEeetJI+ZZ9nUsJ", 0, "staff" }
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "Capacity", "Code", "CreationDate", "DeletionDate", "Description", "IsDeleted", "Location", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, 100, "A", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(363), null, "An exhibit featuring animals from the African savanna", false, "Savanna Exhibit", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(366), "African Savanna" },
                    { 2, 80, "B", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(368), null, "A lush and diverse rainforest habitat", false, "Rainforest Pavilion", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(368), "Rainforest" },
                    { 3, 50, "C", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(370), null, "A cold and watery habitat for penguins", false, "Aquatic Pavilion", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(370), "Penguin Cove" },
                    { 4, 60, "D", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(371), null, "A hot and arid desert environment", false, "Desert Exhibit", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(372), "Desert Oasis" },
                    { 5, 70, "E", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(373), null, "A vibrant coral reef with colorful fish", false, "Aquatic Pavilion", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(374), "Tropical Reef" }
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "CreationDate", "DeletionDate", "Description", "Habitat", "IsDeleted", "LifeSpan", "ModificationDate", "Name", "ScientificName", "WildDiet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9868), null, "The African lion is a large predatory cat native to Africa.", 0, false, 10, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9874), "African Lion", "Panthera leo", "Wild antelopes, zebras, and other herbivores" },
                    { 2, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9876), null, "The Asian elephant is the largest living land animal in Asia.", 1, false, 60, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9877), "Asian Elephant", "Elephas maximus", "Grasses, bamboo, fruits, and tree bark" },
                    { 3, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9878), null, "The great white shark is a fearsome predator of the oceans.", 2, false, 70, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9879), "Great White Shark", "Carcharodon carcharias", "Seals, sea lions, fish, and other sharks" },
                    { 4, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9880), null, "The European red fox is a cunning and adaptable predator.", 3, false, 5, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9881), "European Red Fox", "Vulpes vulpes", "Small mammals, birds, fruits, and insects" },
                    { 5, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9882), null, "The emperor penguin is the largest penguin species and lives in Antarctica.", 4, false, 20, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9882), "Emperor Penguin", "Aptenodytes forsteri", "Fish, squid, and krill" },
                    { 6, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9884), null, "Kangaroos are marsupials known for their powerful hind legs and pouches.", 5, false, 6, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9884), "Kangaroo", "Macropus", "Grasses and plants" },
                    { 7, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9886), null, "The grizzly bear is a large and formidable North American mammal.", 6, false, 20, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9886), "Grizzly Bear", "Ursus arctos horribilis", "Fish, berries, roots, and small mammals" },
                    { 8, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9887), null, "The polar bear is a marine mammal adapted to the Arctic environment.", 4, false, 25, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9888), "Polar Bear", "Ursus maritimus", "Seals and fish" },
                    { 9, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9889), null, "The Bengal tiger is a majestic big cat native to the Indian subcontinent.", 1, false, 15, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9890), "Bengal Tiger", "Panthera tigris tigris", "Deer, wild boar, and other ungulates" },
                    { 10, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9891), null, "The panda is an iconic bear species known for its bamboo diet.", 1, false, 20, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(9892), "Panda", "Ailuropoda melanoleuca", "Bamboo shoots and leaves" }
                });

            migrationBuilder.InsertData(
                table: "AnimalInformations",
                columns: new[] { "Id", "BirthDate", "CreationDate", "DeletionDate", "Description", "Height", "Image", "ModificationDate", "Name", "SpeciesId", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8584), null, "Majestic African lion named Simba.", null, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8590), "Simba", 1, 180.0 },
                    { 2, new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8670), null, "Gentle Asian elephant named Dumbo.", 10.0, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8671), "Dumbo", 2, 4500.0 },
                    { 3, new DateTime(2017, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8679), null, "Fearsome great white shark named Jaws.", null, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8679), "Jaws", 3, 2000.0 },
                    { 4, new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8684), null, "Cunning European red fox named Foxy.", null, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8685), "Foxy", 4, 10.0 },
                    { 5, new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8690), null, "Regal emperor penguin named Emmy.", null, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8690), "Emmy", 5, 35.0 },
                    { 6, new DateTime(2017, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8695), null, "Energetic kangaroo named Kang.", null, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8696), "Kang", 6, 70.0 },
                    { 7, new DateTime(2016, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8700), null, "Majestic grizzly bear named Bear.", 5.0, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8701), "Bear", 7, 800.0 },
                    { 8, new DateTime(2015, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8706), null, "Proud polar bear named Nanook.", 4.5, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8706), "Nanook", 8, 900.0 },
                    { 9, new DateTime(2016, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8711), null, "Fierce Bengal tiger named Raja.", 3.0, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8712), "Raja", 9, 200.0 },
                    { 10, new DateTime(2017, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8716), null, "Adorable panda named Pandy.", 2.0, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8717), "Pandy", 10, 150.0 },
                    { 11, new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8728), null, "Graceful African lioness named Zara.", null, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8728), "Zara", 1, 150.0 },
                    { 12, new DateTime(2016, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8733), null, "Gentle Asian elephant named Babar.", 9.5, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8734), "Babar", 2, 4000.0 },
                    { 13, new DateTime(2018, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8739), null, "Majestic great white shark named Fins.", null, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8739), "Fins", 3, 1800.0 },
                    { 14, new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8744), null, "Clever European red fox named Sly.", null, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8744), "Sly", 4, 12.0 },
                    { 15, new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8749), null, "Charming emperor penguin named Waddle.", null, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8749), "Waddle", 5, 30.0 },
                    { 16, new DateTime(2017, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8754), null, "Energetic kangaroo named Joey.", null, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8755), "Joey", 6, 75.0 },
                    { 17, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8759), null, "Playful grizzly bear cub named Bearly.", 2.5, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8760), "Bearly", 7, 150.0 },
                    { 18, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8764), null, "Young polar bear named Snowy.", 3.0, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8765), "Snowy", 8, 300.0 },
                    { 19, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8770), null, "Adventurous Bengal tiger cub named Tyga.", 2.0, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8770), "Tyga", 9, 50.0 },
                    { 20, new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8775), null, "Bamboo-loving panda named Bamboo.", 1.5, null, new DateTime(2023, 10, 17, 23, 40, 33, 135, DateTimeKind.Local).AddTicks(8775), "Bamboo", 10, 120.0 }
                });

            migrationBuilder.InsertData(
                table: "Cages",
                columns: new[] { "Id", "AreaId", "Capacity", "Code", "CreationDate", "DeletionDate", "Description", "Image", "IsDeleted", "Location", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, 10, "A0001", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1425), null, "A spacious exhibit featuring African animals.", null, false, "Savannah Exhibit", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1428), "African Safari" },
                    { 2, 1, 15, "A0002", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1430), null, "A dedicated area for Asian elephants.", null, false, "Asian Elephant Pavilion", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1431), "Elephant Sanctuary" },
                    { 3, 2, 12, "B0003", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1432), null, "A large tank showcasing great white sharks.", null, false, "Marine World", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1433), "Shark Tank" },
                    { 4, 2, 20, "B0004", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1434), null, "A natural habitat for grizzly bears.", null, false, "North American Habitat", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1435), "Grizzly Wilderness" },
                    { 5, 3, 8, "C0005", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1436), null, "A chilly paradise for emperor penguins.", null, false, "Antarctic Exhibit", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1436), "Penguin Paradise" },
                    { 6, 1, 20, "A0006", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1438), null, "A vast exhibit showcasing African wildlife.", null, false, "Wide Open Savannah", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1438), "African Plains" },
                    { 7, 2, 18, "B0007", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1440), null, "A chilly environment for polar animals.", null, false, "Arctic Enclosure", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1440), "Polar Icecaps" },
                    { 8, 3, 12, "C0008", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1442), null, "An arid landscape for Australian fauna.", null, false, "Australian Habitat", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1442), "Aussie Outback" },
                    { 9, 4, 15, "D0009", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1443), null, "A dense forest for Siberian wildlife.", null, false, "Russian Wilderness", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1444), "Siberian Taiga" },
                    { 10, 5, 25, "E0010", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1445), null, "A lush jungle exhibit for Amazon species.", null, false, "South American Jungle", new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(1446), "Amazon Rainforest" }
                });

            migrationBuilder.InsertData(
                table: "CageHistories",
                columns: new[] { "Id", "AnimalId", "CageId", "CreationDate", "DeletionDate", "EndDate", "ModificationDate", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3919), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3920), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3916) },
                    { 2, 2, 2, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3921), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3922), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3921) },
                    { 3, 3, 3, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3923), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3924), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3923) },
                    { 4, 4, 4, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3925), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3925), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3925) },
                    { 5, 5, 5, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3927), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3927), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3926) },
                    { 6, 6, 6, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3929), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3929), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3928) },
                    { 7, 7, 7, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3930), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3931), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3930) },
                    { 8, 8, 8, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3932), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3933), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3932) },
                    { 9, 9, 9, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3934), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3934), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3933) },
                    { 10, 10, 10, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3936), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3936), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3935) },
                    { 11, 11, 1, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3937), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3938), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3937) },
                    { 12, 12, 2, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3939), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3940), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3939) },
                    { 13, 13, 3, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3941), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3941), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3941) },
                    { 14, 14, 4, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3943), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3943), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3942) },
                    { 15, 15, 5, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3944), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3945), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3944) },
                    { 16, 16, 6, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3946), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3947), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3946) },
                    { 17, 17, 7, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3948), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3948), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3948) },
                    { 18, 18, 8, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3950), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3950), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3949) },
                    { 19, 19, 9, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3952), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3951) },
                    { 20, 20, 10, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3953), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3954), new DateTime(2023, 10, 17, 23, 40, 33, 136, DateTimeKind.Local).AddTicks(3953) }
                });

            migrationBuilder.InsertData(
                table: "TrainingDetails",
                columns: new[] { "Id", "AnimalId", "CreationDate", "DeletionDate", "EndDate", "ModificationDate", "StartDate", "TrainerId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8086), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8089), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8078), 1 },
                    { 2, 11, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8090), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8091), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8090), 1 },
                    { 3, 2, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8092), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8092), 2 },
                    { 4, 12, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8094), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8094), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8094), 2 },
                    { 5, 3, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8096), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8096), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8095), 3 },
                    { 6, 13, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8098), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8098), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8097), 3 },
                    { 7, 4, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8099), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8099), 4 },
                    { 8, 14, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8101), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8102), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8101), 4 },
                    { 9, 5, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8103), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8103), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8103), 5 },
                    { 10, 15, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8105), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8105), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8104), 5 },
                    { 11, 6, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8106), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8107), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8106), 1 },
                    { 12, 16, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8108), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8109), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8108), 1 },
                    { 13, 7, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8110), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8110), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8110), 2 },
                    { 14, 17, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8112), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8112), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8111), 2 },
                    { 15, 8, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8114), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8114), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8113), 3 },
                    { 16, 18, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8115), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8116), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8115), 3 },
                    { 17, 9, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8117), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8117), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8117), 4 },
                    { 18, 19, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8119), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8119), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8118), 4 },
                    { 19, 10, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8120), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8121), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8120), 5 },
                    { 20, 20, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8122), null, null, new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8123), new DateTime(2023, 10, 17, 23, 40, 33, 137, DateTimeKind.Local).AddTicks(8122), 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CageHistories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TrainingDetails",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AnimalInformations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cages");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Areas");
        }
    }
}
