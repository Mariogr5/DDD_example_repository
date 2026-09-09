using Microsoft.EntityFrameworkCore;
using Submission.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Submission.Persistence
{
    public class SubmissionDbContext : DbContext
    {
        #region Entities
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
