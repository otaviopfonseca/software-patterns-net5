using net5.api.Entities;
using net5.api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net5.api.Creators
{
    public class CheckingAccountCreator : AccountCreator
    {
        public override IAccount Create()
        {
            return new CheckingAccount();
        }
    }
}
