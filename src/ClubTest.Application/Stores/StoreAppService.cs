
using ClubTest.Stores.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTest.Store
{
    public class StoreAppService : ClubTestAppServiceBase, IStoreAppService
    {
        public Task Create(StoreDto store)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StoreDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<StoreDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(StoreDto store)
        {
            throw new NotImplementedException();
        }
    }
}
