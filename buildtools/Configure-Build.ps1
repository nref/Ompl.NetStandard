param (
    [bool]$parallelCompile = $True
)

# Update these lines for other versions of Visual Studio
#$vc = "C:/Program Files/Microsoft Visual Studio/2022/Enterprise/VC/Auxiliary/Build"
$vc = "C:/Program Files/Microsoft Visual Studio/2022/Community/VC/Auxiliary/Build"
$cmakeGenerator = "Visual Studio 17 2022"

# Optionally replace these with absolute paths
$cmake = "cmake"
$msbuild = "msbuild"

$repoRoot = Resolve-Path -path "$PsScriptRoot/.."

# Replace backslashes with forward slashes
# CMake hates backslashes. If you see an error like below then you have not used
# FORWARD slashes on parameters passed to CMake.
# 
#    > Syntax error in cmake code at
#    > 
#    >   C:/idcas/ITK-4.5.2-vs2019-x64/lib/cmake/ITK-4.5/Modules/ITKDCMTK.cmake:17
#    > 
#    > when parsing string
#    > 
#    >   C:\idcas\DCMTK-3.6.0-vs2019-x64
#    >
#    > Invalid character escape '\i'.
$repoRoot = $repoRoot -replace '\\', '/'

Write-Host "Build configuration:" -ForegroundColor Yellow
Write-Host
Write-Host "Visual Studio path: $vc" -ForegroundColor Green
Write-Host "CMake generator: $cmakeGenerator" -ForegroundColor Green
Write-Host "Path to CMake: $cmake" -ForegroundColor Green
Write-Host "Path to MSBuild: $msbuild" -ForegroundColor Green
Write-Host "Repo root: $repoRoot" -ForegroundColor Green

# Use this line for 32-bit builds
#Initialize-VS $vc "x86"
.$PsScriptRoot/Initialize-VS $vc "amd64"

# For compilation-unit level parallelism, the /MP must be added 
# to CMAKE_CXX_CFLAGS and CMAKE_C_FLAGS. 
# See https://blog.kitware.com/cmake-building-with-all-your-cores.
#
# These can be set programmatically with the CFLAGS and CXXFLAGS environment variables.
# https://cmake.org/cmake/help/latest/envvar/CFLAGS.html
# https://cmake.org/cmake/help/latest/envvar/CXXFLAGS.html
if ($parallelCompile -eq $True) {
    $env:CXXFLAGS="/MP"
    $env:CFLAGS="/MP"
    Write-Host "CMake compilation-unit level parallelism (/MP flag) is enabled" -ForegroundColor Yellow
}
