using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Catstagram.Models;

namespace Catstagram.Data
{
    public class CatstagramContext : DbContext
    {
        public CatstagramContext (DbContextOptions<CatstagramContext> options)
            : base(options)
        {
        }

        public DbSet<Catstagram.Models.Post> Post { get; set; } = default!;
    }
}
