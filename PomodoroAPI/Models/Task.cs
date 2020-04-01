

namespace PomodoroAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    //model created from database for Task object
    public partial class Task
    {
        public int ID { get; set; }
        public string TaskName { get; set; }
        public string IsComplete { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual User User { get; set; }
    }
}
