using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    internal class CUSTOMER: IModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string houseNo { get; set; }
        public string city { get; set; }
        public string pin { get; set; }

        public CUSTOMER(string id, string name, string phone, string email, string houseNo, string city, string pin)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.houseNo = houseNo;
            this.city = city;
            this.pin = pin;
        }

        public CUSTOMER() { }

        public bool isValidate(IModel model)
        {
            return true;
        }
    }
}
