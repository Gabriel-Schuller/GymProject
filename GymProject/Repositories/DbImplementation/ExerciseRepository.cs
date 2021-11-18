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

        public IEnumerable<Exercise> ExercisesOfCategory(int categoryId)
        {
            return _appDbContext.Exercises.Include(c => c.Category).Where(e => e.CategoryId == categoryId);
        }

        public Exercise GetExerciseById(int exerciseId)
        {
            return _appDbContext.Exercises.FirstOrDefault(e => e.ExerciseId == exerciseId);
        }
    }
}
