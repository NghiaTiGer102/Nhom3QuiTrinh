﻿using BusinessLogicInterface;
using BusinessLogicInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAcceessInterface.Parameter;
using BaseApplication;

namespace api.Controllers
{
    public class CauHoiController : ApiController
    {
        private readonly ICauHoiBusinessLogic _businessLogic;

        public CauHoiController(ICauHoiBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetDSCauHoi(GetDSCauHoiParameter request)
        {
            var result = _businessLogic.GetDSCauHoi(request);
            return new ActionResult<GetDSCauHoiResponse>(result.Result, Request);
        }
    }
}
