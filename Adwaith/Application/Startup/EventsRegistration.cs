using Adwaith.Application.Events;
using Adwaith.Application.Events.Listeners;
using Coravel;
using Coravel.Events.Interfaces;

namespace Adwaith.Application.Startup
{
    public static class EventsRegistration
    {
        public static IServiceProvider SetupEvents(this IServiceProvider services)
        {
            IEventRegistration registration = services.ConfigureEvents();

            // add events and listeners here
            registration
                .Register<UserCreated>()
                .Subscribe<EmailNewUser>();

            return services;
        }
    }
}
