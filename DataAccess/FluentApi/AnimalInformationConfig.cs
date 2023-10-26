using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class AnimalInformationConfig : IEntityTypeConfiguration<AnimalInformation>
{
    public void Configure(EntityTypeBuilder<AnimalInformation> builder)
    {
        builder.Property(x => x.CreationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.ModificationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        #region has init data
        builder.HasData
        (
            new AnimalInformation()
            {
                Id = 1,
                Name = "Simba",
                Description = "Majestic African lion named Simba.",
                Weight = 180,
                BirthDate = DateTime.Parse("2018-04-15"),
                SpeciesId = 1 // African Lion
            },
            new AnimalInformation()
            {
                Id = 2,
                Name = "Dumbo",
                Description = "Gentle Asian elephant named Dumbo.",
                Weight = 4500,
                Height = 10.0,
                BirthDate = DateTime.Parse("2015-07-20"),
                SpeciesId = 2 // Asian Elephant
            },
            new AnimalInformation()
            {
                Id = 3,
                Name = "Jaws",
                Description = "Fearsome great white shark named Jaws.",
                Weight = 2000,
                BirthDate = DateTime.Parse("2017-02-10"),
                SpeciesId = 3 // Great White Shark
            },
            new AnimalInformation()
            {
                Id = 4,
                Name = "Foxy",
                Description = "Cunning European red fox named Foxy.",
                Weight = 10,
                BirthDate = DateTime.Parse("2020-09-30"),
                SpeciesId = 4 // European Red Fox
            },
            new AnimalInformation()
            {
                Id = 5,
                Name = "Emmy",
                Description = "Regal emperor penguin named Emmy.",
                Weight = 35,
                BirthDate = DateTime.Parse("2019-12-05"),
                SpeciesId = 5 // Emperor Penguin
            },
            new AnimalInformation()
            {
                Id = 6,
                Name = "Kang",
                Description = "Energetic kangaroo named Kang.",
                Weight = 70,
                BirthDate = DateTime.Parse("2017-11-12"),
                SpeciesId = 6 // Kangaroo
            },
            new AnimalInformation()
            {
                Id = 7,
                Name = "Bear",
                Description = "Majestic grizzly bear named Bear.",
                Weight = 800,
                Height = 5.0,
                BirthDate = DateTime.Parse("2016-03-25"),
                SpeciesId = 7 // Grizzly Bear
            },
            new AnimalInformation()
            {
                Id = 8,
                Name = "Nanook",
                Description = "Proud polar bear named Nanook.",
                Weight = 900,
                Height = 4.5,
                BirthDate = DateTime.Parse("2015-12-18"),
                SpeciesId = 8 // Polar Bear
            },
            new AnimalInformation()
            {
                Id = 9,
                Name = "Raja",
                Description = "Fierce Bengal tiger named Raja.",
                Weight = 200,
                Height = 3.0,
                BirthDate = DateTime.Parse("2016-06-09"),
                SpeciesId = 9 // Bengal Tiger
            },
            new AnimalInformation()
            {
                Id = 10,
                Name = "Pandy",
                Description = "Adorable panda named Pandy.",
                Weight = 150,
                Height = 2.0,
                BirthDate = DateTime.Parse("2017-08-30"),
                SpeciesId = 10 // Panda
            },
            new AnimalInformation()
            {
                Id = 11,
                Name = "Zara",
                Description = "Graceful African lioness named Zara.",
                Weight = 150,
                BirthDate = DateTime.Parse("2019-02-14"),
                SpeciesId = 1 // African Lion
            },
            new AnimalInformation()
            {
                Id = 12,
                Name = "Babar",
                Description = "Gentle Asian elephant named Babar.",
                Weight = 4000,
                Height = 9.5,
                BirthDate = DateTime.Parse("2016-10-12"),
                SpeciesId = 2 // Asian Elephant
            },
            new AnimalInformation()
            {
                Id = 13,
                Name = "Fins",
                Description = "Majestic great white shark named Fins.",
                Weight = 1800,
                BirthDate = DateTime.Parse("2018-07-28"),
                SpeciesId = 3 // Great White Shark
            },
            new AnimalInformation()
            {
                Id = 14,
                Name = "Sly",
                Description = "Clever European red fox named Sly.",
                Weight = 12,
                BirthDate = DateTime.Parse("2021-04-03"),
                SpeciesId = 4 // European Red Fox
            },
            new AnimalInformation()
            {
                Id = 15,
                Name = "Waddle",
                Description = "Charming emperor penguin named Waddle.",
                Weight = 30,
                BirthDate = DateTime.Parse("2020-01-12"),
                SpeciesId = 5 // Emperor Penguin
            },
            new AnimalInformation()
            {
                Id = 16,
                Name = "Joey",
                Description = "Energetic kangaroo named Joey.",
                Weight = 75,
                BirthDate = DateTime.Parse("2017-08-15"),
                SpeciesId = 6 // Kangaroo
            },
            new AnimalInformation()
            {
                Id = 17,
                Name = "Bearly",
                Description = "Playful grizzly bear cub named Bearly.",
                Weight = 150,
                Height = 2.5,
                BirthDate = DateTime.Parse("2022-03-10"),
                SpeciesId = 7 // Grizzly Bear
            },
            new AnimalInformation()
            {
                Id = 18,
                Name = "Snowy",
                Description = "Young polar bear named Snowy.",
                Weight = 300,
                Height = 3.0,
                BirthDate = DateTime.Parse("2020-12-01"),
                SpeciesId = 8 // Polar Bear
            },
            new AnimalInformation()
            {
                Id = 19,
                Name = "Tyga",
                Description = "Adventurous Bengal tiger cub named Tyga.",
                Weight = 50,
                Height = 2.0,
                BirthDate = DateTime.Parse("2022-06-25"),
                SpeciesId = 9 // Bengal Tiger
            },
            new AnimalInformation()
            {
                Id = 20,
                Name = "Bamboo",
                Description = "Bamboo-loving panda named Bamboo.",
                Weight = 120,
                Height = 1.5,
                BirthDate = DateTime.Parse("2019-09-05"),
                SpeciesId = 10 // Panda
            }
        );

        #endregion

    }
}
