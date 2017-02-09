using System;
using Microsoft.AspNetCore.Mvc; 
using FisherInsurance.Quotes;
public class HomePageController : Controller 
{
    public IActionResult Index() { 
        //return Ok("This is the index of the HomePageController");
        return View();
    } 
    public IActionResult Quote() {
        Quote quote = new Quote 
        { 
            Id = 123, 
            Product = "Home Insurance", 
            ExpireDate = DateTime.Now.AddDays(45), 
            Price = 35.00M 
        };
        return View(quote);
    }
}