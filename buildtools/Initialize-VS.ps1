# Summary: Set environment variables for Visual Studio Command Prompt
param(
  [String] $vc,
  [String] $arch
)

. $PsScriptRoot/Exec-Utils.ps1

write-host "`nTesting if we need to setup Visual Studio Command Prompt..." -ForegroundColor Yellow

try {
  get-command vstest.console.exe -ErrorAction Stop | Out-Null
  get-command devenv.com -ErrorAction Stop | Out-Null

  write-host "`nVisual Studio Command Prompt is already set up." -ForegroundColor Yellow
}
catch {
    Push-Location "$vc"

    write-host "`nSetting up Visual Studio Command Prompt..." -ForegroundColor Yellow
    Echo-CmdC "vcvarsall.bat $arch & set" |
    
    foreach {
    if ($_ -match "=") {
        $v = $_.split("="); set-item -force -path "ENV:\$($v[0])"  -value "$($v[1])"
        }
    }

    Pop-Location
    write-host "`nVisual Studio Command Prompt has been set up." -ForegroundColor Yellow 
}
