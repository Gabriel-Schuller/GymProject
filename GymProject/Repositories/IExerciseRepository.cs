using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymProject.Models
{
    public interface IExerciseRepository
    {
        IEnumerable<Exercise> AllExercises { get; }
        IEnumerable<Exercise> ExercisesOfCategory(int categoryId);
        Exercise GetExerciseById(int exerciseId);
    }
}
