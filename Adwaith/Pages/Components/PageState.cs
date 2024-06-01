using Adwaith.Application.Models;

namespace Adwaith.Pages.Components
{
    public class PageState
    {
        public User User { get; set; } = new();
        public string AppName { get; set; }
    }
}