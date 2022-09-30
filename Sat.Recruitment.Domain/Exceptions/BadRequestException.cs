using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Domain.Exceptions
{
    public abstract class BadRequestException : Exception
    {
        protected BadRequestException(string message)
            : base(message)
        {
        }
    }
}
