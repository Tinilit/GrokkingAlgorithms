using GrokkingAlgorithms.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace GrokkingAlgorithms.DataAccess
{
    public class AlgorithmsDbContext:DbContext
    {
        public AlgorithmsDbContext(DbContextOptions<AlgorithmsDbContext> options)
            :base(options)
        {

        }

        public DbSet<AlgorithmResult> AlgorithmsResults { get; set; }
    }
}
