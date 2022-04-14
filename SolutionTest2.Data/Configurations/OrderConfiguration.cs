using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolutionTest2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionTest2.Data.Configurations
{

    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ShipEmail).IsRequired().IsUnicode(false).HasMaxLength(55);
        }
    }
}
