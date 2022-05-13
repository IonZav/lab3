using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
     abstract class NewsPublicBid
     {
          protected List<INewsBid> _bidders = new List<INewsBid>();

          public void AddBidder(INewsBid subscriber)
          {
               _bidders.Add(subscriber);
          }

          public void RemoveBidder(INewsBid subscriber)
          {
               _bidders.Remove(subscriber);
          }

          public void NotifyBidders()
          {
               foreach (var bidder in _bidders)
                    bidder.Update();
          }

     }
}
