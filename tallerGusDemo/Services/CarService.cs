using System.Collections.Generic;
using System.Linq;
using tallerGusDemo.Models;

namespace tallerGusDemo.Services
{
    public class CarService
    {
        public CarService()
        {

        }

        public Car GetCarByID(int CarID, DatabaseContext _Context)
        {
            return (from car in _Context.d_car
                    where car.CarID == CarID
                    select car).SingleOrDefault();
        }

        public List<Car> GetCarList(DatabaseContext _Context)
        {
            return (from CarList in _Context.d_car
                    select CarList).ToList();
        }

        public bool IsUserGuessWithin5kRange(int carID, int priceGuess, DatabaseContext _Context)
        {
            var data = (from car in _Context.d_car
                        where car.Price - 5000 <= priceGuess
                           && car.Price + 5000 >= priceGuess
                           && car.CarID == carID
                        select car).SingleOrDefault();

            return data != null; 
        }
    }
}
