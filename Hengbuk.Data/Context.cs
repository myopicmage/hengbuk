using Hengbuk.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hengbuk.Data
{
    public class Context : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserResponse> Responses { get; set; }
        public DbSet<UserResponseLines> ResponseLines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hengbuk.db");
        }
    }
}
