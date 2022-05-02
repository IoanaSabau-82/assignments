using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StructuralPatterns.DecoratorPattern
{
    public class AddChat : BaseUserDecorator
    {
        public AddChat(IUser user) : base(user)
        {
        }

        public override string Activities()
        {
            return _user.Activities() + " + I can use the chat";
        }
 
    }
}
