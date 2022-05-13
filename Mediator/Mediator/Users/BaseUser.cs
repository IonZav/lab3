using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class BaseUser
    {
        protected IFacebookMediator mediator;

        public readonly string Id;
        public List<BaseUser> friends { get; set; }

        public BaseUser(IFacebookMediator mediator, string id)
        {
            this.mediator = mediator;
            Id = id;
            friends = new List<BaseUser>();
        }

        abstract public void AddFriend(string profileId);
        abstract public void SendPostToUser(string post, string toId);
        abstract public void VisualizeProfile(string profileId);
        abstract public void ReceivePost(BaseUser fromUser, string post);
    }
}
