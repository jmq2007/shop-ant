
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
			string sqlQuery="select * from tbl_buy";
            string sqlCount = "select count(*) from tbl_buy";
            string sqlOrder = " order by buy_date";
			if(condition!=null)
			{
				string sqlCondition=" where price>"+condition.Price;
				//sqlQuery +=sqlCondition+sqlOrder;
                sqlQuery += sqlCondition;
				sqlCount +=sqlCondition;
			}
            sqlQuery +=sqlOrder;

			int totalRecord = AccessDBUtil.ExecuteScalar(sqlCount);
			Page page = new Page(totalRecord,AccessPageUtil.PAGE_SIZE);
			if(curPageIndex>=page.TotalPage)curPageIndex=page.TotalPage-1;
			if(curPageIndex<0)curPageIndex=0;
			page.CurPageIndex=curPageIndex;
			
			DataSet data = AccessPageUtil.query(sqlQuery,curPageIndex,totalRecord);
            List<Product_buy> ls = new List<Product_buy>();
			foreach(DataRow row in data.Tables["ds"].Rows)
			{
                ls.Add(Row2Product_buy(row));
			}
			page.ValueList=ls;
			return  page;
		}
        private static Product_buy Row2Product_buy(DataRow row)
		{
            Product_buy product = new Product_buy();
			product.Id = Int32.Parse(row["id"].ToString());
            product.Code = row["code"].ToString();
            product.NameClass = row["class"].ToString();
            product.Name = row["p_name"].ToString();
            product.Amount = Int32.Parse(row["amount"].ToString());
            product.Price_sale = Double.Parse(row["sale_price"].ToString());
			product.Price = Double.Parse(row["price"].ToString());
            product.Other = row["other"].ToString();
			product.BuyDate = DateTime.Parse(row["buy_date"].ToString());
			return product;
		}
	}
}
