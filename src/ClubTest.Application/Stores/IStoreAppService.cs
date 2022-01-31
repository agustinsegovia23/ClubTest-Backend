using Abp.Application.Services;
using ClubTest.Stores.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClubTest.Store
{
    public interface IStoreAppService : IApplicationService
    {
        List<StoreDto> GetAll();
        Task<StoreDto> Get(int id);
        Task Create(StoreDto store);
        Task Update(StoreDto store);
        Task Delete(int id);
    }
}