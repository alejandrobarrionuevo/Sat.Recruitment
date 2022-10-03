using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Domain.Entities
{
    public class NormalUser : User
    {
        public override void AddGift()
        {
            var percentage = 1M;

            if (Money > 100)
                percentage = 1.12M;
            else if (Money > 10)
                percentage = 1.08M;

            Money *= percentage;
        }
    }
}
