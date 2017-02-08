using Microsoft.AspNetCore.Mvc; 
public class HomePageController : Controller 
{
    public IActionResult Index() { 
        //return Ok("This is the index of the HomePageController");
        return View();
    } 
    public IActionResult Quote() {
        return Ok("This is a home quote");
    }
}