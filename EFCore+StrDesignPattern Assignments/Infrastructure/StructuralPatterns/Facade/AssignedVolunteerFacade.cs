using Domain;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AssignedVolunteerFacade
    { 
        private AssignedVolunteerRepository _assignedVolRepository;
        private FindPetOwnerContext _context;
        private AssignmentUtils _utils;

    public AssignedVolunteerFacade()
    {
        _context = new FindPetOwnerContext();
        _assignedVolRepository = new AssignedVolunteerRepository(_context);
        _utils = new AssignmentUtils();
    }
        public void GetAssignedToPost(AssignedVolunteer assignedVolunteer) 
        { 

            _utils.CheckAvailability();
            _assignedVolRepository.CreateAssigned(assignedVolunteer);
            _utils.SendNotification();

        }
    }
}
