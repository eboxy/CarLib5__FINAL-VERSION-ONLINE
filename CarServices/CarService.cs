using CarServices;
using System.Collections.Generic;
using System.Linq;
using Car.Data;
using Car.Entities;
using System;
using System.ServiceModel;
using System.Data.Entity;

namespace CarServices
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
    public class CarService : ICarService, IDisposable
    {
        private readonly CarDbContext _Context = new CarDbContext();


         void ICarService.Add(Car.Entities.Car car)
        {
            _Context.Cars.Add(car);
            _Context.SaveChanges();
        }



        void ICarService.Delete(Car.Entities.Car car)
        {
            _Context.Entry(car).State = EntityState.Deleted;      
            _Context.SaveChanges();          

        }



        List<Car.Entities.Car> ICarService.GetCars()
        {
            return _Context.Cars.ToList();
        }


        
        void ICarService.Update(Car.Entities.Car car)
        {
            _Context.Entry(car).State = EntityState.Modified;          
            _Context.SaveChanges();
        }



        public void Dispose()
        {
            _Context.Dispose();
        }


    }
}
