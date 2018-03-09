using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MvcMovie_Tarquinio.Models;

namespace MvcMovie_Tarquinio.Models
{
    public class MvcMovie_TarquinioContext : DbContext
    {
        public MvcMovie_TarquinioContext (DbContextOptions<MvcMovie_TarquinioContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }

        public DbSet<MvcMovie_Tarquinio.Models.Reviews> Reviews { get; set; }
    }
}
