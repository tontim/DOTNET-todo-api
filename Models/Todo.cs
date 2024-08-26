using System.ComponentModel.DataAnnotations;

namespace ASPNET_todo_api.Models
{
    public class Todo
    {
        [Required] public int Id { get; set; }
        [Required] public string User { get; set; }
        [Required] public string Name { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }

        public int Date { get; set; }
    }
}
