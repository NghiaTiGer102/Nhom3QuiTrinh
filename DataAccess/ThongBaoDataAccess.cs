﻿using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ThongBaoDataAccess : IThongBaoDataAccess
    {
        /// <summary>
        /// database
        /// </summary>
        private WebLapTrinhEntities db = new WebLapTrinhEntities();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IEnumerable<GET_DSThongBao_Result> GetDSThongBao(GetDSThongBaoParameter param)
        {
            return db.GET_DSThongBao(param.idaccount);
        }
    }
}
