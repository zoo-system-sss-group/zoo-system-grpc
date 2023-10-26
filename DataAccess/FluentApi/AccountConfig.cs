using DataAccess.Utils;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class AccountConfig : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasIndex(x => x.Username).IsUnique();
        builder.Property(x => x.CreationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.ModificationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        builder.HasData
        (
            // trainers
            new Account() { Id = 1, Username = "LionTamer", Password = "123456".Hash(), Fullname = "Lion Tamer", Role = RoleEnum.Trainer },
            new Account() { Id = 2, Username = "PachydermPro", Password = "123456".Hash(), Fullname = "Pachyderm Pro", Role = RoleEnum.Trainer },
            new Account() { Id = 3, Username = "SharkWhisperer", Password = "123456".Hash(), Fullname = "Shark Whisperer", Role = RoleEnum.Trainer },
            new Account() { Id = 4, Username = "FoxFriend", Password = "123456".Hash(), Fullname = "Fox Friend", Role = RoleEnum.Trainer },
            new Account() { Id = 5, Username = "PenguinPal", Password = "123456".Hash(), Fullname = "Penguin Pal", Role = RoleEnum.Trainer },
            // staffs
            new Account() { Id = 6, Username = "staff", Password = "123456".Hash(), Fullname = "Nhân viên sở thú", Role = RoleEnum.Staff }
        );

    }
}
