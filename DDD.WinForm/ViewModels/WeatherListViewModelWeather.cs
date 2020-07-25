﻿using DDD.Domain.Entities;

namespace DDD.WinForm.ViewModels
{
    public sealed class WeatherListViewModelWeather
    {
        private WeatherEntity _entity;
        public WeatherListViewModelWeather(WeatherEntity entity)
        {
            _entity = entity;
        }

        public string AreaId => _entity.AreaId.DisplayValue;
        public string AreaName => _entity.AreaName.ToString();
        public string DataDate => _entity.DataDate.ToString();
        public string Temperature => _entity.Temperature.DisplayValue;
        public string Confition => _entity.Condition.DisplayValue;
    }
}
