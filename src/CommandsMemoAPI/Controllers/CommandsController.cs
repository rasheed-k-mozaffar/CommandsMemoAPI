using Microsoft.AspNetCore.Mvc;
using CommandsMemoAPI.Repositories;
using CommandsMemoAPI.Models;
using AutoMapper;
using CommandsMemoAPI.Dtos;

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
    private readonly IMapper _mapper;

    public CommandsController(ICommandAPIRepo commandRepo, IMapper mapper)
    {
        _commandRepo = commandRepo;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CommandReadDto>>> GetAll()
    {
        var commandItems = await _commandRepo.GetAllCommandsAsync();

        var commandItemsAsDto = _mapper.Map<IEnumerable<CommandReadDto>>(commandItems);

        return Ok(commandItemsAsDto);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CommandReadDto>> GetById(int id)
    {
        var commandItem = await _commandRepo.GetCommandByIdAsync(id);
        if (commandItem is null)
            return NotFound($"No command was found with the ID: {id}");

        var commandItemAsDto = _mapper.Map<CommandReadDto>(commandItem);

        return Ok(commandItemAsDto);
    }
}
