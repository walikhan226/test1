﻿using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data
{
    public class HrDbContext : DbContext
    {


        public DbSet<Employee> Employees { get; set; }
    }
}
