using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Infrastructure.Data;
using DDD.Infrastructure.SQLite;
using System;
using System.ComponentModel;

namespace DDD.WinForm.ViewModels
{
    public class WeatherLatestViewModel : ViewModelBase
    {
        private IWeatherRepository _weather;
        private IAreasRepository _areas;

        private object _selectedAreaId;
        public object SelectedAreaId
        {
            get
            {
                return _selectedAreaId;
            }
            set
            {
                SetProperty(ref _selectedAreaId, value);
            }
        }

        private string _dataDateText = string.Empty;
        public string DataDateText
        {
            get
            {
                return _dataDateText;
            }
            set
            {
                SetProperty(ref _dataDateText, value);
            }
        }

        private string _conditionText = string.Empty;
        public string ConditionText
        {
            get
            {
                return _conditionText;
            }
            set
            {
                SetProperty(ref _conditionText, value);
            }
        }

        private string _tempertureText = string.Empty;
        public string TempertureText
        {
            get
            {
                return _tempertureText;
            }
            set
            {
                SetProperty(ref _tempertureText, value);
            }
        }

        public BindingList<AreaEntity> Areas { get; set; } = new BindingList<AreaEntity>();

        public WeatherLatestViewModel(IWeatherRepository weather,IAreasRepository areas)
        {
            _weather = weather;
            _areas = areas;

            foreach(var area in _areas.GetData())
            {
                Areas.Add(new AreaEntity(area.AreaId, area.AreaName));
            }
        }
        public WeatherLatestViewModel() : this(new WeatherSQLite(), new AreasSQLite())
        {
        }
        public void Search()
        {
            var entity = _weather.GetLatest(Convert.ToInt32(SelectedAreaId));
            if (entity == null)
            {
                DataDateText = string.Empty;
                ConditionText = string.Empty;
                TempertureText = string.Empty;
            }
            else
            {
                DataDateText = entity.DataDate.ToString();
                ConditionText = entity.Condition.DisplayValue;
                TempertureText = entity.Temperature.DisplayValue;
            }
        }
    }
}
