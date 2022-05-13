using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsability
{
     class FiveHundredHandler : Handler
     { 
          public override BankAccount Withdraw(BankAccount account)
          {
               int requestedAmount = account.getRemainAmountTOIssueNotes();

               int numberofNotesToIssued = requestedAmount / 500;
               if (numberofNotesToIssued > 0)
               {
                    if (numberofNotesToIssued > 1)
                    {
                         Console.WriteLine("" + numberofNotesToIssued + " Five Hundred notes are Issued");
                    }
                    else
                    {
                         Console.WriteLine("" + numberofNotesToIssued + " Five Hundrad note is Issued");
                    }
               }
               int pendingAmountToBeProcessed = requestedAmount % 500;

               if (pendingAmountToBeProcessed > 0)
               {
                    account.setRemainAmountTOIssueNotes(pendingAmountToBeProcessed);
                    successor.Withdraw(account);

               }


               return account;
          }
     }
}
