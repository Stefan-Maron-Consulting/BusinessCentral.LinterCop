﻿using Microsoft.Dynamics.Nav.CodeAnalysis.Diagnostics;
using System;

namespace BusinessCentral.LinterCop
{
    public static class DiagnosticDescriptors
    {
        public static readonly DiagnosticDescriptor Rule0000ErrorInRule = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0000", (LocalizableString)new LocalizableResourceString("Rule0000ErrorInRuleTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0000ErrorInRuleFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0000ErrorInRuleDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0000", Array.Empty<string>());

        public static readonly DiagnosticDescriptor Rule0001FlowFieldsShouldNotBeEditable = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0001", (LocalizableString)new LocalizableResourceString("Rule0001FlowFieldsShouldNotBeEditable", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0001FlowFieldsShouldNotBeEditableFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0001FlowFieldsShouldNotBeEditableDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0001", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0002CommitMustBeExplainedByComment = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0002", (LocalizableString)new LocalizableResourceString("Rule0002CommitMustBeExplainedByComment", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0002CommitMustBeExplainedByCommentFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0002CommitMustBeExplainedByCommentDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0002", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0003DoNotUseObjectIDsInVariablesOrProperties = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0003", (LocalizableString)new LocalizableResourceString("Rule0003DoNotUseObjectIDsInVariablesOrProperties", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0003DoNotUseObjectIDsInVariablesOrPropertiesFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0003DoNotUseObjectIDsInVariablesOrPropertiesDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0003", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0004LookupPageIdAndDrillDownPageId = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0004", (LocalizableString)new LocalizableResourceString("Rule0004LookupPageIdAndDrillDownPageIdTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0004LookupPageIdAndDrillDownPageIdFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0004LookupPageIdAndDrillDownPageIdDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0004", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0005VariableCasingShouldNotDIfferFromDeclaration = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0005", (LocalizableString)new LocalizableResourceString("Rule0005VariableCasingShouldNotDIfferFromDeclarationTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0005VariableCasingShouldNotDIfferFromDeclarationFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0005VariableCasingShouldNotDIfferFromDeclarationDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0005", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0006FieldNotAutoIncrementInTemporaryTable = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0006", (LocalizableString)new LocalizableResourceString("Rule0006FieldNotAutoIncrementInTemporaryTableTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0006FieldNotAutoIncrementInTemporaryTableFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Error, true, (LocalizableString)new LocalizableResourceString("Rule0006FieldNotAutoIncrementInTemporaryTableDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0006", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0007DataPerCompanyShouldAlwaysBeSet = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0007", (LocalizableString)new LocalizableResourceString("Rule0007DataPerCompanyShouldAlwaysBeSetTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0007DataPerCompanyShouldAlwaysBeSetFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Hidden, false, (LocalizableString)new LocalizableResourceString("Rule0007DataPerCompanyShouldAlwaysBeSetDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0007", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0008NoFilterOperatorsInSetRange = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0008", (LocalizableString)new LocalizableResourceString("Rule0008NoFilterOperatorsInSetRangeTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0008NoFilterOperatorsInSetRangeFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0008NoFilterOperatorsInSetRangeDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0008", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0009CodeMetricsInfo = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0009", (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, false, (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0009", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0010CodeMetricsWarning = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0010", (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0010", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0011AccessPropertyShouldAlwaysBeSet = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0011", (LocalizableString)new LocalizableResourceString("Rule0011AccessPropertyShouldAlwaysBeSetTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0011AccessPropertyShouldAlwaysBeSetFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Hidden, false, (LocalizableString)new LocalizableResourceString("Rule0011AccessPropertyShouldAlwaysBeSetDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0011", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0012DoNotUseObjectIdInSystemFunctions = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0012", (LocalizableString)new LocalizableResourceString("Rule0012DoNotUseObjectIdInSystemFunctionsTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0012DoNotUseObjectIdInSystemFunctionsFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0012DoNotUseObjectIdInSystemFunctionsDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0012", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0013CheckForNotBlankOnSingleFieldPrimaryKeys = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0013", (LocalizableString)new LocalizableResourceString("Rule0013CheckForNotBlankOnSingleFieldPrimaryKeysTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0013CheckForNotBlankOnSingleFieldPrimaryKeysFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0013CheckForNotBlankOnSingleFieldPrimaryKeysDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0013", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0014PermissionSetCaptionLength = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0014", (LocalizableString)new LocalizableResourceString("Rule0014PermissionSetCaptionLengthTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0014PermissionSetCaptionLengthFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0014PermissionSetCaptionLengthDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0014", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0015PermissionSetCoverage = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0015", (LocalizableString)new LocalizableResourceString("Rule0015PermissionSetCoverageTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0015PermissionSetCoverageFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0015PermissionSetCoverageDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0015", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0016CheckForMissingCaptions = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0016", (LocalizableString)new LocalizableResourceString("Rule0016CheckForMissingCaptionsTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0016CheckForMissingCaptionsFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0016CheckForMissingCaptionsDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0016", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0017WriteToFlowField = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0017", (LocalizableString)new LocalizableResourceString("Rule0017WriteToFlowFieldTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0017WriteToFlowFieldFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0017WriteToFlowFieldDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0017", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0018NoEventsInInternalCodeunitsAnalyzerDescriptor = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0018", (LocalizableString)new LocalizableResourceString("Rule0018NoEventsInInternalCodeunitsTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0018NoEventsInInternalCodeunitsFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0018NoEventsInInternalCodeunitsDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0018", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0019DataClassificationFieldEqualsTable = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0019", (LocalizableString)new LocalizableResourceString("Rule0019DataClassificationFieldEqualsTableTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0019DataClassificationFieldEqualsTableFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0019DataClassificationFieldEqualsTableDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0019", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0020ApplicationAreaEqualsToPage = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0020", (LocalizableString)new LocalizableResourceString("Rule0020ApplicationAreaEqualsToPageTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0020ApplicationAreaEqualsToPageFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0020ApplicationAreaEqualsToPageDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0020", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0021ConfirmImplementConfirmManagement = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0021", (LocalizableString)new LocalizableResourceString("Rule0021ConfirmImplementConfirmManagement", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0021ConfirmImplementConfirmManagement", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0021ConfirmImplementConfirmManagement", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0021", Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0022GlobalLanguageImplementTranslationHelper = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0022", (LocalizableString)new LocalizableResourceString("Rule0022GlobalLanguageImplementTranslationHelperTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0022GlobalLanguageImplementTranslationHelperFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0022GlobalLanguageImplementTranslationHelperDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0022", Array.Empty<string>());
    }
}
