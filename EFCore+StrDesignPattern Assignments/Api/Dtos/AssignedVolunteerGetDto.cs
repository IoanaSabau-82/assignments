using Domain;
using FindPetOwner;

namespace Api.Dtos
{
    public class AssignedVolunteerGetDto
    {
        public Guid Id { get; set; }
        public User AssignedTo { get; set; }
        public FoundPetPost Post { get; set; }
        public DateTime ScheduledTime { get; set; }
        public AssignedStatus AssignedStatus { get; set; }
    }
}
