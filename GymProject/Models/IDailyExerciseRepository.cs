using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymProject.Models
{
    public interface IDailyExerciseRepository
    {
        IEnumerable<Progress> AllDays { get; }
        Progress GetProgressByDay(DateTime day);
    }
}
