﻿using DDD.WinForm.Common;
using DDD.WinForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD.WinForm
{
    public partial class WeatherLatestView : Form
    {
        public WeatherLatestView()
        {
            InitializeComponent();
        }

        private void LatestBtn_Click(object sender, EventArgs e)
        {
            var dt = WeatherSQLite.GetLatest(Convert.ToInt32(AreaIdTextBox.Text));

            if(dt.Rows.Count > 0)
            {
                DataDateLabel.Text = dt.Rows[0]["DataDate"].ToString();
                ConditionLabel.Text = dt.Rows[0]["Condition"].ToString();
                TemperatureLabel.Text =
                    CommonFunc.RoundString(Convert.ToSingle(dt.Rows[0]["Temperature"].ToString()), CommonConst.TemperarureDecimalPoint) + CommonConst.TemperatureUnitName;
            }
        }
    }
}
