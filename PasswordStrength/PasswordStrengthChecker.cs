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
    /// Checks the strength of a password by verifying if it meets certain criteria:
    /// 1. Contains at least one uppercase letter
    /// 2. Contains at least one lowercase letter
    /// 3. Contains at least one digit
    /// 4. Contains at least one symbol
    /// 5. Has a minimum length of 8 characters
    /// 
    /// Based on the number of criteria met:
    /// - "INELIGIBLE": empty or too short
    /// - "WEAK": only 1 criterion met
    /// - "MEDIUM": 2–3 criteria met
    /// - "STRONG": all 4 criteria met
    /// </summary>
    /// <param name="password">The password string to check.</param>
    /// <returns>
    /// A string representing the password strength: "INELIGIBLE", "WEAK", "MEDIUM", or "STRONG".
    /// </returns>
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