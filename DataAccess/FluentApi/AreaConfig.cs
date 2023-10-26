using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class AreaConfig : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {

        #region has init data
        builder.HasData(
            new Area
            {
                Id = 1,
                Code = "A",
                Name = "African Savanna",
                Location = "Savanna Exhibit",
                Description = "An exhibit featuring animals from the African savanna",
                Capacity = 100,
            },
            new Area
            {
                Id = 2,
                Code = "B",
                Name = "Rainforest",
                Location = "Rainforest Pavilion",
                Description = "A lush and diverse rainforest habitat",
                Capacity = 80,
            },
            new Area
            {
                Id = 3,
                Code = "C",
                Name = "Penguin Cove",
                Location = "Aquatic Pavilion",
                Description = "A cold and watery habitat for penguins",
                Capacity = 50,
            },
            new Area
            {
                Id = 4,
                Code = "D",
                Name = "Desert Oasis",
                Location = "Desert Exhibit",
                Description = "A hot and arid desert environment",
                Capacity = 60,
            },
            new Area
            {
                Id = 5,
                Code = "E",
                Name = "Tropical Reef",
                Location = "Aquatic Pavilion",
                Description = "A vibrant coral reef with colorful fish",
                Capacity = 70,
            }
        );

        #endregion

    }
}
