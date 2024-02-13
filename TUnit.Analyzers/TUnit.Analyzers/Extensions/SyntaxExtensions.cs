﻿using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace TUnit.Analyzers.Shared.Extensions;

public static class SyntaxExtensions
{
    public static IEnumerable<TOutput> GetAllAncestorSyntaxesOfType<TOutput>(this SyntaxNode input) 
        where TOutput : SyntaxNode
    {
        var parent = input.Parent;
        
        while (parent != null)
        {
            if (parent is TOutput output)
            {
                yield return output;
            }
            
            parent = parent.Parent;
        }
    }
    
    public static TOutput? GetAncestorSyntaxOfType<TOutput>(this SyntaxNode input) 
        where TOutput : SyntaxNode
    {
        var parent = input.Parent;
        
        while (parent != null && parent is not TOutput)
        {
            parent = parent.Parent;
        }

        return parent as TOutput;
    }
}