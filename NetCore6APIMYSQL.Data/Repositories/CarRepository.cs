using NetCore6APIMYSQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore6APIMYSQL.Data.Repositories
{
    public class CarRepository : ICarRepository
    {
        public Task<bool> DeleteCar(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertCar(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
