﻿using Microsoft.CodeAnalysis;

namespace TUnit.Analyzers;

internal static class Rules
{
    private const string UsageCategory = "Usage";
    
    public static readonly DiagnosticDescriptor InvalidDataAssertion =
        CreateDescriptor("TUnit0001", UsageCategory, DiagnosticSeverity.Error);

    public static readonly DiagnosticDescriptor NoDataProvidedAssertion =
        CreateDescriptor("TUnit0002", UsageCategory, DiagnosticSeverity.Error);

    public static readonly DiagnosticDescriptor InvalidDataSourceAssertion =
        CreateDescriptor("TUnit0003", UsageCategory, DiagnosticSeverity.Error);

    public static readonly DiagnosticDescriptor NoDataSourceMethodFoundAssertion =
        CreateDescriptor("TUnit0004", UsageCategory, DiagnosticSeverity.Error);
    
    public static readonly DiagnosticDescriptor BadNullabilityAssertion =
        CreateDescriptor("TUnit0005", UsageCategory, DiagnosticSeverity.Warning);

    private static DiagnosticDescriptor CreateDescriptor(string diagnosticId, string category, DiagnosticSeverity severity)
    {
        return new DiagnosticDescriptor(
            id: diagnosticId,
            title: new LocalizableResourceString(diagnosticId + "Title",
                Resources.ResourceManager, typeof(Resources)),
            messageFormat: new LocalizableResourceString(diagnosticId + "MessageFormat", Resources.ResourceManager,
                typeof(Resources)),
            category: category,
            defaultSeverity: severity,
            isEnabledByDefault: true,
            description: new LocalizableResourceString(diagnosticId + "Description", Resources.ResourceManager,
                typeof(Resources))
        );
    }
}