using System.Collections.Generic;
using System.Text;

namespace JiraSynchronizer.Models
{

    public class ProjectResponse
    {
        public string expand { get; set; }
        public int startAt { get; set; }
        public int maxResults { get; set; }
        public int total { get; set; }
        public List<Issue> issues { get; set; }
    }
     
}
