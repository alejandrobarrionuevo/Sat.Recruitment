using Sat.Recruitment.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Domain.Entities
{
    public abstract class User
    {
        readonly decimal giftBase;
        readonly decimal giftPercentage;

        public User()
        {
            giftBase = 0;
            giftPercentage = 0;
        }

        public User(decimal giftBase, decimal giftPercentage)
        {
            this.giftBase = giftBase;
            this.giftPercentage = giftPercentage;
        }

        public string Name { get; set; }
        string email;
        public string Email
        {
            get { return email; }
            set { email = EmailHelper.NormalizeEmail(value); }
        }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string UserType { get; set; }        
        public decimal Money { get; set; }
        /// <summary>
        /// Add a percentage gift of money to the account according to the amount of money and type of account
        /// </summary>
        public virtual void AddGift()
        => Money *= Money > giftBase ? (1 + giftPercentage) : 1;

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
                return false;
            else
            {
                User user = (User)obj;
                return user.Email == email || user.Phone == Phone || (user.Name == Name && user.Address == Address);
            }
        }
        public override int GetHashCode()
        => Name.GetHashCode();
    }
}
