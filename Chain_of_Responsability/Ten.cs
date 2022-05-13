using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsability
{
     class Ten : Handler
     {
          public override BankAccount Withdraw(BankAccount account)
          {
               int requestedAmount = account.getRemainAmountTOIssueNotes();

               int numberofNotesToIssued = requestedAmount / 10;
               if (numberofNotesToIssued > 0)
               {
                    if (numberofNotesToIssued > 1)
                    {
                         Console.WriteLine("" + numberofNotesToIssued + "  Ten notes are Issued");
                    }
                    else
                    {
                         Console.WriteLine("" + numberofNotesToIssued + " Ten note is Issued");
                    }
               }
               int pendingAmountToBeProcessed = requestedAmount % 10;

               if (pendingAmountToBeProcessed > 0)
               {
                    account.setRemainAmountTOIssueNotes(pendingAmountToBeProcessed);
                    successor.Withdraw(account);
               }

               return account;
          }
     }
}
