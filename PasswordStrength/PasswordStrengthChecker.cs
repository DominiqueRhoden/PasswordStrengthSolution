namespace PasswordStrength;

public static class PasswordStrengthChecker
{
    /// <summary>
    /// Checks password strength:
    /// - INELIGIBLE = 0 criteria met
    /// - WEAK = 1 criterion met
    /// - MEDIUM = 2 or 3 criteria met
    /// - STRONG = all 4 criteria met
    /// </summary>
    public static string CheckStrength(string? password)
    {
        if (string.IsNullOrEmpty(password))
            return "INELIGIBLE";

        bool hasUpper = false, hasLower = false, hasDigit = false, hasSymbol = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c)) hasUpper = true;
            else if (char.IsLower(c)) hasLower = true;
            else if (char.IsDigit(c)) hasDigit = true;
            else if (!char.IsWhiteSpace(c)) hasSymbol = true; // punctuation counts, whitespace doesn't
        }

        int criteriaMet = 0;
        if (hasUpper) criteriaMet++;
        if (hasLower) criteriaMet++;
        if (hasDigit) criteriaMet++;
        if (hasSymbol) criteriaMet++;

        return criteriaMet switch
        {
            0 => "INELIGIBLE",
            1 => "WEAK",
            2 => "MEDIUM",
            3 => "MEDIUM",
            4 => "STRONG",
            _ => "INELIGIBLE"
        };
    }
}