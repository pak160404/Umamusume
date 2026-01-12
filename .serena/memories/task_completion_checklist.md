# Task Completion Checklist

## When a Development Task is Completed

### Code Quality Checks
- Build the solution: dotnet build
- Fix any compilation errors or warnings
- Ensure no breaking changes to existing interfaces
- Verify dependency injection registrations are correct

### Testing and Validation
- Test the application manually: dotnet run --project UmamusumeCLI
- Verify ADB connectivity with target device
- Test OCR functionality with sample screenshots
- Validate configuration loading from config.json
- Check that all automation features work as expected

### Code Review Checklist
- Follow established naming conventions
- Use proper error handling and logging
- Implement interfaces for new services
- Add appropriate JsonPropertyName attributes for config models
- Ensure nullable reference types are handled correctly

### Configuration and Assets
- Update config.json if new parameters are added
- Add any new button template images to assets/buttons/
- Verify asset paths are correct in configuration
- Test with different device resolutions if UI changes made

### Documentation Updates
- Update README.md if functionality changes
- Document any new configuration options
- Add comments for complex automation logic
- Update API documentation for new interfaces

### Final Steps
- Clean and rebuild: dotnet clean && dotnet build
- Test the release build: dotnet build -c Release
- Verify the executable runs correctly
- Commit changes with descriptive commit message
- Consider creating a backup of working configuration

### Deployment Considerations
- Ensure Linux-specific dependencies are properly included
- Test on target Linux environment (Ubuntu 24.04)
- Verify ADB permissions and device connectivity
- Check that all native libraries load correctly