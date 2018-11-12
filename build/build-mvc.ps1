# VARIABLES
$appPoolName = "EM"
$buildFolder = (Get-Item -Path "./" -Verbose).FullName
$slnFolder = Join-Path $buildFolder "../"
$outputFolder = Join-Path $buildFolder "outputs"
$webMvcFolder = Join-Path $slnFolder "src/EM.Web.Mvc"

## IIS STOP
Stop-WebAppPool -Name $appPoolName

## CLEAR
Remove-Item $outputFolder -Force -Recurse -ErrorAction Ignore
New-Item -Path $outputFolder -ItemType Directory

## RESTORE NUGET PACKAGES
Set-Location $slnFolder
dotnet restore

## PUBLISH WEB MVC PROJECT
Set-Location $webMvcFolder
dotnet publish -c Debug --output (Join-Path $outputFolder "Mvc")
#dotnet publish -c Release -r win10-x64 --self-contained --output (Join-Path $outputFolder "Mvc")

## CREATE DOCKER IMAGES

# Mvc
#Set-Location (Join-Path $outputFolder "Mvc")

#docker rmi abp/mvc -f
#docker build -t abp/mvc .

## DOCKER COMPOSE FILES
#Copy-Item (Join-Path $slnFolder "docker/mvc/*.*") $outputFolder

## FINALIZE
Start-WebAppPool -Name $appPoolName
Set-Location $buildFolder