using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsability
{
     class OneThousandHandler : Handler
     {
          public override BankAccount Withdraw(BankAccount account)
          {
               int requestedAmount = account.getRemainAmountTOIssueNotes();

               int numberofNotesToIssued = requestedAmount / 1000;
               if (numberofNotesToIssued > 0)
               {
                    if (numberofNotesToIssued > 1)
                    {
                         Console.WriteLine("" + numberofNotesToIssued + " OneThousand notes are Issued by OneThousandHandler");
                    }
                    else
                    {
                         Console.WriteLine("" + numberofNotesToIssued + " OneThousand note is Issued by OneThousandHandler");
                    }
               }
               int pendingAmountToBeProcessed = requestedAmount % 1000;

               if (pendingAmountToBeProcessed > 0)
               {
                    account.setRemainAmountTOIssueNotes(pendingAmountToBeProcessed);
                    successor.Withdraw(account);

               }


               return account;
          }
     }
}
