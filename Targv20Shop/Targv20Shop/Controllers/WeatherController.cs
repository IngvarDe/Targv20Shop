﻿using Microsoft.AspNetCore.Mvc;
using Targv20Shop.Core.Dtos.Weather;
using Targv20Shop.Core.ServiceInterface;
using Targv20Shop.Models.Weather;

namespace Targv20Shop.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherForecastServices _weatherForecastServices;

        public WeatherController
            (
                IWeatherForecastServices weatherForecastServices
            )
        {
            _weatherForecastServices = weatherForecastServices;
        }

        [HttpGet]
        public IActionResult SearchCity()
        {
            SearchCity vm = new SearchCity();

            return View(vm);
        }

        [HttpPost]
        public IActionResult SearchCity(SearchCity model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("City", "Weather", new { city = model.CityName});
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult City(string city)
        {
            WeatherResultDto dto = new WeatherResultDto();

            //vaja teha andmete edastamine service classi ja sealt andmete k'tte saamine l'bi dto classi.
            _weatherForecastServices.WeatherDetail(dto);

            CityViewModel model = new CityViewModel();

            model.EffectiveDate = dto.EffectiveDate;
            model.EffectiveEpochDate = dto.EffectiveEpochDate;
            model.Severity = dto.Severity;
            model.Text = dto.Text;
            model.Category = dto.Category;
            model.EndDate = dto.EndDate;
            model.EndEpochDate = dto.EndEpochDate;
            model.MobileLink = dto.MobileLink;
            model.Link = dto.Link;

            model.Date = dto.Date;
            model.EpochDate = dto.EpochDate;

            model.TempMinValue = dto.TempMinValue;
            model.TempMinUnit = dto.TempMinUnit;
            model.TempMinUnitType = dto.TempMinUnitType;

            model.TempMaxValue = dto.TempMaxValue;
            model.TempMaxUnit = dto.TempMaxUnit;
            model.TempMaxUnitType = dto.TempMaxUnitType;

            model.DayIcon = dto.DayIcon;
            model.DayIconPhrase = dto.DayIconPhrase;
            model.DayHasPrecipitation = dto.DayHasPrecipitation;
            model.DayPrecipitationType = dto.DayPrecipitationType;
            model.DayPrecipitationIntensity = dto.DayPrecipitationIntensity;

            model.NightIcon = dto.NightIcon;
            model.NightIconPhrase = dto.NightIconPhrase;
            model.NightHasPrecipitation = dto.NightHasPrecipitation;
            model.NightPrecipitationType = dto.NightPrecipitationType;
            model.NightPrecipitationIntensity = dto.NightPrecipitationIntensity;

            return View(model);
        }
    }
}
