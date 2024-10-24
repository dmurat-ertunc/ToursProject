﻿using BusinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToursProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationsController : ControllerBase
    {
        private readonly IStationsService stationsService;
        public StationsController(IStationsService stationsService)
        {
            this.stationsService = stationsService;
        }
        [HttpGet]
        public IActionResult GetAllStations()
        {
            var values = stationsService.TGetAll().ToList();
            return Ok(values);
        }
    }
}
