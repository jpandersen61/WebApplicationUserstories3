using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationUserstories.Services;
using WebApplicationUserstories.Models;
using WebApplicationUserstories3.Interfaces;



namespace WebApplicationUserstories3.Pages.UserStories
{
    public class UserStoryDetailModelModel : PageModel
    {
        [BindProperty]
        public UserStory ? UserStory { get; set; }
        private MyInterface UserStoryService { get; set; }
        public List<UserStory> ? UserStories { get; private set; }

        public UserStoryDetailModelModel(MyInterface userStoryService)
        {
            UserStoryService = userStoryService;
        }

        public void OnGet(int ? id)
        {
            UserStories = UserStoryService.GetUserStories();
            UserStory = UserStoryService.GetUserStory(id);
        }

    }
}
