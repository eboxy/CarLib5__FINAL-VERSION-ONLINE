using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Car.Entities;


namespace CarServices
{
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        List<Car.Entities.Car> GetCars();

        [OperationContract]
        void Add(Car.Entities.Car car);

        [OperationContract]
        void Delete(Car.Entities.Car car);

        [OperationContract]
        void Update(Car.Entities.Car car);

    }
}
