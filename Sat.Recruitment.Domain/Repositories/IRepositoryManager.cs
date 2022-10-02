using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Domain.Repositories
{
    public interface IRepositoryManager
    {
        IUserRepository UserRepository { get; }
    }
}
