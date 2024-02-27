param (
    [string]$sourceDir
)
 
. $PsScriptRoot/Configure-Build.ps1

$configuration = "Release"
$buildDir="$sourceDir/build-vs143-x64"
$solution = "ompl.sln"

$cmakeOptions  = "-DBoost_INCLUDE_DIR=C:/lib/boost_1_72_0 "
$cmakeOptions += "-DEigen3_DIR=../eigen/build "

. $PsScriptRoot/Generate-And-Build.ps1
Generate-And-Build $buildDir $cmakeOptions $configuration $solution $True $True
