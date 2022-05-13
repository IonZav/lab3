using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediators
{
    class FacebookMediator : IFacebookMediator
    {
        private List<BaseUser> _users;

        public FacebookMediator()
        {
            _users = new List<BaseUser>();

        }

        public void AddFriend(BaseUser user, string profileId)
        {
            BaseUser friend = _users.FirstOrDefault(u => u.Id == profileId);

            if (friend == null)
            {
                Console.WriteLine($"User-ul cu id-ul {profileId} nu exista!");

            }
            else
            {
                user.friends.Add(friend);
                Console.WriteLine($"User-ul cu id-ul {profileId} a fost adaugat in lista de prieteni ai utilizatorului {user.Id}!");
            }
        }

        public void SendPostToUser(string post, BaseUser user, string profileId)
        {
            BaseUser receiver = user.friends.FirstOrDefault(user => user.Id == profileId);

            if (receiver != null)
            {
                receiver.ReceivePost(user, post);
            }
            else
            {
                Console.WriteLine($"Can't send post to user {profileId} because it doesn't exists in {user.Id}'s friend list!");
            }
        }

        public void VisualizeProfile(BaseUser user, string profileId)
        {
            Console.WriteLine($"Profilul cu id-ul {profileId} a fost vizitat de {user.Id}");
        }

        public void AddUser(BaseUser user)
        {
            _users.Add(user);
        }
    }
}
