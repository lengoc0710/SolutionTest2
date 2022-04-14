using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolutionTest2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionTest2.Data.Configurations
{public class ProductConfiguration : IEntityTypeConfiguration<ProductTest>
    {

        public void Configure(EntityTypeBuilder<ProductTest> builder)
        {
            builder.ToTable("ProductTests");

            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();


            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.FirstPrice).IsRequired();

            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            //set default value
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);


        }
    }
}
