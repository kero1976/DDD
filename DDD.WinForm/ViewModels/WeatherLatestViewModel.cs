using DDD.Domain.Repositories;
using DDD.Infrastructure.Data;
using System;
using System.ComponentModel;

namespace DDD.WinForm.ViewModels
{
    public class WeatherLatestViewModel : ViewModelBase
    {
        private IWeatherRepository _weather;

        private string _areaIdText = string.Empty;
        public string AreaIdText
        {
            get
            {
                return _areaIdText;
            }
            set
            {
                SetProperty(ref _areaIdText, value);
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


        public WeatherLatestViewModel(IWeatherRepository weather)
        {
            _weather = weather;
        }
        public WeatherLatestViewModel() : this(new WeatherSQLite())
        {
        }
        public void Search()
        {
            var entity = _weather.GetLatest(Convert.ToInt32(AreaIdText));
            if (entity != null)
            {
                DataDateText = entity.DataDate.ToString();
                ConditionText = entity.Condition.DisplayValue;
                TempertureText = entity.Temperature.DisplayValue;
            }
        }
    }
}
