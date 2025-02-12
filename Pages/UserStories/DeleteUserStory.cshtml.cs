using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationUserstories.Services;
using WebApplicationUserstories.Models;
using WebApplicationUserstories3.Interfaces;

namespace WebApplicationUserstories.Pages.UserStories
{
    public class DeleteUserStoryModel : PageModel
    {
        private MyInterface userStoryService;


        //public int UserStoryIDToBeDeleted { get; set; }
        [BindProperty]
        public UserStory UserStory { get; set; }

        public DeleteUserStoryModel(MyInterface userStoryService)
        {
            this.userStoryService = userStoryService;
        }

        public void OnGet(int id)
        {
            UserStory = userStoryService.GetUserStory(id);
            
        }

        public IActionResult OnPost()
        {
            UserStory deletedUserStory = userStoryService.DeleteUserStory(UserStory.Id);
            return RedirectToPage("UserStoryDetailModel");
        }



    }
}
