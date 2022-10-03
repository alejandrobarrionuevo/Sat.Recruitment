using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Domain.Entities
{
    public class PremiumUser : User
    {
        const decimal giftBase = 100;
        const decimal giftPercentage = 2M;
        public PremiumUser()
            : base(giftBase, giftPercentage)
        {
        }
    }
}
