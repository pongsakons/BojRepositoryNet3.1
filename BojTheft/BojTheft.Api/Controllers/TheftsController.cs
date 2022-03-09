using BojTheft.Bll.Interface;
using BojTheft.Bll.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BojTheft.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheftsController : ControllerBase
    {
        private readonly ITheftManager _theft;

        public TheftsController(ITheftManager theft)
        {
            _theft = theft;
        }

        [HttpGet()]
        public ActionResult Thefts()
        {
            List<TheftModel> thefts = _theft.GetThefts();
            return Ok(thefts);
        }

        [HttpGet("{id}")]
        public ActionResult Thefts(int id)
        {
            TheftModel theft = _theft.GetTheftById(id);
            return Ok(theft);
        }
    }
}
