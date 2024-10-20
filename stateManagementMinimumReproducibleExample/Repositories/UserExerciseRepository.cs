using stateManagementMinimumReproducibleExample.Models;

namespace stateManagementMinimumReproducibleExample.Repositories
{
    public class UserExerciseRepository
    {
        private List<Exercise> _dummyExercises;

        public UserExerciseRepository()
        {
            _dummyExercises = new List<Exercise>
        {
            new Exercise { Id = 1, Name = "Bench Press", WorkoutType = WorkoutType.UpperBody, ExerciseType = ExerciseType.Main },
            new Exercise { Id = 2, Name = "Push Up", WorkoutType = WorkoutType.UpperBody, ExerciseType = ExerciseType.Secondary },
            new Exercise { Id = 3, Name = "Tricep Dips", WorkoutType = WorkoutType.UpperBody, ExerciseType = ExerciseType.Accessory },
            new Exercise { Id = 4, Name = "Squats", WorkoutType = WorkoutType.LowerBody, ExerciseType = ExerciseType.Main },
            new Exercise { Id = 5, Name = "Lunges", WorkoutType = WorkoutType.LowerBody, ExerciseType = ExerciseType.Secondary },
            new Exercise { Id = 6, Name = "Leg Curl", WorkoutType = WorkoutType.LowerBody, ExerciseType = ExerciseType.Accessory }
        };
        }

        public Task<List<Exercise>> GetExercisesBasedOnWorkoutType(WorkoutType workoutType)
        {
            return Task.FromResult(_dummyExercises.Where(e => e.WorkoutType == workoutType).ToList());
        }

        public List<Exercise> GetExercisesFromWorkoutListBasedOnExerciseType(List<Exercise> workoutExercises, ExerciseType exerciseType)
        {
            return workoutExercises.Where(e => e.ExerciseType == exerciseType).ToList();
        }
    }

}
