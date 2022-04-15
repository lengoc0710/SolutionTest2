using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolutionTest2.Data.Entities;
using SolutionTest2.Data.EnumTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionTest2.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<CategoryTest>
    {
        public void Configure(EntityTypeBuilder<CategoryTest> builder)
        {
            builder.ToTable("CategorieTests");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).UseIdentityColumn();


            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
