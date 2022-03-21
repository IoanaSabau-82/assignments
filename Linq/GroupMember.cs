using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPetOwner
{
    internal class GroupMember : User
    {
        public GroupMember(string surname, string name, string phone = "", string address = "") : base(surname, name, phone, address)
        {
        }
    }
}
