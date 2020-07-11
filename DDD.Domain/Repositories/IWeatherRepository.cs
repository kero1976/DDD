using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DDD.Domain.Repositories
{
    public interface IWeatherRepository
    {
        WeatherEntity GetLatest(int areaId);
    }
}
