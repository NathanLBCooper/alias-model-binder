﻿using Microsoft.AspNetCore.Mvc;

namespace DelimitedCollectionValueProvider.ExampleApp.Web.Controllers
{
    [Route("test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("echoCollectionRaw")]
        public ActionResult<int[]> EchoCollectionRaw([FromQuery] int[] integers)
        {
            if (integers == null)
            {
                return base.BadRequest();
            }

            return integers;
        }

        [HttpGet]
        [Route("echoCollectionModel")]
        public ActionResult<int[]> EchoCollectionModel([FromQuery] EchoCollectionRequest request)
        {
            if (request?.Integers == null)
            {
                return base.BadRequest();
            }

            return request.Integers;
        }
    }
}
