namespace StarterSolution.Data
{
    using StarterSolution.Data.Interfaces;
    using System.Threading.Tasks;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarApplicationDbContext _context;

        public IPartsRepository Parts { get; private set; }

        public ICarsRepository Cars { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
