using net5.api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net5.api.Entities
{
    public class Account : IAccount
    {
        private Guid _id;
        private Double _balance;

        public virtual Double Balance
        {
            get => _balance;
            protected set => _balance = value;
        }
        public virtual Guid Id
        {
            get => _id;
            protected set => _id = value;
        }
        protected Account() => Id = Guid.NewGuid();
    }
}
