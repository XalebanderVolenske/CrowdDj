﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrowdDj.BL.Diagram
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrators> Administrators { get; set; }
        public virtual DbSet<Guests> Guests { get; set; }
        public virtual DbSet<Parties> Parties { get; set; }
        public virtual DbSet<PartyGuests> PartyGuests { get; set; }
        public virtual DbSet<PartyTweets> PartyTweets { get; set; }
        public virtual DbSet<PlayLists> PlayLists { get; set; }
        public virtual DbSet<Tracks> Tracks { get; set; }
        public virtual DbSet<Votes> Votes { get; set; }
    }
}
