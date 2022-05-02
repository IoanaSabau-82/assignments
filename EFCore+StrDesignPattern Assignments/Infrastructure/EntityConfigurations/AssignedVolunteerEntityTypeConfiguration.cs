﻿using Domain;
using FindPetOwner;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityConfigurations
{
    public class AssignedVolunteerEntityTypeConfiguration : IEntityTypeConfiguration<AssignedVolunteer>
    {
        public void Configure(EntityTypeBuilder<AssignedVolunteer> assignedVolunteerConfiguration)
        {

            assignedVolunteerConfiguration
                 .HasOne(x => x.Post)
                 .WithMany(x => x.AssignedVolunteers)
                 .HasForeignKey(x => x.PostId)
                 .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
