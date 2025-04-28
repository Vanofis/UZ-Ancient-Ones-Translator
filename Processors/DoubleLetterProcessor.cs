using System;
using System.Text;

namespace AncientOnesTranslator.Processors;

internal record DoubleLetterProcessor : IStringProcessor
{
    public string Process(string input)
    {
        var builder = new StringBuilder();
        
        for (int i = 0; i < input.Length;)
        {
            if (i + 1 < input.Length && input[i].CompareCharsCaseInsensitive(input[i + 1]))
            {
                if (input[i].TryGetDoubledLetter(out char replacer))
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
};