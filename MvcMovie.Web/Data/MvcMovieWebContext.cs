using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Web.Models;

namespace MvcMovie.Web.Data
{
    public class MvcMovieWebContext : DbContext
    {
        public MvcMovieWebContext (DbContextOptions<MvcMovieWebContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Web.Models.Movie> Movie { get; set; } = default!;
    }
}
