﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
