using PasswordStrength;
using Xunit;

namespace PasswordStrength.Tests;

public class PasswordStrengthCheckerTests
{
    [Theory]
    [InlineData("", "INELIGIBLE")]     // none
    [InlineData(" ", "INELIGIBLE")]    // whitespace not symbol
    [InlineData("ABC", "WEAK")]        // only uppercase
    [InlineData("abc", "WEAK")]        // only lowercase
    [InlineData("123", "WEAK")]        // only digit
    [InlineData("!@#", "WEAK")]        // only symbols
    [InlineData("Abc", "MEDIUM")]      // upper + lower
    [InlineData("A1", "MEDIUM")]       // upper + digit
    [InlineData("a1", "MEDIUM")]       // lower + digit
    [InlineData("A!", "MEDIUM")]       // upper + symbol
    [InlineData("a!", "MEDIUM")]       // lower + symbol
    [InlineData("1!", "MEDIUM")]       // digit + symbol
    [InlineData("Ab1", "MEDIUM")]      // upper + lower + digit
    [InlineData("Ab!", "MEDIUM")]      // upper + lower + symbol
    [InlineData("a1!", "MEDIUM")]      // lower + digit + symbol
    [InlineData("Ab1!", "STRONG")]     // all criteria met
    [InlineData("Ab1!", "INELIGIBLE")]  // too short, even though criteria met
    [InlineData("Abcdef1!", "STRONG")]  // length ok, all criteria met
    [InlineData("abcdefg1", "MEDIUM")]  // length ok, lower + digit

    public void CheckStrength_ReturnsExpected(string input, string expected)
    {
        var result = PasswordStrengthChecker.CheckStrength(input);
        Assert.Equal(expected, result);
    }
}
