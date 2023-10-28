using System.ComponentModel.DataAnnotations;
using FluentAssertions;

namespace MarsRover.Tests;

public class MarsRoverTests
{
    [Theory]
    [InlineData("0:0:N", "", "0:0:N")]
    [InlineData("2:1:W", "", "2:1:W")]
    [InlineData("0:0:N", "M", "0:1:N")]
    [InlineData("1:1:N", "M", "1:2:N")]
    [InlineData("1:1:W", "M", "0:1:W")]
    [InlineData("1:1:E", "M", "2:1:E")]
    [InlineData("1:1:S", "M", "1:0:S")]
    [InlineData("1:1:S", "R", "1:1:W")]
    [InlineData("1:1:W", "R", "1:1:N")]
    [InlineData("1:1:N", "R", "1:1:E")]
    [InlineData("1:1:E", "R", "1:1:S")]
    [InlineData("1:1:S", "L", "1:1:E")]
    [InlineData("1:1:W", "L", "1:1:S")]
    [InlineData("1:1:N", "L", "1:1:W")]
    [InlineData("1:1:E", "L", "1:1:N")]
    [InlineData("1:1:W", "LL", "1:1:E")]
    public void ExecuteCommands(string initialState, string commands, string expectedFinalState)
    {
        // Arrange - Given
        MarsRover? marsRover = new MarsRover(initialState: initialState);

        // Act - When
        var result = marsRover.Execute(stringCommands: commands);

        // Assert - Then
        result.Should().Be(expected: expectedFinalState);    
    } 
}
