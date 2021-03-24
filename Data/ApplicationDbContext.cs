using BoxingThemis.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingThemis.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<BoxingMatch> BoxingMatches { get; set; }
        public DbSet<Judge> Judges { get; set; }

    }
}
