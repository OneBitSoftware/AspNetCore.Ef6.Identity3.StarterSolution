using StarterSolution.Data.Models;
using StarterSolution.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterSolution.Web.Factories
{
    public static class CarModelFactory
    {
        public static CarViewModel CreateCarViewModel(Car car)
        {
            var carViewModel = new CarViewModel();

            carViewModel.Make = car.Make;
            carViewModel.Model = car.Model;
            carViewModel.Year = car.Year;

            return carViewModel;
        }

        public static IEnumerable<CarViewModel> CreateCarViewModels(IEnumerable<Car> cars)
        {
            var carViewModels = new List<CarViewModel>();

            foreach (var car in cars)
            {
                carViewModels.Add(CreateCarViewModel(car));
            }

            return carViewModels;
        }
    }
}
