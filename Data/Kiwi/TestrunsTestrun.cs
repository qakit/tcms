using System;
using System.Collections.Generic;

#nullable disable

namespace tcms.Data.Kiwi
{
    public partial class TestrunsTestrun
    {
        public TestrunsTestrun()
        {
            TestrunsTestexecutions = new HashSet<TestrunsTestexecution>();
            TestrunsTestrunccs = new HashSet<TestrunsTestruncc>();
            TestrunsTestruntags = new HashSet<TestrunsTestruntag>();
        }

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? StopDate { get; set; }
        public string Summary { get; set; }
        public string Notes { get; set; }
        public int BuildId { get; set; }
        public int? DefaultTesterId { get; set; }
        public int ManagerId { get; set; }
        public int PlanId { get; set; }
        public int ProductVersionId { get; set; }
        public DateTime? PlannedStart { get; set; }
        public DateTime? PlannedStop { get; set; }

        public virtual ManagementBuild Build { get; set; }
        public virtual AuthUser DefaultTester { get; set; }
        public virtual AuthUser Manager { get; set; }
        public virtual TestplansTestplan Plan { get; set; }
        public virtual ManagementVersion ProductVersion { get; set; }
        public virtual ICollection<TestrunsTestexecution> TestrunsTestexecutions { get; set; }
        public virtual ICollection<TestrunsTestruncc> TestrunsTestrunccs { get; set; }
        public virtual ICollection<TestrunsTestruntag> TestrunsTestruntags { get; set; }
    }
}
