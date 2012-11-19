
using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using jck_new;

namespace Common
{
	/// <summary>
	/// Description of ProductDao.
	/// </summary>
	public class ProductDao
	{
		private ProductDao()
		{
		}
		//ùáì¸êV??ÅCï‘âÒé©?ê∂ê¨ìIID
		public static int insert(Product_buy p)
		{
            string sql = "insert into tbl_buy(code,p_name,amount,sale_price,price,buy_date,other)values(?,?,?,?,?,?,?);";
			OleDbParameter[] parameters = new OleDbParameter[7];
            parameters[0] = new OleDbParameter("@code", OleDbType.VarChar, 50);
            parameters[0].Value = p.Code;
			parameters[1]=new OleDbParameter("@p_name",OleDbType.VarChar,50);
			parameters[1].Value=p.Name;
            parameters[2] = new OleDbParameter("@amount", OleDbType.Integer);
			parameters[2].Value=p.Amount;
			parameters[3]=new OleDbParameter("@sale_price",OleDbType.Double);
			parameters[3].Value=p.Price_sale;
            parameters[4] = new OleDbParameter("@price", OleDbType.Double);
            parameters[4].Value = p.Price;
			parameters[5]=new OleDbParameter("@sale_date",OleDbType.Date);
			parameters[5].Value=p.BuyDate;
            parameters[6] = new OleDbParameter("@other", OleDbType.VarChar, 50);
			parameters[6].Value=p.Other;
			
			return AccessDBUtil.ExecuteInsert(sql,parameters);
		}
		public static int deleteById(int id)
		{
            string sql = "delete from tbl_buy where id=?";
			OleDbParameter[] parameters = new OleDbParameter[1];
			parameters[0] = new OleDbParameter("@id",OleDbType.Integer);
			parameters[0].Value=id;
			return AccessDBUtil.ExecuteNonQuery(sql,parameters);
		}
        public static int update(Product_buy p)
		{
            string sql = "update tbl_buy set code=?,p_name=?,amount=?,sale_price=?,price=?,buy_date=?,other=? where id=?";
			OleDbParameter[] parameters = new OleDbParameter[8];
            parameters[0] = new OleDbParameter("@code", OleDbType.VarChar, 50);
            parameters[0].Value = p.Code;
            parameters[1] = new OleDbParameter("@p_name", OleDbType.VarChar, 50);
            parameters[1].Value = p.Name;
            parameters[2] = new OleDbParameter("@amount", OleDbType.Integer);
            parameters[2].Value = p.Amount;
            parameters[3] = new OleDbParameter("@sale_price", OleDbType.Double);
            parameters[3].Value = p.Price_sale;
            parameters[4] = new OleDbParameter("@price", OleDbType.Double);
            parameters[4].Value = p.Price;
            parameters[5] = new OleDbParameter("@sale_date", OleDbType.Date);
            parameters[5].Value = p.BuyDate;
            parameters[6] = new OleDbParameter("@other", OleDbType.VarChar, 50);
            parameters[6].Value = p.Other;
			parameters[7] = new OleDbParameter("@id",OleDbType.Integer);
			parameters[7].Value=p.Id;
			
			return AccessDBUtil.ExecuteNonQuery(sql,parameters);
			
			
		}
        public static Product_buy getById(int id)
		{
            string sql = "select id,code,p_name,amount,sale_price,price,buy_date,other from tbl_buy where id=?";
			OleDbParameter[] parameters = new OleDbParameter[1];
			parameters[0] = new OleDbParameter("@id",OleDbType.Integer);
			parameters[0].Value=id;
			DataSet ds = AccessDBUtil.ExecuteQuery(sql,parameters);
			
			return Row2Product(ds.Tables["ds"].Rows[0]);
		}
        private static Product_buy Row2Product(DataRow row)
		{
            Product_buy product = new Product_buy();
			product.Id = Int32.Parse(row["id"].ToString());
			product.Name = row["p_name"].ToString();
            product.Code = row["Code"].ToString();
			product.Price = Double.Parse(row["price"].ToString());
            product.Price_sale = Double.Parse(row["sale_price"].ToString());
            product.BuyDate = DateTime.Parse(row["buy_date"].ToString());
			product.Other = row["other"].ToString();
			return product;
		}
        public static Product_buy getByCode(string code)
        {
            string sql = "select id,code,p_name,amount,sale_price,price,buy_date,other from tbl_buy where code=?";
            OleDbParameter[] parameters = new OleDbParameter[1];
            parameters[0] = new OleDbParameter("@code" ,OleDbType.VarChar, 50);
            parameters[0].Value = code;
            DataSet ds = AccessDBUtil.ExecuteQuery(sql, parameters);
            return Row2Product(ds.Tables["ds"].Rows[0]);
        }
		
	}
}
