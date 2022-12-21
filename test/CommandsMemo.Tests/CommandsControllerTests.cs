using System;
using Xunit;
using CommandsMemoAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using CommandsMemoAPI.Data;
using CommandsMemoAPI.Repositories;
using CommandsMemoAPI.Models;
using AutoMapper;
using CommandsMemoAPI.Profiles;

namespace CommandsMemo.Tests;

public class CommndsControllerTests
{
    [Fact]
    public void GetCommandItems_ReturnsZeroItems_WhenDBIsEmpty()
    {
        //Arrange
        //We need to create an instace of our controller class
        var mockRepo = new Mock<ICommandAPIRepo>();
        mockRepo.Setup(repo => repo.GetAllCommandsAsync()).Returns(GetCommands(0));

        var realProfile = new CommandsProfile();
        var configuration = new MapperConfiguration(config => config.AddProfile(realProfile));
        IMapper mapper = new Mapper(configuration);



        var controller = new CommandsController(mockRepo.Object, mapper);

        //Act

        //Assert
    }

    private List<Command> GetCommands(int num)
    {
        var commands = new List<Command>();

        if (num > 0)
        {
            commands.Add
                (
                new Command
                {
                    Id = 0,
                    HowTo = "Update the database",
                    Platform = ".Net EF Core",
                    CommandLine = "dotnet ef database update"
                });
        }

        return commands;
    }
}