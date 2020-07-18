using DDD.Domain.Repositories;
using DDD.WinForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.WinForm.ViewModels
{
    public class WeatherLatestViewModel
    {
        private IWeatherRepository _weather;

        public string AreaIdText { get; set; } = string.Empty;
        public string DataDateText { get; set; } = string.Empty;
        public string ConditionText { get; set; } = string.Empty;
        public string TempertureText { get; set; } = string.Empty;

        public WeatherLatestViewModel(IWeatherRepository weather)
        {
            _weather = weather;
        }
        public void Search()
        {
            var entity = _weather.GetLatest(Convert.ToInt32(AreaIdText));
            if (entity != null)
            {
                DataDateText = entity.DataDate.ToString();
                ConditionText = entity.Condition.ToString();
                TempertureText = entity.Temperature.DisplayValue;
            }
        }
    }
}
