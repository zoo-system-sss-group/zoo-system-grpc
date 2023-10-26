using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class CageConfig : IEntityTypeConfiguration<Cage>
{
    public void Configure(EntityTypeBuilder<Cage> builder)
    {
        #region has init data
        builder.HasData
        (
            new Cage()
            {
                Id = 1,
                Code = "A0001",
                Name = "African Safari",
                Location = "Savannah Exhibit",
                Capacity = 10,
                Description = "A spacious exhibit featuring African animals.",
                AreaId = 1 // Assume it's in Area 1
            },
            new Cage()
            {
                Id = 2,
                Code = "A0002",
                Name = "Elephant Sanctuary",
                Location = "Asian Elephant Pavilion",
                Capacity = 15,
                Description = "A dedicated area for Asian elephants.",
                AreaId = 1 // Assume it's in Area 1
            },
            new Cage()
            {
                Id = 3,
                Code = "B0003",
                Name = "Shark Tank",
                Location = "Marine World",
                Capacity = 12,
                Description = "A large tank showcasing great white sharks.",
                AreaId = 2 // Assume it's in Area 2
            },
            new Cage()
            {
                Id = 4,
                Code = "B0004",
                Name = "Grizzly Wilderness",
                Location = "North American Habitat",
                Capacity = 20,
                Description = "A natural habitat for grizzly bears.",
                AreaId = 2 // Assume it's in Area 2
            },
            new Cage()
            {
                Id = 5,
                Code = "C0005",
                Name = "Penguin Paradise",
                Location = "Antarctic Exhibit",
                Capacity = 8,
                Description = "A chilly paradise for emperor penguins.",
                AreaId = 3 // Assume it's in Area 3
            },
            new Cage()
            {
                Id = 6,
                Code = "A0006",
                Name = "African Plains",
                Location = "Wide Open Savannah",
                Capacity = 20,
                Description = "A vast exhibit showcasing African wildlife.",
                AreaId = 1 // Assume it's in Area 1
            },
            new Cage()
            {
                Id = 7,
                Code = "B0007",
                Name = "Polar Icecaps",
                Location = "Arctic Enclosure",
                Capacity = 18,
                Description = "A chilly environment for polar animals.",
                AreaId = 2 // Assume it's in Area 2
            },
            new Cage()
            {
                Id = 8,
                Code = "C0008",
                Name = "Aussie Outback",
                Location = "Australian Habitat",
                Capacity = 12,
                Description = "An arid landscape for Australian fauna.",
                AreaId = 3 // Assume it's in Area 3
            },
            new Cage()
            {
                Id = 9,
                Code = "D0009",
                Name = "Siberian Taiga",
                Location = "Russian Wilderness",
                Capacity = 15,
                Description = "A dense forest for Siberian wildlife.",
                AreaId = 4 // Assume it's in Area 4
            },
            new Cage()
            {
                Id = 10,
                Code = "E0010",
                Name = "Amazon Rainforest",
                Location = "South American Jungle",
                Capacity = 25,
                Description = "A lush jungle exhibit for Amazon species.",
                AreaId = 5 // Assume it's in Area 5
            }
        );

        #endregion

    }
}
