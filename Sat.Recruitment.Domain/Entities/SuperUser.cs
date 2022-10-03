using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Domain.Entities
{
    public class SuperUser : User
    {
        const decimal giftBase = 100;
        const decimal giftPercentage = 0.2M;
        public SuperUser()
            : base(giftBase, giftPercentage)
        {            
        }
    }
}
