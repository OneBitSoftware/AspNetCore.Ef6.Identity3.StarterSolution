using StarterSolution.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterSolution.Data
{
    public class CarsRepository : EntityFrameworkRepository<Car>, ICarsRepository
    {
        public CarApplicationDbContext CarsContext
        {
            get { return Context as CarApplicationDbContext;}
        }

        public CarsRepository(CarApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Car> GetTopSellingCars(int count)
        {
            return CarsContext.Cars.Take(10).ToList();
        }
    }
}
