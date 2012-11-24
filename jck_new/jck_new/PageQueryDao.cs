
using System;
using System.Collections.Generic;
using System.Data;
using jck_new;

namespace Common
{
    /// <summary>
    /// Description of PageDao.
    /// </summary>
    public class PageQueryDao
    {
        private PageQueryDao()
        {
        }
        public static Page getProducts_buy(int curPageIndex)
        {
            return getProducts_buy(curPageIndex, null);
        }
        public static Page getProducts_buy(int curPageIndex, Product_buy condition)
        {
            string sqlQuery = "select * from tbl_buy";
            string sqlCount = "select count(*) from tbl_buy";
            string sqlOrder = " order by buy_date desc";
            if (condition != null)
            {
                string sqlCondition = " where price>" + condition.Price;
                //sqlQuery +=sqlCondition+sqlOrder;
                sqlQuery += sqlCondition;
                sqlCount += sqlCondition;
            }
            sqlQuery += sqlOrder;

            int totalRecord = AccessDBUtil.ExecuteScalar(sqlCount);
            Page page = new Page(totalRecord, AccessPageUtil.PAGE_SIZE);
            if (curPageIndex >= page.TotalPage) curPageIndex = page.TotalPage - 1;
            if (curPageIndex < 0) curPageIndex = 0;
            page.CurPageIndex = curPageIndex;

            DataSet data = AccessPageUtil.query(sqlQuery, curPageIndex, totalRecord);
            List<Product_buy> ls = new List<Product_buy>();
            foreach (DataRow row in data.Tables["ds"].Rows)
            {
                ls.Add(Row2Product_buy(row));
            }
            page.ValueList = ls;
            return page;
        }
        private static Product_buy Row2Product_buy(DataRow row)
        {
            Product_buy product = new Product_buy();
            product.Id = Int32.Parse(row["id"].ToString());
            product.Code = row["code"].ToString();
            product.NameClass = row["class"].ToString();
            product.Name = row["p_name"].ToString();
            product.Amount = Int32.Parse(row["p_amount"].ToString());
            product.Price_sale = Double.Parse(row["sale_price"].ToString());
            product.Price = Double.Parse(row["price"].ToString());
            product.Other = row["other"].ToString();
            product.BuyDate = DateTime.Parse(row["buy_date"].ToString());
            return product;
        }


        public static Page getProducts_sale(int curPageIndex)
        {
            return getProducts_sale(curPageIndex, null);
        }
        public static Page getProducts_sale(int curPageIndex, Product_sale condition)
        {
            string sqlQuery = "SELECT s.id AS id, s.code AS code, b.class AS class, b.p_name AS p_name,"
                +"s.sale_price AS sale_price, s.p_amount AS p_amount, s.price AS price,"
                +" s.sale_date AS sale_date, s.other AS other "
                + "FROM tbl_sale AS s, tbl_buy AS b "
                + "WHERE s.code=b.code";
            string sqlCount = "select count(*) from tbl_sale";
            string sqlOrder = " order by s.sale_date desc";
            if (condition != null)
            {
                string sqlCondition = " where price>" + condition.Price;
                //sqlQuery +=sqlCondition+sqlOrder;
                sqlQuery += sqlCondition;
                sqlCount += sqlCondition;
            }
            sqlQuery += sqlOrder;

            int totalRecord = AccessDBUtil.ExecuteScalar(sqlCount);
            Page page = new Page(totalRecord, AccessPageUtil.PAGE_SIZE);
            if (curPageIndex >= page.TotalPage) curPageIndex = page.TotalPage - 1;
            if (curPageIndex < 0) curPageIndex = 0;
            page.CurPageIndex = curPageIndex;

            DataSet data = AccessPageUtil.query(sqlQuery, curPageIndex, totalRecord);
            List<Product_sale> ls = new List<Product_sale>();
            foreach (DataRow row in data.Tables["ds"].Rows)
            {
                ls.Add(Row2Product_sale(row));
            }
            page.ValueList = ls;
            return page;
        }
        private static Product_sale Row2Product_sale(DataRow row)
        {
            Product_sale product = new Product_sale();
            product.Id = Int32.Parse(row["id"].ToString());
            product.Code = row["code"].ToString();
            product.NameClass = row["class"].ToString();
            product.Name = row["p_name"].ToString();
            product.Amount = Int32.Parse(row["p_amount"].ToString());
            product.Price_sale = Double.Parse(row["sale_price"].ToString());
            product.Price = Double.Parse(row["price"].ToString());
            product.Other = row["other"].ToString();
            product.BuyDate = DateTime.Parse(row["sale_date"].ToString());
            return product;
        }

        ////////////////////////////////////////////////
        public static Page getProducts_kc(int curPageIndex)
        {
            return getProducts_kc(curPageIndex, null);
        }
        public static Page getProducts_kc(int curPageIndex, Product_kc condition)
        {
            string sqlQuery = "SELECT tbl_buy.code AS code, (select class from tbl_buy where code=tmp_tblrk.code) AS class, (select p_name from tbl_buy where code=tmp_tblrk.code) AS p_name, (select price from tbl_buy where code=tmp_tblrk.code) AS price, (select price from tbl_buy where code=tmp_tblrk.code)*( 入库-IIf(IsNull(出库),0,出库) ) AS price_sale, (select buy_date from tbl_buy where code=tmp_tblrk.code) AS buy_date, (select other from tbl_buy where code=tmp_tblrk.code) AS other,IIf(IsNull(出库),0,出库) as amount_s, 入库-IIf(IsNull(出库),0,出库) AS kc "
+ "FROM (SELECT code,class,p_name,buy_date, sum(p_amount) AS 入库 FROM tbl_buy GROUP BY code,class,p_name,buy_date)  AS tmp_tblrk LEFT JOIN (SELECT code, sum(p_amount) AS 出库 FROM tbl_sale GROUP BY code)  AS tmp_tblck ON tmp_tblrk.code = tmp_tblck.code";
            string sqlCount = "SELECT count(*) FROM (SELECT code,p_name,class, sum(p_amount) AS 入库 FROM tbl_buy GROUP BY code,p_name,class)  AS tmp_tblrk LEFT JOIN (SELECT code, sum(p_amount) AS 出库 FROM tbl_sale  GROUP BY code)  AS tmp_tblck ON tmp_tblrk.code = tmp_tblck.code ";
            string sqlOrder = " order by tmp_tblrk.buy_date desc";
            if (condition != null)
            {
                string sqlCondition = "";
                if (condition.Code != null)
                {
                    sqlCondition = " where  tmp_tblrk.code='" + condition.Code.ToString()+"'";
                }
                else if (condition.Name != null)
                {
                    sqlCondition = " where  tmp_tblrk.p_name like '%" + condition.Name.ToString() + "%'";
                }
                else if (condition.NameClass != null)
                {
                    sqlCondition = " where  tmp_tblrk.class='" + condition.NameClass.ToString() + "'";
                }
                 
                //sqlQuery +=sqlCondition+sqlOrder;
                sqlQuery += sqlCondition;
                sqlCount += sqlCondition;
            }
            sqlQuery += sqlOrder;

            int totalRecord = AccessDBUtil.ExecuteScalar(sqlCount);
            Page page = new Page(totalRecord, AccessPageUtil.PAGE_SIZE);
            if (curPageIndex >= page.TotalPage) curPageIndex = page.TotalPage - 1;
            if (curPageIndex < 0) curPageIndex = 0;
            page.CurPageIndex = curPageIndex;

            DataSet data = AccessPageUtil.query(sqlQuery, curPageIndex, totalRecord);
            List<Product_kc> ls = new List<Product_kc>();
            foreach (DataRow row in data.Tables["ds"].Rows)
            {
                ls.Add(Row2Product_kc(row));
            }
            page.ValueList = ls;
            return page;
        }
        private static Product_kc Row2Product_kc(DataRow row)
        {
            Product_kc product = new Product_kc();
           // product.Id = Int32.Parse(row["id"].ToString());
            product.Code = row["code"].ToString();
            product.NameClass = row["class"].ToString();
            product.Name = row["p_name"].ToString();
            product.Amount = Int32.Parse(row["kc"].ToString());
            product.Amount_s = Int32.Parse(row["amount_s"].ToString());
            product.Price_sale = Double.Parse(row["price_sale"].ToString());
            product.Price = Double.Parse(row["price"].ToString());
            product.Other = row["other"].ToString();
            product.BuyDate = DateTime.Parse(row["buy_date"].ToString());
            return product;
        }

    }
}
