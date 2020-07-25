using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Entities
{
    public sealed class WeatherEntity
    {

        public AreaId AreaId { get; }
        public string AreaName { get; }
        public DateTime DataDate { get; }
        public Condition Condition { get; }
        public Temperature Temperature { get; }


        public WeatherEntity(int areaId, DateTime dateTime, int condition, float temperature) : 
            this(areaId,string.Empty,dateTime,condition,temperature)
        {
        }

        public WeatherEntity(int areaId, string areaName, DateTime dateTime, int condition, float temperature)
        {
            AreaId = new AreaId(areaId);
            AreaName = areaName;
            DataDate = dateTime;
            Condition = new Condition(condition);
            Temperature = new Temperature(temperature);
        }

    }
}
