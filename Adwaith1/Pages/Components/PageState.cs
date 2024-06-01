using Adwaith1.Application.Models;

namespace Adwaith1.Pages.Components
{
    public class PageState
    {
        public User User { get; set; } = new();
        public string AppName { get; set; }
    }
}