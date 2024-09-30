./.vscode/LoadALLanguage.ps1;

dotnet build BusinessCentral.LinterCop/BusinessCentral.LinterCop.csproj /p:FeatureFlags=\#ManifestHelper

mkdir ../AlDebugProject
mkdir ../AlDebugProject/.vscode

$AppJson = @"
{
  "id": "d700542d-5688-4e64-aecb-648fa385a652",
  "name": "ALProject1",
  "publisher": "Default Publisher",
  "version": "1.0.0.0"
}
"@

$AppJson | Out-File -FilePath ../AlDebugProject/app.json

$TestCodeunit = @"
codeunit 1 MyCodeunit
{
    trigger OnRun()
    begin

    end;
}
"@

$TestCodeunit | Out-File -FilePath ../AlDebugProject/test.al

$Settings = @"
{
    "al.codeAnalyzers": [
        "/workspaces/BusinessCentral.LinterCop/BusinessCentral.LinterCop/bin/Debug/netstandard2.1/BusinessCentral.LinterCop.dll"
    ],
    "al.enableCodeAnalysis": true
}
"@

$Settings | Out-File -FilePath ../AlDebugProject/.vscode/settings.json

code ../AlDebugProject/