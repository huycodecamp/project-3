﻿using DEMO_PROJECT_C2108G3_Delivery.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DEMO_PROJECT_C2108G3_Delivery.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		//private DataSeeding _seeding;
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
			DataSeeding.SeedingPostalService(this);
		}
		public DbSet<PostalService> PostalServices { get; set; }
        public DbSet<Tracking> Trackings { get; set; }
        public DbSet<TrackingDetail> TrackingDetails { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
    }
}