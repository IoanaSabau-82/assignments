using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPetOwner
{
    internal class Post
    {
        public int[] Pictures { get; set; }
        public string Phone { get; set; } //optional, can match or not the users details
        public string Address { get; set; } //optional, can match or not the users details

        public TimeOnly[] Availability { get; set; } //optional

        public string Comment { get; set; }
        
        public double[] GPSLocation { get; set; }

        public User User { get; set; }
        public Status status { get;}

        public Post(int[] pictures, string phone, string address, TimeOnly[] availability, string comment, double[] gpslocation, User user)
        {
            Pictures = pictures;
            Phone = phone;
            Address = address;
            Availability = availability;
            Comment = comment;
            GPSLocation = gpslocation;
            User = user;
            status = Status.deschisa;
        }
            public enum Status { deschisa, inCurs, inchisa }

        public override string ToString()
        {
            return $"{User}'s post";
        }




    }
}
