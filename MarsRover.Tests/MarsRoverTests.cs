using System.ComponentModel.DataAnnotations;
using FluentAssertions;

namespace MarsRover.Tests;

public class MarsRoverTests
{
    [Theory]
    [InlineData("0:0:N")]
    [InlineData("2:1:W")]
    public void PrintInitialState(string initialState)
    {
        // Arrange - Given
        MarsRover? marsRover = new MarsRover(initialState: initialState);
 
        // Act - When
        object? result = marsRover.Execute(commands: "");

        // Assert - Then
        result.Should().Be(initialState);
    }

    [Theory]
    [InlineData("0:0:N","0:1:N")]
    [InlineData("1:1:N","1:2:N")]
    [InlineData("1:1:W","0:1:W")]
    [InlineData("1:1:E","2:1:E")]
    public void MoveForward(string initialState, string expectedFinalState)
    {
        // Arrange - Given
        MarsRover? marsRover = new MarsRover(initialState: initialState);
 
        // Act - When
        object? result = marsRover.Execute(commands: "M");

        // Assert - Then
        result.Should().Be(expected: expectedFinalState);
    } 

    [Fact]
    public void Test() {
        Assert.True(condition: true);

    }
}
