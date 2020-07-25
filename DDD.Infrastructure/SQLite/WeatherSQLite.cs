using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Infrastructure.SQLite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DDD.Infrastructure.Data
{
    public class WeatherSQLite : IWeatherRepository
    {
        public IReadOnlyList<WeatherEntity> GetData()
        {
            string sql = @"
select A.areaId,B.AreaName,A.DataDate,A.Condition,A.Temperature
from Weather a left outer join Areas B
where A.areaId = B.AreaId";

            return SQLiteHelper.Query(sql, reader =>
            {
                return new WeatherEntity(
                    Convert.ToInt32(reader["AreaId"]),
                    Convert.ToString(reader["AreaName"]),
                    Convert.ToDateTime(reader["DataDate"]),
                    Convert.ToInt32(reader["Condition"]),
                    Convert.ToSingle(reader["Temperature"]));
            });
        }

        public WeatherEntity GetLatest(int areaId)
        {
            String sql = @"select DataDate, Condition, Temperature from Weather 
where AreaId = @AreaId order by DataDate desc LIMIT 1";
            return SQLiteHelper.QuerySingle<WeatherEntity>(sql,
                new List<SQLiteParameter>
                {
                    new SQLiteParameter("@AreaId", areaId)
                }.ToArray(),

                reader =>
            {
                return new WeatherEntity(
                    areaId,
                    Convert.ToDateTime(reader["DataDate"]),
                    Convert.ToInt32(reader["Condition"]),
                    Convert.ToSingle(reader["Temperature"])
                    );
            }, null);

        }
    }
}
