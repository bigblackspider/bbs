﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BBS.Core.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BBSEntities : DbContext
    {
        public BBSEntities()
            : base("name=BBSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerPreoduct> CustomerPreoducts { get; set; }
        public virtual DbSet<MailAccount> MailAccounts { get; set; }
        public virtual DbSet<MailAliasName> MailAliasNames { get; set; }
        public virtual DbSet<MailBox> MailBoxes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<WebsiteItem> WebsiteItems { get; set; }
        public virtual DbSet<Website> Websites { get; set; }
    }
}
