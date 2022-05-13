using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
     class Program
     {
          static void Main(string[] args)
          {
               NewBidsPublisher BidLot = new NewBidsPublisher();

               NewsBidders Bidder1 = new NewsBidders(BidLot);
               NewsBidders Bidder2 = new NewsBidders(BidLot);
               NewsBidders Bidder3 = new NewsBidders(BidLot);

               BidLot.AddBidder(Bidder1);
               BidLot.AddBidder(Bidder2);
               BidLot.AddBidder(Bidder3);

               BidLot.SetLastBidInfo("230$");
               Console.WriteLine();
               BidLot.RemoveBidder(Bidder3);
               BidLot.SetLastBidInfo("260$");

               Console.ReadKey();

          }
     }
}
//bidder