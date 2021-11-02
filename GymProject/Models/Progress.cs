using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymProject.Models
{
    public class Progress
    {
        public int ProgressId { get; set; }
        public DateTime Date { get; set; }
        public List<Exercise> ExercisesPerformed { get; set; }
    }
}
