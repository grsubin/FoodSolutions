﻿using foodSolutions.Model.USER.PUBLIC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace foodSolutions.Services.USER.PUBLIC
{
    public interface IUserRegisterServices
    {
        bool saveUserDetails(User user);
    }
}
