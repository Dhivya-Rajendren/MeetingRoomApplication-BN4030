﻿using Microsoft.EntityFrameworkCore;
using MeetingRoom.Domain;

namespace MeetingRoom.Data
{
    public class MeetingRoomDbContext:DbContext
    {


        public DbSet<MeetingRoom.Domain.MeetingRoom> tbl_MeetingRooms { get; set; }

        public DbSet<Meeting> tbl_Meetings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //SQL Server is the provider and we need the information about the server, database, Authentication details

            optionsBuilder.UseSqlServer("Server=Dhivya-pc\\SQLExpress;Database=MeetingRoomDB_BN4030;integrated security=true");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //setting the global query filters

            modelBuilder.Entity<MeetingRoom.Domain.MeetingRoom>().HasQueryFilter(m => m.IsActive);
            modelBuilder.Entity<Meeting>().HasQueryFilter(m => m.IsActive);
        }

        //SQL Server  and we need the information about the server, database, Authentication details
    }
}