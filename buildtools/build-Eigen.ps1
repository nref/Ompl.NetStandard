param (
    [string]$sourceDir
)
 
. $PsScriptRoot/Configure-Build.ps1

$configuration = "Release"
$buildDir="$sourceDir/build"
$solution = "Eigen3.sln"

$cmakeOptions = ""

. $PsScriptRoot/Generate-And-Build.ps1
Generate-And-Build $buildDir $cmakeOptions $configuration $solution $False
