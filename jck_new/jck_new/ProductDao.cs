
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
		//‡“üV??C•Ô‰ñŽ©?¶¬“IID
		public static int insert(Product_buy p)
		{
            string sql = "insert into tbl_buy(code,p_name,class,p_amount,sale_price,price,buy_date,other)values(?,?,?,?,?,?,?,?);";
			OleDbParameter[] parameters = new OleDbParameter[8];
            parameters[0] = new OleDbParameter("@code", OleDbType.VarChar, 50);
            parameters[0].Value = p.Code;
			parameters[1]=new OleDbParameter("@p_name",OleDbType.VarChar,50);
			parameters[1].Value=p.Name;
            parameters[2] = new OleDbParameter("@class", OleDbType.VarChar, 50);
            parameters[2].Value = p.NameClass;
            parameters[3] = new OleDbParameter("@p_amount", OleDbType.Integer);
			parameters[3].Value=p.Amount;
			parameters[4]=new OleDbParameter("@sale_price",OleDbType.Double);
			parameters[4].Value=p.Price_sale;
            parameters[5] = new OleDbParameter("@price", OleDbType.Double);
            parameters[5].Value = p.Price;
			parameters[6]=new OleDbParameter("@buy_date",OleDbType.Date);
			parameters[6].Value=p.BuyDate;
            parameters[7] = new OleDbParameter("@other", OleDbType.VarChar, 50);
			parameters[7].Value=p.Other;
			
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
            string sql = "update tbl_buy set code=?,p_name=?,class=?,p_amount=?,sale_price=?,price=?,buy_date=?,other=? where id=?";
			OleDbParameter[] parameters = new OleDbParameter[9];
            parameters[0] = new OleDbParameter("@code", OleDbType.VarChar, 50);
            parameters[0].Value = p.Code;
            parameters[1] = new OleDbParameter("@p_name", OleDbType.VarChar, 50);
            parameters[1].Value = p.Name;
            parameters[2] = new OleDbParameter("@class", OleDbType.VarChar, 50);
            parameters[2].Value = p.NameClass;
            parameters[3] = new OleDbParameter("@p_amount", OleDbType.Integer);
            parameters[3].Value = p.Amount;
            parameters[4] = new OleDbParameter("@sale_price", OleDbType.Double);
            parameters[4].Value = p.Price_sale;
            parameters[5] = new OleDbParameter("@price", OleDbType.Double);
            parameters[5].Value = p.Price;
            parameters[6] = new OleDbParameter("@buy_date", OleDbType.Date);
            parameters[6].Value = p.BuyDate;
            parameters[7] = new OleDbParameter("@other", OleDbType.VarChar, 50);
            parameters[7].Value = p.Other;
			parameters[8] = new OleDbParameter("@id",OleDbType.Integer);
			parameters[8].Value=p.Id;
			
			return AccessDBUtil.ExecuteNonQuery(sql,parameters);
			
			
		}
        public static Product_buy getById(int id)
		{
            string sql = "select id,code,p_name,class,p_amount,sale_price,price,buy_date,other from tbl_buy where id=?";
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
            product.Amount = Int32.Parse(row["p_amount"].ToString());
            product.Code = row["Code"].ToString();
            product.NameClass = row["class"].ToString();
			product.Price = Double.Parse(row["price"].ToString());
            product.Price_sale = Double.Parse(row["sale_price"].ToString());
            product.BuyDate = DateTime.Parse(row["buy_date"].ToString());
			product.Other = row["other"].ToString();
			return product;
		}
        public static Product_buy getByCode(string code)
        {
            string sql = "select id,code,class,p_name,p_amount,sale_price,price,buy_date,other from tbl_buy where code=?";
            OleDbParameter[] parameters = new OleDbParameter[1];
            parameters[0] = new OleDbParameter("@code" ,OleDbType.VarChar, 50);
            parameters[0].Value = code;
            DataSet ds = AccessDBUtil.ExecuteQuery(sql, parameters);
            if (ds.Tables["ds"].Rows.Count>0)
            {
                return Row2Product(ds.Tables["ds"].Rows[0]);
            }
            else
            {
                return null;
            }
           
        }

        ///////////////////////////////////////////////////////
        public static int insert_sale(Product_sale p)
        {
            string sql = "insert into tbl_sale(code,p_name,class,sale_price,p_amount,price,sale_date,other)values(?,?,?,?,?,?,?,?);";
            OleDbParameter[] parameters = new OleDbParameter[8];
            parameters[0] = new OleDbParameter("@code", OleDbType.VarChar, 50);
            parameters[0].Value = p.Code;
            parameters[1] = new OleDbParameter("@p_name", OleDbType.VarChar, 50);
            parameters[1].Value = p.Name;
            parameters[2] = new OleDbParameter("@class", OleDbType.VarChar, 50);
            parameters[2].Value = p.NameClass;
            parameters[3] = new OleDbParameter("@sale_price", OleDbType.Double);
            parameters[3].Value = p.Price_sale;
            parameters[4] = new OleDbParameter("@p_amount", OleDbType.Integer);
            parameters[4].Value = p.Amount;
            parameters[5] = new OleDbParameter("@price", OleDbType.Double);
            parameters[5].Value = p.Price;
            parameters[6] = new OleDbParameter("@sale_date", OleDbType.Date);
            parameters[6].Value = p.BuyDate;
            parameters[7] = new OleDbParameter("@other", OleDbType.VarChar, 50);
            parameters[7].Value = p.Other;

            return AccessDBUtil.ExecuteInsert(sql, parameters);
        }

        public static int deleteById_sale(int id)
        {
            string sql = "delete from tbl_sale where id=?";
            OleDbParameter[] parameters = new OleDbParameter[1];
            parameters[0] = new OleDbParameter("@id", OleDbType.Integer);
            parameters[0].Value = id;
            return AccessDBUtil.ExecuteNonQuery(sql, parameters);
        }
        public static int update_sale(Product_sale p)
        {
            string sql = "update tbl_sale set code=?,p_name=?,class=?,sale_price=?,p_amount=?,price=?,sale_date=?,other=? where id=?";
            OleDbParameter[] parameters = new OleDbParameter[9];
            parameters[0] = new OleDbParameter("@code", OleDbType.VarChar, 50);
            parameters[0].Value = p.Code;
            parameters[1] = new OleDbParameter("@p_name", OleDbType.VarChar, 50);
            parameters[1].Value = p.Name;
            parameters[2] = new OleDbParameter("@class", OleDbType.VarChar, 50);
            parameters[2].Value = p.NameClass;
            parameters[3] = new OleDbParameter("@sale_price", OleDbType.Double);
            parameters[3].Value = p.Price_sale;
            parameters[4] = new OleDbParameter("@p_amount", OleDbType.Integer);
            parameters[4].Value = p.Amount;
            parameters[5] = new OleDbParameter("@price", OleDbType.Double);
            parameters[5].Value = p.Price;
            parameters[6] = new OleDbParameter("@sale_date", OleDbType.Date);
            parameters[6].Value = p.BuyDate;
            parameters[7] = new OleDbParameter("@other", OleDbType.VarChar, 50);
            parameters[7].Value = p.Other;
            parameters[8] = new OleDbParameter("@id", OleDbType.Integer);
            parameters[8].Value = p.Id;

            return AccessDBUtil.ExecuteNonQuery(sql, parameters);


        }
        public static Product_sale getById_sale(int id)
        {
            string sql = "select id,code,class,p_name,p_amount,sale_price,price,sale_date,other from tbl_sale where id=?";
            OleDbParameter[] parameters = new OleDbParameter[1];
            parameters[0] = new OleDbParameter("@id", OleDbType.Integer);
            parameters[0].Value = id;
            DataSet ds = AccessDBUtil.ExecuteQuery(sql, parameters);

            return Row2Product_sale(ds.Tables["ds"].Rows[0]);
        }
        private static Product_sale Row2Product_sale(DataRow row)
        {
            Product_sale product = new Product_sale();
            product.Id = Int32.Parse(row["id"].ToString());
            product.Name = row["p_name"].ToString();
            product.Amount = Int32.Parse(row["p_amount"].ToString());
            product.Code = row["Code"].ToString();
            product.NameClass = row["class"].ToString();
            product.Price = Double.Parse(row["price"].ToString());
            product.Price_sale = Double.Parse(row["sale_price"].ToString());
            product.BuyDate = DateTime.Parse(row["sale_date"].ToString());
            product.Other = row["other"].ToString();
            return product;
        }
        public static Product_sale getByCode_sale(string code)
        {
            string sql = "select id,code,p_name,p_amount,sale_price,price,buy_date,other from tbl_sale where code=?";
            OleDbParameter[] parameters = new OleDbParameter[1];
            parameters[0] = new OleDbParameter("@code", OleDbType.VarChar, 50);
            parameters[0].Value = code;
            DataSet ds = AccessDBUtil.ExecuteQuery(sql, parameters);
            if (ds.Tables["ds"].Rows.Count > 0)
            {
                return Row2Product_sale(ds.Tables["ds"].Rows[0]);
            }
            else
            {
                return null;
            }

        }

        public static DataSet allCalss()
        {
            string sql = "select id,class from tbl_class ";
            //OleDbParameter[] parameters = new OleDbParameter[1];
            DataSet ds = AccessDBUtil.ExecuteQuery(sql);

            return ds;
        }

        public static DataSet searchByKey(string key)
        {
            string sql = "select id,code,class,p_name,p_amount,sale_price,price,buy_date,other from tbl_buy where code like ? or p_name like '%'+@p_name+'%'";
            OleDbParameter[] parameters = new OleDbParameter[2];
            parameters[0] = new OleDbParameter("@code", OleDbType.VarChar, 50);
            parameters[0].Value = key;
            parameters[1] = new OleDbParameter("@p_name", OleDbType.VarChar, 50);
            parameters[1].Value = key;
            DataSet ds = AccessDBUtil.ExecuteQuery(sql, parameters);
            return ds;
        }

        public static int dayAmount()
        {
            string sql = "select sum(p_amount) from tbl_sale where (DateDiff('d',sale_date,Date())=0)";
            int ds = AccessDBUtil.ExecuteScalar(sql);
            return ds;
        }
        public static double dayPrice()
        {
            string sql = "select sum(price) from tbl_sale where (DateDiff('d',sale_date,Date())=0)";
            int ds = AccessDBUtil.ExecuteScalar(sql);
            return ds;
        }

        public static int mAmount()
        {
            string sql = "select sum(p_amount) from tbl_sale where (DateDiff('m',sale_date,Date())=0)";
            int ds = AccessDBUtil.ExecuteScalar(sql);
            return ds;
        }
        public static double mPrice()
        {
            string sql = "select sum(price) from tbl_sale where (DateDiff('m',sale_date,Date())=0)";
            int ds = AccessDBUtil.ExecuteScalar(sql);
            return ds;
        }
	}
}
