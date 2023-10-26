using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class TrainingDetailConfig : IEntityTypeConfiguration<TrainingDetail>
{
    public void Configure(EntityTypeBuilder<TrainingDetail> builder)
    {
        builder.Property(x => x.CreationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.ModificationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        builder.Property(x => x.StartDate).HasDefaultValueSql("getutcdate()");

        #region has init data
        builder.HasData
        (
            new TrainingDetail() { Id = 1, TrainerId = 1, AnimalId = 1 },
            new TrainingDetail() { Id = 2, TrainerId = 1, AnimalId = 11 },
            new TrainingDetail() { Id = 3, TrainerId = 2, AnimalId = 2 },
            new TrainingDetail() { Id = 4, TrainerId = 2, AnimalId = 12 },
            new TrainingDetail() { Id = 5, TrainerId = 3, AnimalId = 3 },
            new TrainingDetail() { Id = 6, TrainerId = 3, AnimalId = 13 },
            new TrainingDetail() { Id = 7, TrainerId = 4, AnimalId = 4 },
            new TrainingDetail() { Id = 8, TrainerId = 4, AnimalId = 14 },
            new TrainingDetail() { Id = 9, TrainerId = 5, AnimalId = 5 },
            new TrainingDetail() { Id = 10, TrainerId = 5, AnimalId = 15 },
            new TrainingDetail() { Id = 11, TrainerId = 1, AnimalId = 6 },
            new TrainingDetail() { Id = 12, TrainerId = 1, AnimalId = 16 },
            new TrainingDetail() { Id = 13, TrainerId = 2, AnimalId = 7 },
            new TrainingDetail() { Id = 14, TrainerId = 2, AnimalId = 17 },
            new TrainingDetail() { Id = 15, TrainerId = 3, AnimalId = 8 },
            new TrainingDetail() { Id = 16, TrainerId = 3, AnimalId = 18 },
            new TrainingDetail() { Id = 17, TrainerId = 4, AnimalId = 9 },
            new TrainingDetail() { Id = 18, TrainerId = 4, AnimalId = 19 },
            new TrainingDetail() { Id = 19, TrainerId = 5, AnimalId = 10 },
            new TrainingDetail() { Id = 20, TrainerId = 5, AnimalId = 20 }
        );

        #endregion

    }
}
