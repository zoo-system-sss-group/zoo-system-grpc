using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class FeedHistoryConfig : IEntityTypeConfiguration<FeedHistory>
{
    public void Configure(EntityTypeBuilder<FeedHistory> builder)
    {
        builder.Property(x => x.CreationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.ModificationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        builder.Property(x => x.FeedingDate).HasDefaultValueSql("getutcdate()");
    }
}
