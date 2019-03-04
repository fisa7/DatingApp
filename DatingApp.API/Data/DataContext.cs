﻿using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { } //konstruktor zdedeny
        
        public DbSet<Value> Values { get; set; } //pro tabulku v SQL
        public DbSet<User> Users { get; set; }
    }
}
