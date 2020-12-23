using QLBV_Demo.DAL;
using QLCO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCO.DAL
{
     public class TangDAL
    {
        DataHelper helper = new DataHelper();
        private Tang GetThuocFromDataRow(DataRow row)
        {
            Tang k = new Tang();

            k.MATANG = row["MATANG"].ToString().Trim();
            k.MACAOOC = row["MACAOOC"].ToString().Trim();
            k.SOPHONG = int.Parse(row["GIA"].ToString().Trim());

            return k;
        }
        public Tang[] GetList()
        {
            Tang[] list = null;
            DataTable table = null;
            int n = 0;

            table = helper.ExecuteQuery("select * from TANG");
            n = table.Rows.Count;

            if (n == 0)
            {
                return null;
            }

            list = new Tang[n];
            for (int i = 0; i < n; i++)
            {
                Tang s = GetThuocFromDataRow(table.Rows[i]);
                list[i] = s;
            }

            return list;
        }
        public bool Add(Tang k)
        {
            string query = string.Format("INSERT INTO TANG values (N'{0}',N'{1}',{2}')", k.MATANG, k.MACAOOC,k.SOPHONG);

            try
            {
                helper.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Remove(string id)
        {
            string query = string.Format("DELETE FROM TANG WHERE MACAOOC = (N'{0}')", id);

            try
            {
                helper.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(Tang k)
        {
            string query = string.Format("UPDATE TANG SET MACAOOC = (N'{0}'), SOPHONG = (N'{1}')  WHERE MATANG = (N'{2}')", k.MACAOOC, k.SOPHONG, k.MATANG);

            try
            {
                helper.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tang Search(string id)
        {
            DataTable table = null;
            int n = 0;

            string query = string.Format("SELECT * FROM TANG WHERE MATANG = (N'{0}')", id);
            table = helper.ExecuteQuery(query);
            n = table.Rows.Count;

            if (n == 0)
            {
                return null;
            }
            Tang k = GetThuocFromDataRow(table.Rows[0]);

            return k;
        }
       
    }
}

