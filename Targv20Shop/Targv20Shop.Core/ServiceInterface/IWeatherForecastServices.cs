using System.Threading.Tasks;
using Targv20Shop.Core.Dtos.Weather;


namespace Targv20Shop.Core.ServiceInterface
{
    public interface IWeatherForecastServices
    {
        Task<WeatherResultDto> WeatherDetail(WeatherResultDto dto);
    }
}
