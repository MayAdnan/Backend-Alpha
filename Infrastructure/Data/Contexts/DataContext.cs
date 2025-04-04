﻿using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Contexts
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public virtual DbSet<ProjectEntity> Projects { get; set; } = null!;
        public virtual DbSet<ClientEntity> Clients { get; set; } = null!;
        public virtual DbSet<UserEntity> Users { get; set; } = null!;
        public virtual DbSet<StatusEntity> Statuses{ get; set; } = null!;
    }

}
