﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Configurations
{
    internal class UsersBranchOfficeConfiguration : IEntityTypeConfiguration<UsersBranchOffice>
    {
        public void Configure(EntityTypeBuilder<UsersBranchOffice> builder)
        {
            builder.HasKey(e => e.UserBranchOfficeId)
                       .HasName("PK__UsersBra__7D1E804ABCB70C9E");

            builder.HasOne(d => d.BranchOffice)
                 .WithMany(p => p.UsersBranchOffices)
                 .HasForeignKey(d => d.BranchOfficeId)
                 .HasConstraintName("FK__UsersBran__Branc__5DCAEF64");

            builder.HasOne(d => d.User)
                 .WithMany(p => p.UsersBranchOffices)
                 .HasForeignKey(d => d.UserId)
                 .HasConstraintName("FK__UsersBran__UserI__5EBF139D");
        }
    }
}
