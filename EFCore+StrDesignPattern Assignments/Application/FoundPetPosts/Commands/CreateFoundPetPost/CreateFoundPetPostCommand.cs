﻿using Domain;
using FindPetOwner;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FoundPetPosts.Commands.CreateFoundPetPost
{
    public class CreateFoundPetPostCommand: IRequest<FoundPetPost>
    {
        public User CreatedBy { get; set; }
        public List<Picture> Pictures { get; set; } = null;
        public string Phone { get; set; }
        public DateTime AvailabilityStart { get; set; }
        public DateTime AvailabilityEnd { get; set; }
        public string Comment { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public PostStatus PostStatus { get; set; } = PostStatus.Open;
    }
}
