using System;

namespace job_seek.Client.Shared
{
    public class Applications
    {
        public int ApplicationId { get; set; }
        public DateTime DateTime { get; set; }
        public String Description { get; set; }
    public Applications()
    {

    }

    public Applications(int applicationId, DateTime dateTime, string description)
    {
            this.ApplicationId = applicationId;
            this.DateTime = dateTime;
            this.Description = description;
    }
    }
}

