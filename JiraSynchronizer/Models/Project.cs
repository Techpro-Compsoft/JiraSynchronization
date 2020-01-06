namespace JiraSynchronizer.Models
{
    public class Project
    {
        public string projectTypeKey { get; set; }

        public string self { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public AvatarUrls avatarUrls { get; set; }
    }
}
