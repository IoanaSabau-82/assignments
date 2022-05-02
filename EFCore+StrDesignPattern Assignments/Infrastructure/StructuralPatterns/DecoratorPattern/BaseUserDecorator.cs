using Infrastructure.StructuralPatterns.DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StructuralPatterns
{
    public abstract class BaseUserDecorator : IUser
    {
        protected IUser _user;

        public BaseUserDecorator(IUser user)
        {
            _user = user;
        }

        public abstract string Activities();

    }
}
