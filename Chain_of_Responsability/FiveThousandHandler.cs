using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsability
{
     class FiveThousandHandler : Handler
     {
          public override BankAccount Withdraw(BankAccount account)
          {
               int requestedAmount = account.getRequestedAmount();

               int numberofNotesToIssued = requestedAmount / 5000;
               if (numberofNotesToIssued > 0)
               {
                    if (numberofNotesToIssued > 1)
                    {
                         Console.WriteLine("" + numberofNotesToIssued + " FiveThousand notes are issued");
                    }
                    else
                    {
                         Console.WriteLine("" + numberofNotesToIssued + " FiveThousand note is issued");
                    }
               }
               int pendingAmountToBeProcessed = requestedAmount % 5000;

               if (pendingAmountToBeProcessed > 0)
               {
                    account.setRemainAmountTOIssueNotes(pendingAmountToBeProcessed);
                    successor.Withdraw(account);

               }

               return account;
          }
     }
}
