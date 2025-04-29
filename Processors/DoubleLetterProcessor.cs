using System;
using System.Collections.Generic;
using System.Text;

namespace AncientOnesTranslator.Processors;

internal record DoubleLetterProcessor : IStringProcessor
{
    private Dictionary<char, char> _doubleLettersReplacers = new()
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
    
    public string Process(string input)
    {
        var builder = new StringBuilder();
        
        for (int i = 0; i < input.Length;)
        {
            if (i + 1 < input.Length && input[i].CompareCharsCaseInsensitive(input[i + 1]))
            {
                if (TryGetDoubledLetter(input[i], out char replacer))
                {
                    builder.Append(replacer);
                    i += 2;
                    
                    continue;
                }

                Console.WriteLine("Warning! Unsupported dobule character detected! Skipping.");
            }

            builder.Append(input[i]);
            i++;
        }
            
        return builder.ToString();;
    }
    
    private bool TryGetDoubledLetter(char doubledLetter, out char replacer)
    {
        if (!_doubleLettersReplacers.TryGetValue(char.ToLowerInvariant(doubledLetter), out replacer))
        {
            return false;
        }

        if (char.IsUpper(doubledLetter))
        {
            replacer = char.ToUpperInvariant(replacer);
        }

        return true;
    }
};