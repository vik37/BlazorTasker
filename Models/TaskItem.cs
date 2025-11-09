using System.ComponentModel.DataAnnotations;

namespace BlazorTasker.Models
{
	public class TaskItem
	{
		public Guid Id { get; set; }
		[Required(ErrorMessage="Every task should have a name")]
		public string Name { get; set; } = string.Empty;
		public bool IsCompleted { get; set; } = false;
	}
}
