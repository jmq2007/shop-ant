﻿
using System;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Common
{
	/// <summary>
	/// Description of AccessPageUtil.
	/// </summary>
	public class AccessPageUtil
	{
		public const int PAGE_SIZE=10;
		private AccessPageUtil()
		{
		}
		//每页默认记录条数PAGE_SIZE
		public static DataSet query(string sql,int curPageIndex,int totalRecord)
		{
			return query(sql,curPageIndex,PAGE_SIZE,totalRecord);
		}
		//通过datareader读取当前页数据，并且封装为dataset返回
		public static DataSet query(string sql,int curPageIndex,int pageSize,int totalRecord)
		{
			DataSet ds = new DataSet();
			OleDbDataReader dr = AccessDBUtil.ExecuteReader(sql);
			//
			DataTable st=dr.GetSchemaTable();
			DataTable dt = ds.Tables.Add("ds");
			foreach(DataRow row in st.Rows)
			{
				DataColumn c = new  DataColumn();
				c.ColumnName =row["ColumnName"].ToString();
				c.DataType = System.Type.GetType(row["DataType"].ToString());
			    dt.Columns.Add(c);
			    //Debug.WriteLine(c.ColumnName+"--"+c.DataType);
			}		
			//
			int colCount = st.Rows.Count;
			int count =0;
			int start= curPageIndex*pageSize;
			int end = start+pageSize;
			while(dr.Read())
			{
				if(count<start)
				{
					count++;
					continue;
				}
				DataRow r = dt.NewRow();
				for(int i=0;i<colCount;i++)
				{
					r[i]=dr[i];
				}
				dt.Rows.Add(r);
				count++;
				if(count>=end) break;
			}
			dr.Close();
			
			return ds;
		}

		
	}
}
