using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    internal class ACCOUNT: IModel
    {
        public int id { get; set; }
        public string custommerId { get; set; }
        public DateTime dateOpen { get; set; }
        public float balance { get; set; }

        public ACCOUNT(int id, string custommerId, DateTime dateOpen, float balance)
        {
            this.id = id;
            this.custommerId = custommerId;
            this.dateOpen = dateOpen;
            this.balance = balance;
        }

        public ACCOUNT()
        {
        }

        public bool isValidate(IModel model)
        {
            return true;
        }
    }
}
