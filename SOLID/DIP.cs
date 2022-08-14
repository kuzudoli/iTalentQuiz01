using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID
{
    //Subject: Newspaper subscription
    internal interface ISubscription
    {
        void SendNewspaper();
    }

    internal class Bloomberg : ISubscription
    {
        public void SendNewspaper()
        {
            Console.WriteLine("Gazete gönderildi! (Bloomberg)");
        }
    }

    internal class NYTimes : ISubscription
    {
        public void SendNewspaper()
        {
            Console.WriteLine("Gazete gönderildi! (NYTimes)");
        }
    }

    internal class SubscriptionManager
    {
        private ISubscription _subscription;
        public SubscriptionManager(ISubscription subscription)
        {
            _subscription = subscription;
        }
        public void SendNewspaper()
        {
            _subscription.SendNewspaper();
        }
    }
}
