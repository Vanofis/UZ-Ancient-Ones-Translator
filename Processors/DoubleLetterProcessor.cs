using System;
using System.Text;
using System.Collections.Generic;

namespace AncientOnesTranslator.Processors;

internal record DoubleLetterProcessor : IStringProcessor
{
    private readonly Dictionary<char, char> _doubleLettersReplacers = new()
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
        { 'j', 'й' },
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
        { 'z', 'ζ' },
    };
    
    public void Process(ref string[] inputs)
    {
        for (int i = 0; i < inputs.Length; i++)
        {
            var builder = new StringBuilder();
            var input = inputs[i];
            
            for (int j = 0; j < input.Length;)
            {
                if (j + 1 < input.Length && CompareCharactersCaseless(input[j], input[j + 1]))
                {
                    if (TryGetReplacer(input[j], out char newLetter))
                    {
                        builder.Append(newLetter);
                        j += 2;
                        
                        continue;
                    }

                    Console.WriteLine("Warning! Unsupported dobule character detected! Skipping.");
                }

                builder.Append(input[j]);
                j++;
            }

            inputs[i] = builder.ToString();
        }
    }

    private bool TryGetReplacer(char character, out char replacer)
    {
        if (!_doubleLettersReplacers.TryGetValue(char.ToLower(character), out replacer))
        {
            return false;
        }

        if (char.IsUpper(character))
        {
            replacer = char.ToUpperInvariant(replacer);
        }
        
        return true;
    }

    private bool CompareCharactersCaseless(char character1, char character2)
    {
        return char.ToUpperInvariant(character1) == char.ToUpperInvariant(character2);
    }
};