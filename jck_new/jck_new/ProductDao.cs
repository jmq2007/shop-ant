
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
        #region ������ ��ɾ�Ĳ�
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
        #endregion


        #region ���۱� ��ɾ�Ĳ�
        public static int insert_sale(Product_sale p)
        {
            string sql = "insert into tbl_sale(code,sale_price,p_amount,price,sale_date,other)values(?,?,?,?,?,?);";
            OleDbParameter[] parameters = new OleDbParameter[6];
            parameters[0] = new OleDbParameter("@code", OleDbType.VarChar, 50);
            parameters[0].Value = p.Code;
            //parameters[1] = new OleDbParameter("@p_name", OleDbType.VarChar, 50);
            //parameters[1].Value = p.Name;
           // parameters[2] = new OleDbParameter("@class", OleDbType.VarChar, 50);
            //parameters[2].Value = p.NameClass;
            parameters[1] = new OleDbParameter("@sale_price", OleDbType.Double);
            parameters[1].Value = p.Price_sale;
            parameters[2] = new OleDbParameter("@p_amount", OleDbType.Integer);
            parameters[2].Value = p.Amount;
            parameters[3] = new OleDbParameter("@price", OleDbType.Double);
            parameters[3].Value = p.Price;
            parameters[4] = new OleDbParameter("@sale_date", OleDbType.Date);
            parameters[4].Value = p.BuyDate;
            parameters[5] = new OleDbParameter("@other", OleDbType.VarChar, 50);
            parameters[5].Value = p.Other;

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
            string sql = "update tbl_sale set code=?,sale_price=?,p_amount=?,price=?,sale_date=?,other=? where id=?";
            OleDbParameter[] parameters = new OleDbParameter[7];
            parameters[0] = new OleDbParameter("@code", OleDbType.VarChar, 50);
            parameters[0].Value = p.Code;
            //parameters[1] = new OleDbParameter("@p_name", OleDbType.VarChar, 50);
           // parameters[1].Value = p.Name;
          //  parameters[2] = new OleDbParameter("@class", OleDbType.VarChar, 50);
           // parameters[2].Value = p.NameClass;
            parameters[1] = new OleDbParameter("@sale_price", OleDbType.Double);
            parameters[1].Value = p.Price_sale;
            parameters[2] = new OleDbParameter("@p_amount", OleDbType.Integer);
            parameters[2].Value = p.Amount;
            parameters[3] = new OleDbParameter("@price", OleDbType.Double);
            parameters[3].Value = p.Price;
            parameters[4] = new OleDbParameter("@sale_date", OleDbType.Date);
            parameters[4].Value = p.BuyDate;
            parameters[5] = new OleDbParameter("@other", OleDbType.VarChar, 50);
            parameters[5].Value = p.Other;
            parameters[6] = new OleDbParameter("@id", OleDbType.Integer);
            parameters[6].Value = p.Id;

            return AccessDBUtil.ExecuteNonQuery(sql, parameters);


        }
        public static Product_sale getById_sale(int id)
        {
            string sql = "SELECT s.id AS id, s.code AS code, b.class AS class, b.p_name AS p_name,"
                + "s.sale_price AS sale_price, s.p_amount AS p_amount, s.price AS price,"
                + " s.sale_date AS sale_date, s.other AS other "
                + "FROM tbl_sale AS s, tbl_buy AS b "
                + "WHERE s.code=b.code and s.id = ?";
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
            string sql = "SELECT s.id AS id, s.code AS code, b.class AS class, b.p_name AS p_name,"
                + "s.sale_price AS sale_price, s.p_amount AS p_amount, s.price AS price,"
                + " s.sale_date AS sale_date, s.other AS other "
                + "FROM tbl_sale AS s, tbl_buy AS b "
                + "WHERE s.code=b.code and s.code=?";
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
        #endregion


        #region ��ҳ��ѯ
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
        #endregion


        #region ͳ�Ʋ�ѯ
        public static DataSet tj_day(string key1, string key2)
        {
            string sql = "select Month(tbl.sale_date) & \"��\" & Day(tbl.sale_date) & \"��\" as ����,sum(tbl.����1) as ���� ,sum(tbl.b.price)as ��� from (SELECT b.sale_date, b.code, a.price, b.p_amount, b.price, (b.price-a.price*b.p_amount) AS ����1"
                + " FROM tbl_buy AS a, tbl_sale AS b"
                + " WHERE a.code=b.code) as tbl WHERE tbl.sale_date between ? and ? "
                + " GROUP BY  Month(tbl.sale_date) & \"��\" & Day(tbl.sale_date) & \"��\"";
            OleDbParameter[] parameters = new OleDbParameter[2];
            parameters[0] = new OleDbParameter("@1", OleDbType.Date);
            parameters[0].Value = key1;
            parameters[1] = new OleDbParameter("@2", OleDbType.Date);
            parameters[1].Value = key2;
            DataSet ds = AccessDBUtil.ExecuteQuery(sql, parameters);
            return ds;
        }

        public static DataSet tj_mon(string key1, string key2)
        {
            string sql = "select Month(tbl.sale_date) & \"��\" as ����,sum(tbl.����1) as ���� ,sum(tbl.b.price)as ��� from (SELECT b.sale_date, b.code, a.price, b.p_amount, b.price, (b.price-a.price*b.p_amount) AS ����1"
                + " FROM tbl_buy AS a, tbl_sale AS b"
                + " WHERE a.code=b.code) as tbl WHERE tbl.sale_date between ? and ? "
                + " GROUP BY  Month(tbl.sale_date) & \"��\"";
            OleDbParameter[] parameters = new OleDbParameter[2];
            parameters[0] = new OleDbParameter("@1", OleDbType.Date);
            parameters[0].Value = key1;
            parameters[1] = new OleDbParameter("@2", OleDbType.Date);
            parameters[1].Value = key2;
            DataSet ds = AccessDBUtil.ExecuteQuery(sql, parameters);
            return ds;
        }

        public static DataTable outSale(string key1, string key2)
        {
            string sql = "SELECT s.id AS id, s.code AS ����, b.class AS ���, b.p_name AS ����,"
               + "s.sale_price AS Ӧ�۵���, s.p_amount AS ����, s.price AS ʵ���ܼ�,"
               + "s.sale_date AS �۳�ʱ��, s.other AS ��ע "
               + "FROM tbl_sale AS s, tbl_buy AS b "
               + "WHERE s.code=b.code and s.sale_date between ? and ?";
            OleDbParameter[] parameters = new OleDbParameter[2];
            parameters[0] = new OleDbParameter("@1", OleDbType.Date);
            parameters[0].Value = key1;
            parameters[1] = new OleDbParameter("@2", OleDbType.Date);
            parameters[1].Value = key2;
            DataSet ds = AccessDBUtil.ExecuteQuery(sql, parameters);
            return ds.Tables["ds"];
        }

        public static DataTable outBuy(string key1, string key2)
        {
            string sql = "select id,code as ����,class as ���,p_name as ����,p_amount as ����,sale_price as ���,price as ����,other as ��ע,buy_date as ����ʱ�� "
                + " from tbl_buy"
                + " where buy_date between ? and ?";
            OleDbParameter[] parameters = new OleDbParameter[2];
            parameters[0] = new OleDbParameter("@1", OleDbType.Date);
            parameters[0].Value = key1;
            parameters[1] = new OleDbParameter("@2", OleDbType.Date);
            parameters[1].Value = key2;
            DataSet ds = AccessDBUtil.ExecuteQuery(sql, parameters);
            return ds.Tables["ds"];
        }

        public static int getKcByCode(string key)
        {
            string sql = "SELECT ���-IIf(IsNull(����),0,����) AS kc "
                + "FROM (SELECT code, sum(p_amount) AS ��� FROM tbl_buy GROUP BY code)  AS tmp_tblrk LEFT JOIN (SELECT code, sum(p_amount) AS ���� FROM tbl_sale GROUP BY code)  AS tmp_tblck ON tmp_tblrk.code = tmp_tblck.code"
                + " where tbl_buy.code=?";
            OleDbParameter[] parameters = new OleDbParameter[1];
            parameters[0] = new OleDbParameter("@tbl_buy.code", OleDbType.VarChar, 50);
            parameters[0].Value = key;
            int ds = AccessDBUtil.ExecuteScalar(sql, parameters);
            return ds;
        }
        #endregion


        #region ������ɾ��
        public static DataSet getAllLb()
        {
            string sql = "select id,class"
                + " FROM tbl_class";
            DataSet ds = AccessDBUtil.ExecuteQuery(sql);
            return ds;
        }

        public static int insert_lb(string name)
        {
            string sql = "insert into tbl_class(class)values(?);";
            OleDbParameter[] parameters = new OleDbParameter[1];
            parameters[0] = new OleDbParameter("@class", OleDbType.VarChar, 50);
            parameters[0].Value = name;
            return AccessDBUtil.ExecuteInsert(sql, parameters);
        }

        public static int deleteLbById(int id)
        {
            string sql = "delete from tbl_class where id=?";
            OleDbParameter[] parameters = new OleDbParameter[1];
            parameters[0] = new OleDbParameter("@id", OleDbType.Integer);
            parameters[0].Value = id;
            return AccessDBUtil.ExecuteNonQuery(sql, parameters);
        }
        #endregion


        #region user�����
        public static int updateBak(string date)
        {
            string sql = "update tbl_user set bak=?";
            OleDbParameter[] parameters = new OleDbParameter[1];
            parameters[0] = new OleDbParameter("@bak", OleDbType.Date);
            parameters[0].Value = date;

            return AccessDBUtil.ExecuteNonQuery(sql, parameters);


        }
        public static string getBak()
        {
            string sql = "select bak "
                + " FROM tbl_user";
            DataSet ds = AccessDBUtil.ExecuteQuery(sql);
            if (ds.Tables["ds"].Rows.Count > 0)
            {
                return ds.Tables["ds"].Rows[0]["bak"].ToString();
            }
            else
            {
                return null;
            }
        }

        public static int getLogin(string key1,string key2)
        {
            string sql = "select count(*) "
                + " FROM tbl_user "
                + " where class='1' and username=? and password_=?";
            OleDbParameter[] parameters = new OleDbParameter[2];
            parameters[0] = new OleDbParameter("@username", OleDbType.VarChar, 50);
            parameters[0].Value = "admin";
            parameters[1] = new OleDbParameter("@tpassword_", OleDbType.VarChar, 50);
            parameters[1].Value = key2;
            int ds = AccessDBUtil.ExecuteScalar(sql, parameters);
            return ds;
        }

        public static int update_password(string key)
        {
            string sql = "update tbl_user set password_= ? where username='admin'";
            OleDbParameter[] parameters = new OleDbParameter[1];
            parameters[0] = new OleDbParameter("@password_", OleDbType.VarChar, 50);
            parameters[0].Value = key;
            return AccessDBUtil.ExecuteNonQuery(sql, parameters);


        }
        #endregion

      
	}
}
