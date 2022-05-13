using Mediator.Mediators;
using Mediator.Users;

namespace Mediator
{
    class Program
    {
        public static void Main()
        {
            IFacebookMediator mediator = new FacebookMediator();

            BaseUser user1 = new CommonUser(mediator, "1242");
            BaseUser user2 = new CommonUser(mediator, "1243");
            BaseUser user3 = new CommonUser(mediator, "1244");

            user1.AddFriend("1234");
            user3.AddFriend("1242");
            user2.AddFriend("1242");

            Console.WriteLine();
            user3.SendPostToUser("Hello", "1244");
            user2.SendPostToUser("Hello", "1242");
        }
    }
}

