using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jck_new
{
    public class Product_buy
    {
        private int id;
		private string code;//条码
        private string name;//名称
        private double price;//进价
        private double price_sale;//售价
        private int amount;//数量
		private DateTime buyDate;//出售时间
        private string other;//备注

        public Product_buy()
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
	
    }
}
