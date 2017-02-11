using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class ApplicationContextFactory : IDbContextFactory<ApplicationContext>
    {
        public ApplicationContext Create(DbContextFactoryOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
