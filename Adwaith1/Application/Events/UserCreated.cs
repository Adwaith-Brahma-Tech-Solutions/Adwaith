using Adwaith1.Application.Models;
using Coravel.Events.Interfaces;

namespace Adwaith1.Application.Events
{
    public class UserCreated : IEvent
    {
        public User User { get; set; }

        public UserCreated(User user)
        {
            this.User = user;
        }
    }
}
