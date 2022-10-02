using Sat.Recruitment.Contracts;
using Sat.Recruitment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Services.Factories
{
    public class UsersCreator : UsersFactory
    {
        public override User CreateUser(UserDTO user)
        {
            User newUser = 
                user.UserType switch
            {
                "SuperUser" => new SuperUser(),
                "Premium" => new PremiumUser(),
                _ => new NormalUser(),
            };

            newUser.Address = user.Address;
            newUser.Phone = user.Phone;
            newUser.UserType = user.UserType;
            newUser.Name = user.Name;
            newUser.Email = user.Email;
            newUser.Money = decimal.TryParse(user.Money, out decimal money) ? money : 0;

            return newUser;
        }
    }
}
