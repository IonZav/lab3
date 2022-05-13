using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsability
{
     class One : Handler
     {
          public override BankAccount Withdraw(BankAccount account)
          {
               int requestedAmount = account.getRemainAmountTOIssueNotes();

               int numberofNotesToIssued = requestedAmount / 1;
               if (numberofNotesToIssued > 0)
               {
                    if (numberofNotesToIssued > 1)
                    {
                         Console.WriteLine("" + numberofNotesToIssued + "  One notes are issued ");
                    }
                    else
                    {
                         Console.WriteLine("" + numberofNotesToIssued + " One note is issued ");
                    }
               }
               int pendingAmountToBeProcessed = requestedAmount % 1;

               if (pendingAmountToBeProcessed > 0)
               {
                    account.setRemainAmountTOIssueNotes(pendingAmountToBeProcessed);
                    successor.Withdraw(account);
               }

               return account;
          }
     }
}
