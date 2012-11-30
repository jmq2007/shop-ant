using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jck_new
{
    public class Member
    {
        private int id;
		private string username;//
        private string phone;//
        private string userClass;//
		private DateTime cDate;//时间
        private string other;//备注
        private double price;//价

        public Member()
		{
		}
		public int Id {
			get { return id; }
			set { id = value; }
		}

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string UserClass
        {
            get { return userClass; }
            set { userClass = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public DateTime CDate
        {
            get { return cDate; }
            set { cDate = value; }
        }
        public string Other
        {
            get { return other; }
            set { other = value; }
        }
	
    }
}
