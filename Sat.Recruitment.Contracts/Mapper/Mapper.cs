using Sat.Recruitment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Contracts.Mapper
{
    public static class Mapper
    {
        /// <summary>
        /// Convert from Entity User to Model UserDTO
        /// </summary>
        /// <param name="user">User entity to convert</param>
        /// <returns></returns>
        public static UserDTO ToUserDTO(this User user)
            => new UserDTO
            {
                Address = user.Address,
                Email = user.Email,
                Name = user.Name,   
                Phone = user.Phone,
                UserType = user.UserType,
                Money = user.Money.ToString(),
            };
    }
}
