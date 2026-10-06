using System.ComponentModel.DataAnnotations;

namespace WebAppWorkout.Models;

public class WorkoutItem
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Укажите продолжительность упражнения")]
    [Display(Name = "Продолжительность выполнения упражнения")]
    public int Duration { get; set; }

    [Required(ErrorMessage = "Укажите кол-во сожжёных колорий")]
    [Display(Name = "Кол-во сожжёных колорий")]
    public int Calories { get; set; }

    [Required(ErrorMessage = "Укажите тип тренировки")]
    [Display(Name = "Тип тренировки")]
    public string WorkoutType { get; set; }

    public DateTime Created { get; set; } = DateTime.UtcNow;

    [Required(ErrorMessage = "Укажите смайлик")]
    public string Smile { get; set; }

}
