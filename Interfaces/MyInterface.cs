using WebApplicationUserstories.MockData;
using WebApplicationUserstories.Models;

namespace WebApplicationUserstories3.Interfaces
{
    public interface MyInterface
    {


        public List<UserStory> GetUserStories();


        public UserStory ? GetUserStory(int ? id);


        public UserStory DeleteUserStory(int userstoryId);
        
    }
}
