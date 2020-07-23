using System;
using System.Data;
using System.Text;
using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DDDTest.Tests
{
    [TestClass]
    public class WeatherLatestViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var weatherMock = new Mock<IWeatherRepository>();
            weatherMock.Setup(x => x.GetLatest(1)).Returns(
                new WeatherEntity(1, Convert.ToDateTime("2020/01/01 12:34:56"), 2, 12.3f));

            weatherMock.Setup(x => x.GetLatest(2)).Returns(
new WeatherEntity(1, Convert.ToDateTime("2020/01/02 12:34:56"), 1, 22.3f));

            var viewModel = new WeatherLatestViewModel(weatherMock.Object);

            Assert.AreEqual("", viewModel.AreaIdText);
            Assert.AreEqual("", viewModel.DataDateText);
            Assert.AreEqual("", viewModel.ConditionText);
            Assert.AreEqual("", viewModel.TempertureText);

            viewModel.AreaIdText = "1";
            viewModel.Search();
            Assert.AreEqual("1", viewModel.AreaIdText);
            Assert.AreEqual("2020/01/01 12:34:56", viewModel.DataDateText);
            Assert.AreEqual("曇り", viewModel.ConditionText);
            Assert.AreEqual("12.30 ℃", viewModel.TempertureText);



            viewModel.AreaIdText = "2";
            viewModel.Search();
            Assert.AreEqual("2", viewModel.AreaIdText);
            Assert.AreEqual("2020/01/02 12:34:56", viewModel.DataDateText);
            Assert.AreEqual("晴れ", viewModel.ConditionText);
            Assert.AreEqual("22.30 ℃", viewModel.TempertureText);

        }

    }
}
