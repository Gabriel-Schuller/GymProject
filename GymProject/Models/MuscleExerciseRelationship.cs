namespace GymProject.Models
{
    public class MuscleExerciseRelationship
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public int MuscleId { get; set; }
    }
}