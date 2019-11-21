using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace quotable.core
{
    /// <summary>
    /// The database context that provides access to Quote
    /// </summary>
    public class QuoteContext :DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public QuoteContext(DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        /// used to access quotes in the database.
        /// </summary>
        public DbSet<Quote>Quotes { get; set; }

        /// <summary>
        /// used to access authors in the db
        /// </summary>
        public DbSet<Author> Authors { get; set; }

        /// <summary>
        /// Inherited.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuoteAuthor>().HasKey(x => new { x.QuoteId, x.AuthorId });
        }
    }
}
