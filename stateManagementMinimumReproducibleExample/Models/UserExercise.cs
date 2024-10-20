namespace stateManagementMinimumReproducibleExample.Models
{
    public class UserExercise
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public WorkoutType WorkoutType { get; set; }
    }

}
