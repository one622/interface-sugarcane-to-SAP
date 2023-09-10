using System.ComponentModel.DataAnnotations;

namespace interface_sugarcane_to_SAP.Models
{
    public class getpostsql
    {
        [Key]
        public int uid { get; set; }

        [Required]
        public int oilamoun { get; set; } 

        public string trucoil { get; set; } 

        public DateTime transdate { get; set; } 

        public int approvestatus { get; set; } 

        public int approver { get; set; } 
    }
}
