﻿using Microsoft.AspNet.Identity;
using System;
using System.Threading.Tasks;

namespace Project_Tranquility.Data.Identity
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            return Task.FromResult(0);
            //throw new NotImplementedException();
        }
    }
}
