using Best_Practices.Infraestructure.Singletons;
using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Repositories
{
    public class MyVehiclesRepository : IVehicleRepository
    {
        //removed the static Vehicle Collection. We used an encapsulated list.
        private readonly List<Vehicle> _vehicles;

        public MyVehiclesRepository()
        {
            _vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public Vehicle Find(string id)
        {
            return _vehicles.FirstOrDefault(v => v.ID.Equals(new Guid(id)));
        }

        public ICollection<Vehicle> GetVehicles()
        {
            return _vehicles;
        }

        
    }
}
