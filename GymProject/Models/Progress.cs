using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GymProject.Models
{
    public class Progress
    {
        public int ProgressId { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(450)]
        //[Column(TypeName = "varchar(10)")]
        public string AspNetUserId { get; set; }
    }
}
