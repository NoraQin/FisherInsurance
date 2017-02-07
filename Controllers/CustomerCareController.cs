using Microsoft.AspNetCore.Mvc; 
[Route("claim")]
public class CustomerCareController : Controller 
{
    [Route("index")]
    public IActionResult Index() { 
        return Ok("This is the index of the CustomerCareController"); 
    } 
    [Route("claim")]
    public IActionResult Quote() {
        return Ok("This is a customer care claim");
    }
    [Route("fileclaim")]
    public IActionResult NewClaim() {
        return Ok("Filing a claim");
    }
    [Route("myclaims")]
    public IActionResult ClaimHistory() {
        return Ok("Checking status");
    }
}