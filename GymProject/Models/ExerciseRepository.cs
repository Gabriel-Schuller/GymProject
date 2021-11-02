using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymProject.Models
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly AppDbContext _appDbContext;

        public ExerciseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Exercise> AllExercises => _appDbContext.Exercises.Include(e => e.Category);

        public IEnumerable<Exercise> ExercisesOfCategory(int IdOfCategory)
        {
            return _appDbContext.Exercises.Include(c => c.Category).Where(e => e.CategoryId == IdOfCategory);
        }

        public Exercise GetExerciseById(int ExerciseId)
        {
            return _appDbContext.Exercises.FirstOrDefault(e => e.ExerciseId == ExerciseId);
        }
    }
}
