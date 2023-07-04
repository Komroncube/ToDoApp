using System.Data;
using System.Threading.Tasks;

namespace ClassServises
{
    public class Taskdoing : ITask
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly DueDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }

        public Taskdoing() 
        {
            Id = Guid.NewGuid();
        }
        public Taskdoing(string title, string description, DateOnly dueDate, Priority priority, Status status)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            DueDate = dueDate;
            Priority = priority;
            Status = status;
        }
        public static void TaskToTable(DataTable dt, List<Taskdoing> tasks)
        {
            foreach (var item in tasks)
            {
                dt.Rows.Add(item.Id.ToString(), item.Title, item.Description, item.DueDate.ToString(), item.Priority.ToString(), item.Status.ToString());
            }
        }
    }
}