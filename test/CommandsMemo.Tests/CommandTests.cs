using System;
using Xunit;
using CommandsMemoAPI.Models;

namespace CommandsMemo.Tests;

public class CommandTests : IDisposable
{

    Command commandTest;

    public CommandTests()
    {
        commandTest = new Command
        {
            HowTo = "Some How to",
            Platform = "Some Platform",
            CommandLine = "Some Command Line"
        };
    }

    public void Dispose()
    {
        commandTest = null;
    }


    [Fact]
    public void CanChangeHowTo()
    {
        //Arrange

        //Act
        commandTest.HowTo = "Execute unit tests";

        //Assert
        Assert.Equal("Execute unit tests", commandTest.HowTo);
    }

    [Fact]
    public void CanChangePlatform()
    {
        //ARRANGE

        //ACT
        commandTest.Platform = "Universal";

        //ASSERT
        Assert.Equal("Universal", commandTest.Platform);
    }

    [Fact]
    public void CanChangeCommandLine()
    {
        //ARRANGE

        //ACT
        commandTest.CommandLine = "git init";

        //ASSERT
        Assert.Equal("git init", commandTest.CommandLine);
    }

}

