using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.Fake
{
    public class WeatherFake : IWeatherRepository
    {
        public IReadOnlyList<WeatherEntity> GetData()
        {
            throw new NotImplementedException();
        }

        public WeatherEntity GetLatest(int areaId)
        {
            if (areaId == 1)
            {
                return new WeatherEntity(1, Convert.ToDateTime("2020/01/02 12:34:56"), 1, 22.3f);
            }
            else
            {
                return new WeatherEntity(1, Convert.ToDateTime("2020/01/02 12:34:56"), 3, 12.11f);
            }
        }

        public void Save(WeatherEntity weather)
        {
            throw new NotImplementedException();
        }
    }
}
