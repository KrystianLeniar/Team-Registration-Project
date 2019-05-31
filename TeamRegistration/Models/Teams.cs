using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamRegistration.Models
{
    public class Teams
    {

        [Key]
        public int TeamsId { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="This field is required")]
        [DisplayName("Full Team Name")]
        public string TeamName { get; set; }
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Leader Name")]
        public string LeaderName { get; set; }
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Call Number")]
        public string CallNumber { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Team Location")]
        public string TeamLocation { get; set; }
    }
}
