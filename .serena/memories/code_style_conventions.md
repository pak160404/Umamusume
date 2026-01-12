# Code Style and Conventions

## C# Language Features
- Target Framework: .NET 8.0
- Implicit Usings: Enabled
- Nullable Reference Types: Enabled
- File-scoped namespaces preferred
- Top-level statements in Program.cs

## Naming Conventions
- Classes: PascalCase (e.g., AutomationConfig, ConfigLoader)
- Interfaces: PascalCase with "I" prefix (e.g., IADBConnect, IPaddleOCR)
- Properties: PascalCase (e.g., DeviceAddress, ScreenshotPath)
- Methods: PascalCase (e.g., LoadAutomationConfig, ImageOCR)
- Fields: camelCase with underscore prefix for private fields
- Constants: PascalCase
- Local variables: camelCase

## Project Organization
- Interfaces in dedicated Interfaces/ folder
- Service implementations in Services/ folder
- Data models in Models/ folder
- One class per file
- File names match class names

## Dependency Injection Pattern
- Constructor injection preferred
- Interface-based services
- Registration in Program.cs using ServiceCollection
- Logger injection for all services

## Configuration Pattern
- JSON configuration files (config.json)
- Strongly-typed configuration classes
- JsonPropertyName attributes for JSON mapping
- Nested configuration objects for organization

## Error Handling
- Try-catch blocks in main entry points
- Graceful degradation with user-friendly error messages
- Console output for error reporting
- Environment.Exit(1) for fatal errors

## Logging
- Microsoft.Extensions.Logging framework
- Console logging provider
- Structured logging with meaningful messages
- Logger injection via constructor