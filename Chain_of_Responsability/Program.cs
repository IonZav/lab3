using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsability
{
     class Program
     {
          static void Main(string[] args)
          {
               FiveThousandHandler fiveThousand = new FiveThousandHandler();
               OneThousandHandler oneThousand = new OneThousandHandler();
               FiveHundredHandler fiveHundred = new FiveHundredHandler();
               HundredHandler hundred = new HundredHandler();
               Fifteen fifteen = new Fifteen();
               Twenty twenty = new Twenty();
               Ten ten = new Ten();
               One one = new One();

               fiveThousand.setSuccessor(oneThousand);
               oneThousand.setSuccessor(fiveHundred);
               fiveHundred.setSuccessor(hundred);
               hundred.setSuccessor(fifteen);
               fifteen.setSuccessor(twenty);
               twenty.setSuccessor(ten);
               ten.setSuccessor(one);

               BankAccount Jamal = new BankAccount(3200);
               BankAccount John = new BankAccount(8935);

               Console.WriteLine("" + fiveThousand.Withdraw(Jamal));
               Console.WriteLine("===============================================");
               Console.WriteLine("" + fiveThousand.Withdraw(John));
               Console.ReadKey();
          }
     }
}
