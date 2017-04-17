namespace StarterSolution.Web.Services
{
    using StarterSolution.Data;
    using StarterSolution.Data.Models;
    using StarterSolution.Web.Factories;
    using StarterSolution.Web.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CarService : ICarService
    {
        private ICarsRepository _carsRepository;

        public CarService(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository ?? throw new ArgumentNullException(nameof(carsRepository));
        }

        public async Task<CarViewModel> CreateCarAsync(Car car)
        {
            var createdCar = await _carsRepository.AddAsync(car);
            return CarModelFactory.CreateCarViewModel(createdCar);
        }

        public async Task<IEnumerable<CarViewModel>> GetCarsAsync()
        {
            var cars = await _carsRepository.GetAllAsync();
            return CarModelFactory.CreateCarViewModels(cars);
        }
    }
}
