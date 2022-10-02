using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Domain.Entities
{
    public class PremiumUser : User
    {
        protected override void SetMoney(decimal money)
            => this.money = money * (money > 100 ? 2 : 1);
    }
}
