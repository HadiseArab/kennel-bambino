using System;
using System.Collections.Generic;
using System.Text;
using kennel_bambino.web1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace kennel_bambino.web1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #region Pet

        public DbSet<Group> Groups { get; set; }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<EyeColor> EyeColors { get; set; }

        public DbSet<Pattern> Patterns { get; set; }

        public DbSet<BodyType> BodyTypes { get; set; }

        public DbSet<Photo> Photos { get; set; }

        #endregion

        #region Carousel

        public DbSet<Carousel> Carousels { get; set; }

        #endregion

        #region Contact

        public DbSet<Contact> Contacts { get; set; }

        #endregion
    }
}
