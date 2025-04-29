namespace AncientOnesTranslator.Processors;

internal static class CharExtensions
{
    public static bool CompareCharsCaseInsensitive(this char c1, char c2)
    {
        return char.ToLowerInvariant(c1) == char.ToLowerInvariant(c2);
    }
}