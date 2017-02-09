using System;
using Microsoft.AspNetCore.Mvc; 
using FisherInsurance.Quotes;
public class LifeController : Controller 
{
    public IActionResult Index() { 
        //return Ok("This is the index of the LifeController");
        return View();
    } 
    public IActionResult Quote() {
        Quote quote = new Quote 
        { 
            Id = 456, 
            Product = "Life Insurance", 
            ExpireDate = DateTime.Now.AddDays(45), 
            Price = 25.00M 
        };
        return View(quote);
    }
}