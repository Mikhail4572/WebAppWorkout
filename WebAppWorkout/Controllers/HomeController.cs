using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using WebAppWorkout.Models;

namespace WebAppWorkout.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View(BuildViewModel());
    

    [HttpPost]
    public IActionResult Index(WorkoutItem newWorkout)
    {
        if (!ModelState.IsValid)
            return View(BuildViewModel(newWorkout));

        WorkoutContext.AddItem(newWorkout);

        return RedirectToAction("Index");
    }


    private WorkoutCreateViewModel BuildViewModel(WorkoutItem? newReview = null) => new()
    {
        Workouts = [.. WorkoutContext.All.OrderByDescending(x => x.Created)],
        NewWorkout = newReview ?? new()
    };

}