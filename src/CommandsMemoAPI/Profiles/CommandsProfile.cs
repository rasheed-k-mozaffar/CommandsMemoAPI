using AutoMapper;
using CommandsMemoAPI.Models;
using CommandsMemoAPI.Dtos;

namespace CommandsMemoAPI.Profiles;

public class CommandsProfile : Profile
{
    public CommandsProfile()
    {
        //Source -> Target
        CreateMap<Command, CommandReadDto>();
        CreateMap<CommandCreateDto, Command>();
        CreateMap<CommandUpdateDto, Command>();
    }
}