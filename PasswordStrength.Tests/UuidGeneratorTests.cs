using Xunit;
using System;
using System.Text.RegularExpressions;

public class UuidGeneratorTests
{
    [Fact]
    public void GenerateV4Uuid_ShouldReturnValidV4Uuid()
    {
        // Arrange
        var uuid = UuidGenerator.GenerateV4Uuid();

        // Assert: matches UUID format
        Assert.Matches(@"^[0-9a-f]{8}-[0-9a-f]{4}-4[0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$", uuid);

        // Assert: parses successfully
        Assert.True(Guid.TryParse(uuid, out _));
    }
}
