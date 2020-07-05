using GrokkingAlgorithms.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.DataAccess.Repositories
{
    public interface IAlgorithmResultRepository
    {
        Task<bool> AddResult(AlgorithmResult result);
        Task<bool> DeleteResult(int Id);
        Task<IEnumerable<AlgorithmResult>> GetResults();
        Task<AlgorithmResult> GetResult(int Id);
    }

    public class AlgorithmResultRepository : IAlgorithmResultRepository
    {
        private readonly AlgorithmsDbContext _context;

        public AlgorithmResultRepository(AlgorithmsDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddResult(AlgorithmResult result)
        {
            _context.AlgorithmsResults.Add(result);
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<AlgorithmResult> GetResult(int Id)
        {
            return await _context.AlgorithmsResults.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<bool> DeleteResult(int Id)
        {
            var result = await _context.AlgorithmsResults.FirstOrDefaultAsync(x => x.Id == Id);

            if (result != null)
            {
                _context.AlgorithmsResults.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<AlgorithmResult>> GetResults()
        {
            return await _context.AlgorithmsResults.ToListAsync();
        }
    }
}
