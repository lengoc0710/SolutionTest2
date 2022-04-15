using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolutionTest2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace SolutionTest2.Data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<TransactionTest>
    {
        public void Configure(EntityTypeBuilder<TransactionTest> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.AppUser).WithMany(x => x.Transactions).HasForeignKey(x => x.UserId);
        }
    }
}
