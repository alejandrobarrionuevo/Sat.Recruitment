﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Services.Abstractions
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
    }
}
