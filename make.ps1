# Install scoop if it does not exist
$haveScoop = Get-Command scoop -ErrorAction SilentlyContinue

if (-not $haveScoop) {
  echo "Installing scoop..."
  iwr -useb get.scoop.sh | iex
}

# Install the given scoop package only if the given executable does not exist
function Install-WithScoop {
    param (
        [string]$ExecutableName,
        [string]$PackageName
    )
    
    # Check if the exe exists
    $exeExists = Get-Command $ExecutableName -ErrorAction SilentlyContinue

    # Install the package using Scoop if the executable does not exist
    if (-not $exeExists) {
        echo "Installing $PackageName..."
        scoop install $PackageName
    }
}

# Install build tools
Install-WithScoop -ExecuTableName "git.exe" -PackageName "git"
Install-WithScoop -ExecuTableName "wget.exe" -PackageName "wget"
Install-WithScoop -ExecuTableName "cmake.exe" -PackageName "cmake"
Install-WithScoop -ExecuTableName "nuget.exe" -PackageName "nuget"

# Download and extract Boost
$boostExe = "boost_1_72_0-msvc-14.2-64.exe"
$boostDir = "C:\lib\boost_1_72_0"

if (-not (Test-Path $boostDir)) {

    if (-not (Test-Path $boostExe)) {
      echo "Downloading boost..."
      wget https://boost.teeks99.com/bin/1.72.0/$boostExe
    }
    echo "Extracting boost..."
    Start-Process -wait $boostExe -ArgumentList "/SILENT", "/DIR=$boostDir"
    rm $boostExe
}

# Download submodules e.g. Eigen, OMPL
git submodule init
git submodule update

# Build dependencies
./buildtools/Configure-Build.ps1
./buildtools/build-Eigen.ps1 ./eigen
./buildtools/build-OMPL.ps1 ./ompl

# Build solutions
Invoke-MSBuild Release ompl_wrap.sln $True
dotnet build --configuration=Release Ompl.NetStandard.sln

# Generate NuGet Package
pushd Ompl.NetStandard/nuget
./nuget-pack.ps1
popd

