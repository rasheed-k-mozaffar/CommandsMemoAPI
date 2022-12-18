using Microsoft.AspNetCore.Mvc;
using CommandsMemoAPI.Repositories;

namespace CommandsMemoAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommandsController : ControllerBase
{
    //This private read-only field will be assinged the CommandAPIrepo concrete class through the constructor

    /*
    When the constructor gets called , The DI system will get into action and inject the required 
    dependency when we ask for an instance of the ICommandAPIRepo.
    So we assing the injected dependency(CommandAPIRepo in our case) to our private read-only field. 
     */
    private readonly ICommandAPIRepo _commandRepo;

    public CommandsController(ICommandAPIRepo commandRepo)
    {
        _commandRepo = commandRepo;
    }

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] { "This", "is", "hard", "coded", " !" };
    }
}
