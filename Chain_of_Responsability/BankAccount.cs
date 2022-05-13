using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsability
{
     class BankAccount
     {
          private int RequestedAmount;
          private int TotalAmount;
          private int RemainAmountTOIssueNotes;


          public BankAccount( int requestedAmount)
          {
               RequestedAmount = requestedAmount;
          }

          public int getRequestedAmount()
          {
               return RequestedAmount;
          }

          public int getTotalAmount()
          {
               return TotalAmount;
          }

          public int getRemainAmountTOIssueNotes()
          {
               return RemainAmountTOIssueNotes;
          }

          public void setRemainAmountTOIssueNotes(int remainAmountTOIssueNotes)
          {
               RemainAmountTOIssueNotes = remainAmountTOIssueNotes;
          }
     }
}
