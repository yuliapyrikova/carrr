using carrr.Domain;
using carrr.Repository;
using Microsoft.AspNetCore.Mvc;

namespace carrr.Controllers
{
    [ApiController]
    [Route("/car")]
    public class CarController : ControllerBase
    {
        [HttpPut]
        public Car Create(Car car)
        {
            Storage.CarStorage.Create(car);
            return car;
        }

        [HttpGet]
        public Car Read(int carId)
        {
            return Storage.CarStorage.Read(carId);
        }

        [HttpPost]
        public Car Update(int carId, Car newCar)
        {
            return Storage.CarStorage.Update(carId, newCar);
        }

        [HttpDelete]
        public bool Delete(int carId)
        {
            return Storage.CarStorage.Delete(carId); ;
        }
    }
}