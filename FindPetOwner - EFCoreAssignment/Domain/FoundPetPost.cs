﻿using FindPetOwner;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FoundPetPost :BaseEntity
    {
        public Guid Id { get; set; }

        public Guid CreatedById { get; set; }
        /*pt tema[ForeignKey(nameof(MadeById))]*/
        public User CreatedBy { get; set; }

        public List<Picture>? Pictures { get; set; }
        public string Phone { get; set; }
        public DateTime AvailabilityStart { get; set; }
        public DateTime AvailabilityEnd { get; set; }
        public string Comment { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public PostStatus PostStatus { get; set; }
        public long CipId { get; set; }

        public ICollection<AssignedVolunteer> AssignedVolunteers { get; set; }
    }

    
}


