using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    internal class EMPLOYEE: IModel
    {
        public string id { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public EMPLOYEE()
        {
        }

        public EMPLOYEE(string id, string password, string role)
        {
            this.id = id;
            this.password = password;
            this.role = role;
        }

        public bool isValidate(IModel model)
        {
            return true;
        }
    }


}
