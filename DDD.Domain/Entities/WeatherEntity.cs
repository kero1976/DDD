using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Entities
{
    public sealed class WeatherEntity
    {

        public int AreaId { get; }
        public DateTime DataDate { get; }
        public Condition Condition { get; }
        public Temperature Temperature { get; }

        public WeatherEntity(int areaId, DateTime dateTime, int condition, float temperature)
        {
            AreaId = areaId;
            DataDate = dateTime;
            Condition = new Condition(condition);
            Temperature = new Temperature(temperature);
        }

    }
}
