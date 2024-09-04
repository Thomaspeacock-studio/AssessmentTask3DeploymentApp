using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HelloWorldApp.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome(string name, int NumTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Welcome {name}, NumTimes is = {NumTimes}");
    }
}