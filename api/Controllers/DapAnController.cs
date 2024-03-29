﻿using System.Web.Http;
using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Response;
using DataAcceessInterface.Parameter;

namespace api.Controllers
{
    public class DapAnController : ApiController
    {
        private readonly IDapAnBusinessLogic _businessLogic;

        public DapAnController(IDapAnBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// ListDapAn
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult ListDapAn(GetDsDapAnParameter param)
        {
            var result = _businessLogic.GetDSDapByBaiHoc(param);
            return new ActionResult<ListDapAnResponse>(result.Result, Request);
        }
    }
}