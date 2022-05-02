using Application;
using FindPetOwner;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UserRepositoryProxy : IUserRepository
    {

        private UserRepository _userRepository;
        private FindPetOwnerContext _context;

        public UserRepositoryProxy()
        {
            _context = new FindPetOwnerContext();
            _userRepository = new UserRepository(_context);
        }

        public void CreateUser(User user)
        {
            FakeLogger();
            _userRepository.CreateUser(user);
        }

        public User GetUser(Guid id)
        {
            FakeLogger();
            return _userRepository.GetUser(id);

        }

        public void UpdateUser(User user)

        {
            FakeLogger();
            _userRepository.UpdateUser(user);
        }

        public void FakeLogger([CallerMemberName] string? caller = null)
        {
            Console.WriteLine($"{caller} was called");
        }       
    }
}
