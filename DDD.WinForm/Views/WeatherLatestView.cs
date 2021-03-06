﻿using DDD.Domain.Entities;
using DDD.Infrastructure;
using DDD.Infrastructure.Fake;
using DDD.WinForm.ViewModels;
using DDD.WinForm.Views;
using System;

using System.Linq;

using System.Windows.Forms;

namespace DDD.WinForm
{
    public partial class WeatherLatestView : Form
    {
        private WeatherLatestViewModel _viewModel
            = new WeatherLatestViewModel(Factories.CreateWeather(), Factories.CreateAreas());
        public WeatherLatestView()
        {
            InitializeComponent();

            this.AreasComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AreasComboBox.DataBindings.Add(
                "SelectedValue", _viewModel, nameof(_viewModel.SelectedAreaId));
            this.AreasComboBox.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.Areas));
            this.AreasComboBox.ValueMember = nameof(AreaEntity.AreaId);
            this.AreasComboBox.DisplayMember = nameof(AreaEntity.AreaName);
            this.DataDateLabel.DataBindings.Add(
                 "Text", _viewModel, nameof(_viewModel.DataDateText));
            this.ConditionLabel.DataBindings.Add(
                "Text", _viewModel, nameof(_viewModel.ConditionText));
            this.TemperatureLabel.DataBindings.Add(
                "Text", _viewModel, nameof(_viewModel.TempertureText));
        }

        private void LatestBtn_Click(object sender, EventArgs e)
        {
            _viewModel.Search();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            using(var f = new WeatherListView())
            {
                f.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new WeatherSaveView())
            {
                f.ShowDialog();
            }
        }
    }
}
