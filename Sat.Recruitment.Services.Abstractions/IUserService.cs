
using Sat.Recruitment.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sat.Recruitment.Services.Abstractions
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<UserDTO> GetByNameAsync(string userName, CancellationToken cancellationToken = default);
        Task<bool> FindAsync(UserDTO user, CancellationToken cancellationToken = default);
        Task<UserDTO> CreateAsync(UserDTO user, CancellationToken cancellationToken = default);
    }
}
