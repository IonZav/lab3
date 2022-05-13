using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    interface IFacebookMediator
    {
        void VisualizeProfile(BaseUser user, string profileId);
        void AddFriend(BaseUser user, string profileId);
        void SendPostToUser(string post, BaseUser user, string profileId);
        public void AddUser(BaseUser user);
    }
}
