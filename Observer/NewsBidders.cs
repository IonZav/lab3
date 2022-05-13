using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
     class NewsBidders : INewsBid
     {
          private readonly NewBidsPublisher _bidder;
          public NewsBidders(NewBidsPublisher bidder)
          {
               _bidder = bidder;
          }

          public void Update()
          {
               string info = _bidder.GetLastBidInfo();
               Console.WriteLine($"Bidder {this.GetHashCode()} receive info, highest bid: {info}");

          }
     }
}
