using JiraSynchronizer.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JiraSynchronizer
{
    class Program
    {
        static string username = "shakti.tanwar2002";
        static string password = "Shakti@123";
        static void Main(string[] args)
        {
            GetAllProjects();
            GetAllIssues("");
            Console.WriteLine("Hello World!");
        }

        public static void GetAllProjects()
        {
            
            string url = "http://192.168.1.46:8080/rest/api/2/project?jql=&maxResults=200";
            var api = new HttpClient();
            var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            api.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

            var response = api.GetAsync(url).Result;

            var projectResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<Project[]>(response.Content.ReadAsStringAsync().Result);

            AddOrUpdateProjectsInDatabase();
            foreach (var project in projectResponse)
            {
                GetAllIssues(project.name);
            }
        }

        private static void AddOrUpdateProjectsInDatabase()
        {
            throw new NotImplementedException();
        }

        public static void GetAllIssues(string projectName="TES")
        {
            string url = "http://192.168.1.46:8080/rest/api/latest/search?jql=project="+ projectName;
            var api = new HttpClient();
            var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            api.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

            var response = api.GetAsync(url).Result;

            ProjectResponse projectResponse= Newtonsoft.Json.JsonConvert.DeserializeObject<ProjectResponse>(response.Content.ReadAsStringAsync().Result);

            AddOrUpdateIssuesInDatabase();
        }

        private static void AddOrUpdateIssuesInDatabase()
        {
            throw new NotImplementedException();
        }
    }

    public interface IJiraClient
    {      

       // [//("rest/agile/1.0/board/{boardId}/sprint/{sprintId}/issue")]
        Task<GetIssuesForSprintResponse> GetIssuesForSprint(int boardId,int sprintId);

       // [Get("rest/agile/1.0/board/{boardId}/sprint?state=active")]
        Task<GetActiveSprintResponse> GetActiveSprint(int boardId);
    }

}
