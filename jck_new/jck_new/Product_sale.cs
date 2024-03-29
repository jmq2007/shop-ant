﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jck_new
{
    public class Product_sale
    {
        private int id;
		private string code;//条码
        private string nameClass;//类型 b表
        private string name;//名称 b表
        private double price;//总价
        private double price_sale;//单价
        private int amount;//数量
		private DateTime buyDate;//出售时间
        private string other;//备注
        private string phone;//手机

        public Product_sale()
		{
		}
		public int Id {
			get { return id; }
			set { id = value; }
		}
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string NameClass
        {
            get { return nameClass; }
            set { nameClass = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public double Price_sale
        {
            get { return price_sale; }
            set { price_sale = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public DateTime BuyDate
        {
            get { return buyDate; }
            set { buyDate = value; }
        }
        public string Other
        {
            get { return other; }
            set { other = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
	
    }
}
