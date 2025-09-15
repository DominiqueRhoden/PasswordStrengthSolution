using System;

public static class UuidGenerator
{   /// <summary>
    /// Generates a valid version 4 UUID.
    /// A version 4 UUID is randomly generated and follows the format:
    /// xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx
    /// where '4' indicates version 4, and 'y' is one of 8, 9, A, or B.
    /// </summary>
    /// <returns>
    /// A string containing a version 4 UUID (e.g., "3f2504e0-4f89-41d3-9a0c-0305e82c3301").
    /// </returns>

    public static string GenerateV4Uuid()
    {
        return Guid.NewGuid().ToString();
    }
}
