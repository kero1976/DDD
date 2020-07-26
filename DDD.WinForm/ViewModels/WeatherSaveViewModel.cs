using DDD.Domain.Entities;
using DDD.Domain.Exceptions;
using DDD.Domain.Helper;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;
using DDD.Infrastructure.Data;
using DDD.Infrastructure.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.WinForm.ViewModels
{
    public class WeatherSaveViewModel : ViewModelBase
    {
        private IAreasRepository _areas;
        private IWeatherRepository _weather;

        public object SelectedAreaId { get; set; }
        public DateTime DataDateValue { get; set; }
        public object SelectedCondition { get; set; }
        public string TemperatureText { get; set; }
        public BindingList<AreaEntity> Areas { get; set; } = new BindingList<AreaEntity>();
        public BindingList<Condition> Conditions { get; set; } = new BindingList<Condition>(Condition.ToList());
        public string TemperatureUnitName => Temperature.UnitName;

        public WeatherSaveViewModel(IWeatherRepository weather, IAreasRepository areas)
        {
            _areas = areas;
            _weather = weather;

            DataDateValue = GetDateTime();
            SelectedCondition = Condition.Sunny.Value;
            TemperatureText = string.Empty;

            foreach (var area in _areas.GetData())
            {
                Areas.Add(new AreaEntity(area.AreaId, area.AreaName));
            }
        }

        public WeatherSaveViewModel() : this(new WeatherSQLite(), new AreasSQLite())
        {
        }

        public void Save()
        {
            Guard.IsNull(SelectedAreaId, "エリアを選択してください");

            var temperature = Guard.IsFloat(TemperatureText, "温度の入力に誤りがあります");

            var entity = new WeatherEntity(
                //Convert.ToInt32(SelectedAreaId),
                ((AreaId)SelectedAreaId).Value,
                DataDateValue,
                Convert.ToInt32(SelectedCondition),
                temperature);

            _weather.Save(entity);
        }
    }
}
