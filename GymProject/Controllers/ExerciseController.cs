using GymProject.Models;
using GymProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace GymProject.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly IExerciseRepository _exerciseRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ExerciseController(IExerciseRepository exerciseRepository, ICategoryRepository categoryRepository)
        {
            _exerciseRepository = exerciseRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List(string category)
        {
            IEnumerable<Exercise> exercise;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                exercise = _exerciseRepository.AllExercises.OrderBy(e => e.ExerciseId);
                currentCategory = "All Exercises";
            }
            else
            {
                exercise = _exerciseRepository.AllExercises.Where(e => e.Category.Name == category)
                    .OrderBy(e => e.ExerciseId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.Name == category)?.Name;

            }
            return View(new ExerciseListViewModel(exercise, currentCategory));
        }
        
        
        public string Test(string category)
        {
            Console.WriteLine(category);
            return Json(category).ContentType;
        }

        public IActionResult Details(int id)
        {
            var exercise = _exerciseRepository.GetExerciseById(id);
            if (exercise== null)
                return NotFound();

            return View(exercise);
        }
    }
}
