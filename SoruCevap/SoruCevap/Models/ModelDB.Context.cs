﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SoruCevap.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class DB04Entities : DbContext
{
    public DB04Entities()
        : base("name=DB04Entities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Answer> Answer { get; set; }

    public virtual DbSet<Category> Category { get; set; }

    public virtual DbSet<Question> Question { get; set; }

    public virtual DbSet<User> User { get; set; }

}

}
