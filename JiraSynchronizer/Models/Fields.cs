using System;
using System.Collections.Generic;

namespace JiraSynchronizer.Models
{
    public class Fields
    {
        public Issuetype issuetype { get; set; }
        public List<object> components { get; set; }
        public object timespent { get; set; }
        public int? timeoriginalestimate { get; set; }
        public string description { get; set; }
        public Project project { get; set; }
        public List<object> fixVersions { get; set; }
        public object aggregatetimespent { get; set; }
        public object resolution { get; set; }
        public string customfield_10005 { get; set; }
        public object aggregatetimeestimate { get; set; }
        public object resolutiondate { get; set; }
        public int workratio { get; set; }
        public string summary { get; set; }
        public DateTime? lastViewed { get; set; }
        public Watches watches { get; set; }
        public Creator creator { get; set; }
        public List<object> subtasks { get; set; }
        public DateTime created { get; set; }
        public Reporter reporter { get; set; }
        public object customfield_10000 { get; set; }
        public Aggregateprogress aggregateprogress { get; set; }
        public Priority priority { get; set; }
        public List<object> labels { get; set; }
        public object customfield_10004 { get; set; }
        public object environment { get; set; }
        public object timeestimate { get; set; }
        public int? aggregatetimeoriginalestimate { get; set; }
        public List<object> versions { get; set; }
        public object duedate { get; set; }
        public Progress progress { get; set; }
        public List<object> issuelinks { get; set; }
        public Votes votes { get; set; }
        public Assignee assignee { get; set; }
        public DateTime updated { get; set; }
        public Status status { get; set; }
    }
}
