using Sat.Recruitment.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Domain.Entities
{
    public abstract class User
    {
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
        protected decimal money;
        public decimal Money
        {
            get { return money; }
            set { SetMoney(value); }
        }

        protected abstract void SetMoney(decimal money);

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
