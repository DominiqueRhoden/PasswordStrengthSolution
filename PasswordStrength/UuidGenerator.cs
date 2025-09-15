using System;

public static class UuidGenerator
{
    /// <summary>
    /// Generates a valid version 4 UUID (random).
    /// </summary>
    /// <returns>A new UUID string in the format xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx.</returns>
    public static string GenerateV4Uuid()
    {
        return Guid.NewGuid().ToString();
    }
}
