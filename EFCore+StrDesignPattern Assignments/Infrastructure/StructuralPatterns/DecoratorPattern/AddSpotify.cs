using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StructuralPatterns.DecoratorPattern
{
    public class AddSpotify : BaseUserDecorator
    {
        public AddSpotify(IUser user) : base(user)
        {
        }

        public override string Activities()
        {
            return _user.Activities() + "+ I can listen to music";
        }
    }
}
