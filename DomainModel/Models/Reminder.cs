using System.ComponentModel.DataAnnotations;

namespace RingoMediaProject.DomainModel.Models
{
    public class Reminder
    {
        [Key]
        public int RemainderID { get; set; }  
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsNofied { get; set; }
    }
}
