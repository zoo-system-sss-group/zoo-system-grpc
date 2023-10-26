using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class CageHistoryConfig : IEntityTypeConfiguration<CageHistory>
{
    public void Configure(EntityTypeBuilder<CageHistory> builder)
    {
        builder.Property(x => x.CreationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.ModificationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        builder.Property(x => x.StartDate).HasDefaultValueSql("getutcdate()");

        #region has init data
        builder.HasData
        (
            new CageHistory() { Id = 1, CageId = 1, AnimalId = 1 },  // Simba belongs to African Safari
            new CageHistory() { Id = 2, CageId = 2, AnimalId = 2 },  // Dumbo belongs to Elephant Sanctuary
            new CageHistory() { Id = 3, CageId = 3, AnimalId = 3 },  // Jaws belongs to Shark Tank
            new CageHistory() { Id = 4, CageId = 4, AnimalId = 4 },  // Foxy belongs to Grizzly Wilderness
            new CageHistory() { Id = 5, CageId = 5, AnimalId = 5 },  // Emmy belongs to Penguin Paradise
            new CageHistory() { Id = 6, CageId = 6, AnimalId = 6 },  // Kang belongs to Kangaroo Habitat
            new CageHistory() { Id = 7, CageId = 7, AnimalId = 7 },  // Bear belongs to Grizzly Wilderness
            new CageHistory() { Id = 8, CageId = 8, AnimalId = 8 },  // Nanook belongs to Polar Icecaps
            new CageHistory() { Id = 9, CageId = 9, AnimalId = 9 },  // Raja belongs to Bengal Tiger Reserve
            new CageHistory() { Id = 10, CageId = 10, AnimalId = 10 }, // Pandy belongs to Amazon Rainforest
            new CageHistory() { Id = 11, CageId = 1, AnimalId = 11 },  // Zara belongs to African Safari
            new CageHistory() { Id = 12, CageId = 2, AnimalId = 12 },  // Babar belongs to Elephant Sanctuary
            new CageHistory() { Id = 13, CageId = 3, AnimalId = 13 },  // Fins belongs to Shark Tank
            new CageHistory() { Id = 14, CageId = 4, AnimalId = 14 },  // Sly belongs to Grizzly Wilderness
            new CageHistory() { Id = 15, CageId = 5, AnimalId = 15 },  // Waddle belongs to Penguin Paradise
            new CageHistory() { Id = 16, CageId = 6, AnimalId = 16 },  // Joey belongs to Kangaroo Habitat
            new CageHistory() { Id = 17, CageId = 7, AnimalId = 17 },  // Bearly belongs to Grizzly Wilderness
            new CageHistory() { Id = 18, CageId = 8, AnimalId = 18 },  // Snowy belongs to Polar Icecaps
            new CageHistory() { Id = 19, CageId = 9, AnimalId = 19 },  // Tyga belongs to Bengal Tiger Reserve
            new CageHistory() { Id = 20, CageId = 10, AnimalId = 20 }  // Bamboo belongs to Amazon Rainforest
        );

        #endregion

    }
}
