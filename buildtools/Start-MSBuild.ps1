. $PsScriptRoot/Exec-Utils.ps1

# Invoke MSBuild on the given solution with the given configuration
# Assumes MSBuild is in the path.
function Start-MSBuild{
  param(
    [String] $configuration,
    [String] $solution,
    [bool] $parallelTargets = $True
  )
  echo "booger"

  # /m flag means build targets with all processors. 
  # Note that this only provides target level parallelism. 
  # For compilation-unit parallelism, the /MP flag must be used at CMake generation time.
  $mFlag = ""
  if ($parallelTargets) {
    $mFlag = "/m"
    Write-Host "MSBuild target level parallelism (/m flag) is enabled" -ForegroundColor Yellow
  }

  Echo-Iex "$msbuild $mFlag /p:Configuration=$configuration `"$solution`""
}
