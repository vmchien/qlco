﻿using QLCO.DAL;
using QLCO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCO.BLL
{
    public class TangBLL
    {
        TangDAL dal = new TangDAL();
        public Tang[] GetList()
        {
            return dal.GetList();
        }
        public bool Add(Tang k)
        {
            try
            {
                return dal.Add(k);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Remove(string id)
        {
            try
            {
                return dal.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(Tang bs)
        {
            try
            {
                return dal.Update(bs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tang Search(string id)
        {
            return dal.Search(id);
        }
    }
}
