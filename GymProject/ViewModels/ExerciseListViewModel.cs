using GymProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProject.ViewModels
{
    public class ExerciseListViewModel
    {
        public IEnumerable<Exercise> Exercises{ get; set; }
        public string CurrentCategory { get; set; }

        public ExerciseListViewModel(IEnumerable<Exercise> exercises, string currentCategory)
        {
            Exercises = exercises;
            CurrentCategory = currentCategory;
        }
    }
}
