using Sat.Recruitment.Contracts;
using Sat.Recruitment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Services.Factories
{
    public abstract class UsersFactory
    {
        /// <summary>
        /// Create a Entity User from model UserDTO
        /// </summary>
        /// <param name="user">UserDTO model to convert</param>
        /// <returns></returns>
        public abstract User CreateUser(UserDTO user);
    }
}
