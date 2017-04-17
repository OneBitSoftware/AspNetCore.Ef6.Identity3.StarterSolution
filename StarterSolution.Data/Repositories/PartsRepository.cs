using StarterSolution.Data.Interfaces;
using StarterSolution.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterSolution.Data.Repositories
{
    public class PartsRepository : EntityFrameworkRepository<Part>, IPartsRepository
    {
        public CarApplicationDbContext CarsContext
        {
            get { return Context as CarApplicationDbContext; }
        }

        public PartsRepository(CarApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Part> GetPartsForCar(Car car)
        {
            return CarsContext.Parts.Take(10).ToList();
        }
    }
}
