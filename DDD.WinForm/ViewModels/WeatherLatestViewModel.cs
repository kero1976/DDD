using DDD.Domain.Repositories;
using DDD.Infrastructure.Data;
using System;
using System.ComponentModel;

namespace DDD.WinForm.ViewModels
{
    public class WeatherLatestViewModel : INotifyPropertyChanged
    {
        private IWeatherRepository _weather;

        public event PropertyChangedEventHandler PropertyChanged;

        private string _areaIdText = string.Empty;
        public string AreaIdText
        {
            get
            {
                return _areaIdText;
            }
            set
            {
                if (_areaIdText == value)
                {
                    return;
                }
                _areaIdText = value;
                OnPropertyChanged(nameof(AreaIdText));
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
                if (_dataDateText == value)
                {
                    return;
                }
                _dataDateText = value;
                OnPropertyChanged(nameof(DataDateText));
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
                if (_conditionText == value)
                {
                    return;
                }
                _conditionText = value;
                OnPropertyChanged(nameof(ConditionText));
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
                if (_tempertureText == value)
                {
                    return;
                }
                _tempertureText = value;
                OnPropertyChanged(nameof(TempertureText));
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
            //OnPropertyChanged("");
        }
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
