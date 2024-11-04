using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    internal class BRANCH: IModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string houseNo { get; set; }
        public string city { get; set; }
        public BRANCH() { }

        public BRANCH(string id, string name, string houseNo, string city)
        {
            this.id = id;
            this.name = name;
            this.houseNo = houseNo;
            this.city = city;
        }

        public bool isValidate(IModel model)
        {
            return true;
        }
    }
}
