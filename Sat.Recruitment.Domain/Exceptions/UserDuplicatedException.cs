using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Domain.Exceptions
{
    public sealed class UserDuplicatedException : BadRequestException
    {
        public UserDuplicatedException()
            : base($"The user is duplicated")
        {
        }
    }
}
