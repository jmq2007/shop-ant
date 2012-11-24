using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jck_new
{
    public class Product_kc
    {
        //private int id;
		private string code;//条码
        private string nameClass;//类型
        private string name;//名称
        private double price;//进价
        private double price_sale;//余货总价
        private int amount;//库存
        private int amount_s;//售出量
        private DateTime buyDate;//出售时间
        private string other;//备注

        public Product_kc()
		{
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
        public int Amount_s
        {
            get { return amount_s; }
            set { amount_s = value; }
        }
        public string Other
        {
            get { return other; }
            set { other = value; }
        }
        public DateTime BuyDate
        {
            get { return buyDate; }
            set { buyDate = value; }
        }
    }
}
