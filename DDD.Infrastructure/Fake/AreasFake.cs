using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.Fake
{
    public class AreasFake : IAreasRepository
    {
        public IReadOnlyList<AreaEntity> GetData()
        {
            var list = new List<AreaEntity>();
            list.Add(new AreaEntity(1, "AAA"));
            list.Add(new AreaEntity(2, "BBB"));
            list.Add(new AreaEntity(3, "CCC"));
            return list;
        }
    }
}
