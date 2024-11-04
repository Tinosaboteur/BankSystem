using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    internal class TRANSACTION: IModel
    {

        public int id {  get; set; }
        public int fromAccount { get; set; }
        public string branchId { get; set; }
        public DateTime dateOfTrans { get; set; }
        public float amount { get; set; }
        public string pin { get; set; }
        public int toAccountId { get; set; }
        public string employeeId { get; set; }

        public string type { get; set; }

        public TRANSACTION()
        {
        }

        public TRANSACTION(int id, int fromAccount, string branchId, 
            DateTime dateOfTrans, float amount, string pin, int toAccountId, string employeeId, string type)
        {
            this.id = id;
            this.fromAccount = fromAccount;
            this.branchId = branchId;
            this.dateOfTrans = dateOfTrans;
            this.amount = amount;
            this.pin = pin;
            this.toAccountId = toAccountId;
            this.employeeId = employeeId;
            this.type = type;
        }

        public bool isValidate(IModel model)
        {
            return true;
        }
    }
}
