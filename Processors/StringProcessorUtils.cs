using System.Collections.Generic;

namespace AncientOnesTranslator.Processors;

internal static class StringProcessorUtils
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    
    #region Data
    
    private static readonly Dictionary<char, char> DoubleLettersReplacers = new()
    {
        { 'a', 'α' },
        { 'b', 'β' },
        { 'c', 'γ' },
        { 'd', 'δ' },
        { 'e', 'ε' },
        { 'f', 'ζ' },
        { 'g', 'η' },
        { 'h', 'θ' },
        { 'i', 'ι' },
        { 'j', 'ї' },
        { 'k', 'λ' },
        { 'l', 'μ' },
        { 'm', 'ν' },
        { 'n', 'ξ' },
        { 'o', 'ο' },
        { 'p', 'π' },
        { 'q', 'ρ' },
        { 'r', 'σ' },
        { 's', 'τ' },
        { 't', 'υ' },
        { 'u', 'φ' },
        { 'v', 'χ' },
        { 'w', 'ψ' },
        { 'x', 'ω' },
        { 'y', 'у' },
        { 'z', 'ζ' },
    };

    #endregion
    
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    
    #region Extension
    
    public static bool CompareCharsCaseInsensitive(this char c1, char c2)
    {
        return char.ToLowerInvariant(c1) == char.ToLowerInvariant(c2);
    }
    
    public static bool TryGetDoubledLetter(this char doubledLetter, out char replacer)
    {
        if (!DoubleLettersReplacers.TryGetValue(char.ToLowerInvariant(doubledLetter), out replacer))
        {
            return false;
        }

        if (char.IsUpper(doubledLetter))
        {
            replacer = char.ToUpperInvariant(replacer);
        }

        return true;
    }
    
    #endregion
    
    ////////////////////////////////////////////////////////////////////////////////////////////////////
}