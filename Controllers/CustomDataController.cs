

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Recipies.Client;

namespace Easyweb.Controllers;

public class CustomDataController : Controller
{

    private readonly RecipieClient _recipieClient;

    public CustomDataController(RecipieClient recipieClient)
    {
        _recipieClient = recipieClient;
    }

    [HttpGet("/data")]
    public virtual async Task<IActionResult> Index()
    {
        var data = await _recipieClient.GetRecipies();
        return View(data);
    }

    
}


