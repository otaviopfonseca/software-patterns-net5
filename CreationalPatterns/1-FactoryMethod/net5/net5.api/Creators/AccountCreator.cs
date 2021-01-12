using net5.api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net5.api.Creators
{
    public abstract class AccountCreator
    {
        public abstract IAccount Create();
    }
}
