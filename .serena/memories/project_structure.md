# Project Structure and Architecture

## Solution Structure

Umamusume/
- Umamusume.sln - Visual Studio solution file
- UmamusumeCore/ - Core library project
  - Interfaces/ - Service interfaces
    - IADBConnect.cs - ADB connection interface
    - IConfigLoader.cs - Configuration loader interface  
    - IPaddleOCR.cs - OCR service interface
  - Services/ - Service implementations
    - ADBConnect.cs - ADB connection service
    - ConfigLoader.cs - JSON configuration loader
    - PaddleOCR.cs - OCR processing service
  - Models/ - Data models and configuration
    - AutomationConfig.cs - Configuration model classes
  - assets/ - Static resources
    - buttons/ - UI button templates (PNG files)
  - config.json - Application configuration
- UmamusumeCLI/ - Console application project
  - Program.cs - Application entry point
- .idea/ - JetBrains Rider IDE settings

## Architecture Patterns

### Dependency Injection
- Uses Microsoft.Extensions.DependencyInjection
- Interface-based design for testability
- Service registration in Program.cs
- Constructor injection throughout

### Clean Architecture
- Core Library (UmamusumeCore): Business logic and services
- CLI Application (UmamusumeCLI): User interface and entry point
- Interfaces: Abstract contracts for services
- Models: Data transfer objects and configuration

### Configuration Management
- JSON-based configuration (config.json)
- Strongly-typed configuration classes
- Environment-specific settings support
- Centralized configuration loading

### Asset Management
- Button templates stored as PNG files
- Organized in assets/buttons/ directory
- Template matching for UI automation
- Configurable asset paths