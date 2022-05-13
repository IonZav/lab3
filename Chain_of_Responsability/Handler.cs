using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsability
{
     abstract class Handler
     {
          protected Handler successor;
          public void setSuccessor(Handler successor)
          {
               this.successor = successor;
          }
          public abstract BankAccount Withdraw(BankAccount account);
     }
}
