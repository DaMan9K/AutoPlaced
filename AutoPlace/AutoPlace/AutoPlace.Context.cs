﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoPlace
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AutoEntities : DbContext
    {
        public AutoEntities()
            : base("name=AutoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }
    }
}
