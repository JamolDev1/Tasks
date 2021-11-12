using System;


namespace Tasks 
{
    public class Tasks
    {
        public Guid Id{ get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }
        public string Tags { get; set; }
        public DateTimeOffset OnADay { get; set; }

        public DateTimeOffset AtATime { get; set; }

        public ETasksStatus Status { get; set; }

        public ETasksRepeat Repeat { get; set; }

        public ETasksPriority Priority { get; set; }

        public string Location { get; set; }

        public string Url { get; set; }        
        
        
        
        
        
        
    }
}