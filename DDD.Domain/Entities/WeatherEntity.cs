using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Entities
{
    public sealed class WeatherEntity
    {

        public int AreaId { get; }
        public DateTime DataDate { get; }
        public int Condition { get; }
        public float Temperature { get; }

        public WeatherEntity(int areaId, DateTime dateTime, int condition, float temperature)
        {
            AreaId = areaId;
            DataDate = dateTime;
            Condition = condition;
            Temperature = temperature;
        }

    }
}
