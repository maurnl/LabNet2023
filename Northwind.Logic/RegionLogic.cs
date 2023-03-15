using Northwind.Data;
using Northwind.Data.Abstractions;
using Northwind.Entities;
using Northwind.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Logic
{
    public class RegionLogic : IABMLogic<Region>, IEnumAllLogic<Region>
    {
        private readonly IGenericRepository<Region> _regionsRepo;

        public RegionLogic()
        {
            _regionsRepo = new GenericRepository<Region>();
        }

        public IEnumerable<Region> GetAll()
        {
            return _regionsRepo.GetAll().ToList();
        }

        public void Add(Region newRegion)
        {
            _regionsRepo.Add(newRegion);
            _regionsRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            var regionAEliminar = _regionsRepo.FindById(id);

            if(regionAEliminar == null)
            {
                throw new ArgumentException($"No se pudo encontrar la region id {id}", nameof(regionAEliminar));
            }

            _regionsRepo.Delete(regionAEliminar);
            _regionsRepo.SaveChanges();
        }

        public void Update(Region region)
        {
            var regionToUpdate = _regionsRepo.FindById(region.RegionID);

            if (regionToUpdate == null)
            {
                throw new ArgumentException($"No se pudo encontrar la region id {region.RegionID}", nameof(regionToUpdate));
            }

            regionToUpdate.RegionDescription = region.RegionDescription;

            _regionsRepo.SaveChanges();

        }
    }
}
