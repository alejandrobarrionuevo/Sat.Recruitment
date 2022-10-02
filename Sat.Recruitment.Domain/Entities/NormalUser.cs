using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Domain.Entities
{
    public class NormalUser : User
    {
        protected override void SetMoney(decimal money)
        {
            var percentage = 1M;

            if (money > 100)
                percentage = 1.12M;
            else if (money > 10)
                percentage = 1.08M;

            this.money = money * percentage;
        }
    }
}
