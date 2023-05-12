using AccountService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountService.Infrastructure.Persistence.Sqlite.Mapping;

public sealed class AccountMapper : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("Account");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.FirstName).HasColumnName("FirstName").IsRequired();
        builder.Property(c => c.LastName).HasColumnName("LastName").IsRequired();
    }
}