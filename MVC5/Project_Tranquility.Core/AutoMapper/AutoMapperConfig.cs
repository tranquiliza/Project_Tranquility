using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Project_Tranquility.Core.AutoMapper
{
    public class AutoMapperConfig
    {
        public void InitializeMappings()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<EntityFramework.Models.MaintainanceTask, DomainEntities.MaintainanceTask>());
        }
    }
}
