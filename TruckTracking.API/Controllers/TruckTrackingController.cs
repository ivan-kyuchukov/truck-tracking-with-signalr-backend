using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.SignalR;

namespace TruckTracking.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TruckTrackingController : ControllerBase
    {
        private readonly ILogger<TruckTrackingController> _logger;

        public TruckTrackingController(ILogger<TruckTrackingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "test";
        }
    }
}
