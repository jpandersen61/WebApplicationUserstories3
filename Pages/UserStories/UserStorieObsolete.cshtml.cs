using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationUserstories.Services;
using WebApplicationUserstories.Models;
using WebApplicationUserstories3.Interfaces;

namespace WebApplicationUserstories.Pages.UserStories
{
    public class UserStoriesModel : PageModel
    {
        private MyInterface userStoryService;

        public List<UserStory>? UserStories { get; private set; }

        public UserStoriesModel(MyInterface userStoryService)
        {
            this.userStoryService = userStoryService;
        }

        
        public void OnGet()
        {
            UserStories = userStoryService.GetUserStories();
        }
    }
}
