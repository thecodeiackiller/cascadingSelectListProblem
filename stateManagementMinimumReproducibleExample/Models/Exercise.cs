namespace stateManagementMinimumReproducibleExample.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public WorkoutType WorkoutType { get; set; }
    }
}
