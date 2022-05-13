using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Users
{
    class CommonUser : BaseUser
    {

        public CommonUser(IFacebookMediator mediator, string id) : base(mediator, id)
        {
            mediator.AddUser(this);
        }

        public override void AddFriend(string profileId)
        {
            mediator.AddFriend(this, profileId);
        }

        public override void SendPostToUser(string post, string toId)
        {
            mediator.SendPostToUser(post, this, toId);
        }

        public override void VisualizeProfile(string profileId)
        {
            mediator.VisualizeProfile(this, profileId);
        }

        public override void ReceivePost(BaseUser fromUser, string post)
        {
            Console.WriteLine($"User-ul cu id {this.Id} a receptionat postarea utilizatorului cu id {fromUser.Id}");
            Console.WriteLine($"User-ul cu id {this.Id} a postat pe profil postarea: \"" + post + "\"");
        }
    }
}
