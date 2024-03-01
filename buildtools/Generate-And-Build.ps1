. $PsScriptRoot/Exec-Utils.ps1

function Generate-And-Build {
  param(
    [String] $buildDir,
    [String] $cmakeOptions,
    [String] $configuration,
    [String] $solution,
    [bool]$build = $True,
    [bool]$parallelTargets = $True
  )

  if (!(Test-Path -Path "$buildDir")){
      Echo-Iex "mkdir `"$buildDir`""
  }

  pushd $buildDir

  Echo-Iex "$cmake -G `"$cmakeGenerator`" $cmakeOptions -S .."

  if ($build) {
    . $PsScriptRoot/Start-MSBuild.ps1
    Start-MSBuild $configuration $solution $parallelTargets
  }

  # Clean up
  popd
}
