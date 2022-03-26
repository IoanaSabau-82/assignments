using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPetOwner
{
    internal class NonGroupMember : User
    {
        public NonGroupMember(int id, string surname, string name, string phone = "", string address = "") : base(id, surname, name, phone, address)
        {
        }
    }
}
