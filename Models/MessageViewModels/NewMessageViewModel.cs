using System.ComponentModel.DataAnnotations;

namespace Chatter.Models
{
    public class NewMessageViewModel
    {
        [Required]
        public string Content { get; set; }
    }
}