# Execute the given command using iex and echo what is executed
function Echo-Iex {
  param(
    [String] $command
  )
  
  write-host $command -ForegroundColor Green
  iex $command
}

# Execute the given command using cmd /c and echo what is executed
function Echo-CmdC {
  param(
    [String] $command
  )
  
  write-host $command -ForegroundColor Green
  cmd /c $command
}