

namespace WebApplicationUserstories.Models
{
    public class UserStory
    {
        private static int nextId=0;
        public int Id { get;  set; }
        public string Title { get; set; }
        public string Description { get; set; }

        void NextID()
        {
            nextId++;
            Id = nextId;
        }

        public UserStory()
        {
            Id = 0;
            Title = "";
            Description = "";
        }

        public UserStory(string title, string description)
        {
            NextID();
            Title = title;
            Description = description;
        }


    }
}
