using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookApi.Model;

namespace BookApi.Data
{
    public class BookApiContext : DbContext
    {
        public BookApiContext (DbContextOptions<BookApiContext> options)
            : base(options)
        {
        }

        public DbSet<BookApi.Model.Crypto> Crypto { get; set; } = default!;
    }
}
