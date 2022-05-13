using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsability
{
     class Fifteen : Handler
     {
          public override BankAccount Withdraw(BankAccount account)
          {
               int requestedAmount = account.getRemainAmountTOIssueNotes();

               int numberofNotesToIssued = requestedAmount / 50;
               if (numberofNotesToIssued > 0)
               {
                    if (numberofNotesToIssued > 1)
                    {
                         Console.WriteLine("" + numberofNotesToIssued + "  Fifteen notes are Issued");
                    }
                    else
                    {
                         Console.WriteLine("" + numberofNotesToIssued + " Fifteen note is Issued");
                    }
               }
               int pendingAmountToBeProcessed = requestedAmount % 50;

               if (pendingAmountToBeProcessed > 0)
               {
                    account.setRemainAmountTOIssueNotes(pendingAmountToBeProcessed);
                    successor.Withdraw(account);
               }

               return account;
          }
     }
}
