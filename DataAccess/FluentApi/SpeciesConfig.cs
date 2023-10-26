using DataAccess.Utils;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class SpeciesConfig : IEntityTypeConfiguration<Species>
{
    public void Configure(EntityTypeBuilder<Species> builder)
    {
        #region has init data
        builder.HasData
        (
            new Species()
            {
                Id = 1,
                Name = "African Lion",
                ScientificName = "Panthera leo",
                LifeSpan = 10,
                Description = "The African lion is a large predatory cat native to Africa.",
                WildDiet = "Wild antelopes, zebras, and other herbivores",
                Habitat = HabitatEnum.AFRICAN
            },
            new Species()
            {
                Id = 2,
                Name = "Asian Elephant",
                ScientificName = "Elephas maximus",
                LifeSpan = 60,
                Description = "The Asian elephant is the largest living land animal in Asia.",
                WildDiet = "Grasses, bamboo, fruits, and tree bark",
                Habitat = HabitatEnum.ASIAN
            },
            new Species()
            {
                Id = 3,
                Name = "Great White Shark",
                ScientificName = "Carcharodon carcharias",
                LifeSpan = 70,
                Description = "The great white shark is a fearsome predator of the oceans.",
                WildDiet = "Seals, sea lions, fish, and other sharks",
                Habitat = HabitatEnum.OCEANS
            },
            new Species()
            {
                Id = 4,
                Name = "European Red Fox",
                ScientificName = "Vulpes vulpes",
                LifeSpan = 5,
                Description = "The European red fox is a cunning and adaptable predator.",
                WildDiet = "Small mammals, birds, fruits, and insects",
                Habitat = HabitatEnum.EUROPE
            },
            new Species()
            {
                Id = 5,
                Name = "Emperor Penguin",
                ScientificName = "Aptenodytes forsteri",
                LifeSpan = 20,
                Description = "The emperor penguin is the largest penguin species and lives in Antarctica.",
                WildDiet = "Fish, squid, and krill",
                Habitat = HabitatEnum.ANTARCTIC
            },
            new Species()
            {
                Id = 6,
                Name = "Kangaroo",
                ScientificName = "Macropus",
                LifeSpan = 6,
                Description = "Kangaroos are marsupials known for their powerful hind legs and pouches.",
                WildDiet = "Grasses and plants",
                Habitat = HabitatEnum.AUSTRALIAN
            },
            new Species()
            {
                Id = 7,
                Name = "Grizzly Bear",
                ScientificName = "Ursus arctos horribilis",
                LifeSpan = 20,
                Description = "The grizzly bear is a large and formidable North American mammal.",
                WildDiet = "Fish, berries, roots, and small mammals",
                Habitat = HabitatEnum.NORTH_AMERICA
            },
            new Species()
            {
                Id = 8,
                Name = "Polar Bear",
                ScientificName = "Ursus maritimus",
                LifeSpan = 25,
                Description = "The polar bear is a marine mammal adapted to the Arctic environment.",
                WildDiet = "Seals and fish",
                Habitat = HabitatEnum.ANTARCTIC
            },
            new Species()
            {
                Id = 9,
                Name = "Bengal Tiger",
                ScientificName = "Panthera tigris tigris",
                LifeSpan = 15,
                Description = "The Bengal tiger is a majestic big cat native to the Indian subcontinent.",
                WildDiet = "Deer, wild boar, and other ungulates",
                Habitat = HabitatEnum.ASIAN
            },
            new Species()
            {
                Id = 10,
                Name = "Panda",
                ScientificName = "Ailuropoda melanoleuca",
                LifeSpan = 20,
                Description = "The panda is an iconic bear species known for its bamboo diet.",
                WildDiet = "Bamboo shoots and leaves",
                Habitat = HabitatEnum.ASIAN
            }
        );

        #endregion

    }
}
