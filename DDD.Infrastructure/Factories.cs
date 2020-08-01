using DDD.Domain;
using DDD.Domain.Repositories;
using DDD.Infrastructure.Data;
using DDD.Infrastructure.Fake;
using DDD.Infrastructure.SQLite;

namespace DDD.Infrastructure
{
    public static class Factories
    {
        public static IWeatherRepository CreateWeather()
        {
            // DEBUG定数はプロジェクトのプロパティで、[ビルド]-[全般]-[DEBUG定数の定義]にチェックを付ける必要がある。（初期状態ではチェックがなく、動かなかった。
#if DEBUG

            if (Shared.IsFake)
            {
                return new WeatherFake();
            }
#endif
            return new WeatherSQLite();
        }

        public static IAreasRepository CreateAreas()
        {
#if DEBUG
            if (Shared.IsFake)
            {
                return new AreasFake();
            }
#endif
            return new AreasSQLite();
        }
    }
}
