using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
     class NewBidsPublisher : NewsPublicBid
     {
          private string _lastBidInfo;
          public void SetLastBidInfo(string info)
          {
               _lastBidInfo = info;
               NotifyBidders();
          }

          public string GetLastBidInfo()
          {
               return _lastBidInfo;
          }
     }
}
