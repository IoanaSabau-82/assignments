using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StructuralPatterns.DecoratorPattern
{
    public class UserForPattern : IUser
    {
        public string Activities()
        {
            return "basic";
        }
    }


}
