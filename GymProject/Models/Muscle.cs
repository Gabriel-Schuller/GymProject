namespace GymProject.Models
{
    public class Muscle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public MuscleExerciseRelationship Relationship;
    }
}