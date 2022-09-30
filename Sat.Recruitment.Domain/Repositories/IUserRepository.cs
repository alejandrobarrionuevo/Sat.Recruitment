using Sat.Recruitment.Contracts;
using Sat.Recruitment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sat.Recruitment.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserDTO>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<UserDTO> GetByNameAsync(string userName, CancellationToken cancellationToken = default);
        void Insert(UserDTO user);        
    }
}
