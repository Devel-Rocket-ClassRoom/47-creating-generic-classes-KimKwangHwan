using System;
using System.Collections.Generic;
using System.Text;

public class Converter<TInput, TOutput>
{
    private Func<TInput, TOutput> convertFunc;
    public Converter(Func<TInput, TOutput> converter)
    {
        convertFunc = converter;
    }
    public TOutput Convert(TInput input)
    {
        return convertFunc(input); 
    }
    public TOutput[] ConvertAll(TInput[] inputs)
    {
        TOutput[] outputs = new TOutput[inputs.Length];
        for (int i = 0; i < inputs.Length; i++)
        {
            outputs[i] = Convert(inputs[i]);
        }
        return outputs;
    }
}