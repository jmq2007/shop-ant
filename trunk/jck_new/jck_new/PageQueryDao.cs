
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
        #region 进货分页
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
        #endregion

        #region 销售分页
        public static Page getProducts_sale(int curPageIndex)
        {
            return getProducts_sale(curPageIndex, null);
        }
        public static Page getProducts_sale(int curPageIndex, Product_sale condition)
        {
            string sqlQuery = "SELECT s.id AS id, s.code AS code, b.class AS class, b.p_name AS p_name,"
                +"s.sale_price AS sale_price, s.p_amount AS p_amount, s.price AS price,"
                + " s.sale_date AS sale_date, s.other AS other ,s.phone AS phone "
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
            product.Phone = row["phone"].ToString();
            return product;
        }
        #endregion

        #region 库存分页
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
        #endregion

        #region 会员分页
        public static Page getMember(int curPageIndex)
        {
            return getMember(curPageIndex, null);
        }
        public static Page getMember(int curPageIndex, Member condition)
        {
            string sqlQuery = "SELECT tmp_tblme.id as id,tmp_tblme.username as username,tmp_tblme.phone as phone,tmp_tblme.class as class,tmp_tblme.other as other,tmp_tblme.c_date as c_date,IIf(IsNull(tmp_tblje.金额),0,tmp_tblje.金额) as price from (SELECT id,phone,username,class,other,c_date  FROM tbl_member) AS tmp_tblme LEFT JOIN (SELECT phone,sum(price) AS 金额 FROM tbl_sale GROUP BY phone)  AS tmp_tblje ON tmp_tblme.phone = tmp_tblje.phone ";
            string sqlCount = "select count(*) from (SELECT id, phone, username, class, other, c_date FROM tbl_member) as tmp_tblme ";
            string sqlOrder = " order by tmp_tblme.c_date desc";
            if (condition != null)
            {
                string sqlCondition = "";
                if (condition.Phone != null)
                {
                    sqlCondition = " where  tmp_tblme.phone='" + condition.Phone.ToString() + "'";
                }
                else if (condition.Username != null)
                {
                    sqlCondition = " where  tmp_tblme.username like '%" + condition.Username.ToString() + "%'";
                }
                else if (condition.UserClass != null)
                {
                    sqlCondition = " where  tmp_tblme.class='" + condition.UserClass.ToString() + "'";
                }
               // else if (condition.Price != null)
              //  {
              //      sqlCondition = " where  tmp_tblme.price> " + condition.Price;
               // }
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
            List<Member> ls = new List<Member>();
            foreach (DataRow row in data.Tables["ds"].Rows)
            {
                ls.Add(Row2Member(row));
            }
            page.ValueList = ls;
            return page;
        }
        private static Member Row2Member(DataRow row)
        {
            Member member = new Member();
            member.Id = Int32.Parse(row["id"].ToString());
            member.Username = row["username"].ToString();
            member.UserClass = row["class"].ToString();
            member.Phone = row["phone"].ToString();
            member.Price = Double.Parse(row["price"].ToString());
            member.Other = row["other"].ToString();
            member.CDate = DateTime.Parse(row["c_date"].ToString());
            return member;
        }
        #endregion
    }
}
