﻿using Microsoft.Dynamics.Nav.CodeAnalysis.Diagnostics;
using System;

namespace BusinessCentral.LinterCop
{
  public static class DiagnosticDescriptors
    {
        public static readonly DiagnosticDescriptor Rule0001FlowFieldsShouldNotBeEditable = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0001", (LocalizableString)new LocalizableResourceString("Rule0001FlowFieldsShouldNotBeEditable", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0001FlowFieldsShouldNotBeEditableFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0001FlowFieldsShouldNotBeEditableDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (string)null, Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0002CommitMustBeExplainedByComment = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0002", (LocalizableString)new LocalizableResourceString("Rule0002CommitMustBeExplainedByComment", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0002CommitMustBeExplainedByCommentFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0002CommitMustBeExplainedByCommentDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (string)null, Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0003DoNotUseObjectIDsInVariablesOrProperties = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0003", (LocalizableString)new LocalizableResourceString("Rule0003DoNotUseObjectIDsInVariablesOrProperties", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0003DoNotUseObjectIDsInVariablesOrPropertiesFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0003DoNotUseObjectIDsInVariablesOrPropertiesDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (string)null, Array.Empty<string>());
    }
}
