﻿using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class EmployeeRepository : Repository<Employee, int>, IEmployeeRepository
    {
        public EmployeeRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        
        public async Task<bool> EmailExistAsync(string email)
        {
            return await PostgresContext.Employees.AnyAsync(e => e.Email == email);
        }
    }
}
