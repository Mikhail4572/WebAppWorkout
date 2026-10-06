namespace WebAppWorkout.Models;

public class WorkoutCreateViewModel
{
    public WorkoutItem NewWorkout { get; set; }

    public List<WorkoutItem> Workouts { get; set; }
}
