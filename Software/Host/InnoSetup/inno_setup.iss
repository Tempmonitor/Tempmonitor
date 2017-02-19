#define MyAppName "Temp monitor"
#define MyAppVersion "1.0"
#define MyAppPublisher "Temp monitor UF"
#define MyAppURL "http://tempmonitor.se/"
#define MyAppExeName "Temp monitor.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{029934AF-3366-4E60-8F70-C627824BDC6D}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
OutputDir={#SourcePath}
OutputBaseFilename=Temp_monitor_{#MyAppVersion}_Setup_32-bit
SetupIconFile={#SourcePath}\..\TempmonitorHost\TempmonitorHost\icon.ico
Compression=lzma
SolidCompression=yes
LicenseFile=license.txt

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files]
Source: "{#SourcePath}\..\TempmonitorHost\TempmonitorHost\bin\Release\Temp monitor.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}\..\TempmonitorHost\TempmonitorHost\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "{#SourcePath}\license.txt"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall shellexec skipifsilent

