﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathieuShopKornilova.Base
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MatueShopKornilovaEntities2 : DbContext
    {
        public MatueShopKornilovaEntities2()
            : base("name=MatueShopKornilovaEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Balances> Balances { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Collection> Collection { get; set; }
        public virtual DbSet<MasterService> MasterService { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
