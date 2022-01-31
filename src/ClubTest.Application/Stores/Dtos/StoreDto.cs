using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ClubTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTest.Stores.Dtos
{
    [AutoMap(typeof(Store))]
    public class StoreDto : EntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
