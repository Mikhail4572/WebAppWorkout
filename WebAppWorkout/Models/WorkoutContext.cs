namespace WebAppWorkout.Models;

public static class WorkoutContext
{
    private readonly static List<WorkoutItem> _data = [];
    private static int _nextId = 1;
    public static IReadOnlyList<WorkoutItem> All => _data;

    public static void AddItem(WorkoutItem item)
    {
        item.Id = _nextId++;
        _data.Add(item);
    }
}
   