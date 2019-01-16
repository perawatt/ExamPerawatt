using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace accumulatedinterest.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        public Calculator svc = new Calculator();

        // GET api/values/5
        [HttpGet("{percent}/{balance}/{year}")]
        public List<Interest> Get(double percent, double balance,int year)
        {
            return svc.GetInterestPerYear(percent, balance, year);
        }
    }

    public class Interest
    {
        public int Year { get; set; }
        public double OutstandingPerYear { get; set; }
        public double InterestPerYear { get; set; }
        public double SummaryPerYear { get; set; }
    }
}
