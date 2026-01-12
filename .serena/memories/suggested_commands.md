# Suggested Commands for Uma Musume Automation Project

## Prerequisites Setup
- Install .NET 8.0 SDK: sudo apt install dotnet-sdk-8.0
- Install ADB: sudo apt install android-tools-adb
- Ensure Android device/emulator is connected and USB debugging enabled

## Build Commands
- Restore packages: dotnet restore
- Build solution: dotnet build
- Build release: dotnet build -c Release
- Clean build: dotnet clean

## Run Commands
- Run CLI application: dotnet run --project UmamusumeCLI
- Run with specific config: dotnet run --project UmamusumeCLI -- --config path/to/config.json
- Run built executable: ./UmamusumeCLI/bin/Debug/net8.0/UmamusumeCLI

## Development Commands
- Add package to Core: dotnet add UmamusumeCore package PackageName
- Add package to CLI: dotnet add UmamusumeCLI package PackageName
- List packages: dotnet list package
- Update packages: dotnet restore

## ADB Commands (Device Management)
- List devices: adb devices
- Connect to device: adb connect 127.0.0.1:16416
- Take screenshot: adb shell screencap -p /sdcard/screenshot.png
- Pull screenshot: adb pull /sdcard/screenshot.png
- Send tap command: adb shell input tap x y

## Testing Commands
- Run tests: dotnet test (when test projects are added)
- Test with coverage: dotnet test --collect:"XPlat Code Coverage"

## Utility Commands (Linux)
- Find process: ps aux | grep UmamusumeCLI
- Kill process: pkill -f UmamusumeCLI
- Check logs: tail -f /var/log/syslog | grep UmamusumeCLI
- Monitor resources: htop
- File operations: ls -la, cd, cp, mv, rm
- Text search: grep -r "text" .
- Find files: find . -name "*.cs"

## Git Commands
- Clone: git clone repository-url
- Status: git status
- Add changes: git add .
- Commit: git commit -m "message"
- Push: git push origin main
- Pull: git pull origin main