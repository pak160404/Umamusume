# Technologies Used in Umamusume Project

## Overview
This is a .NET-based automation tool for the Umamusume mobile game that uses Android Debug Bridge (ADB) for device control, OCR (Optical Character Recognition) for text recognition, and computer vision for image processing.

## Core Technologies

### Programming Language & Framework
- **C# (.NET 8.0)** - Primary programming language
  - Target Framework: `net8.0`
  - Features enabled: Implicit usings, Nullable reference types

### Platform & Runtime
- **.NET SDK** - Cross-platform development framework
- **Linux Runtime** - Specifically Ubuntu 24.04 x64 support

## Major Libraries & Dependencies

### Android Integration
- **AdvancedSharpAdbClient** (v3.4.14)
  - Provides programmatic access to Android Debug Bridge (ADB)
  - Enables device connection, control, and interaction
  - Used for clicking, back button navigation, and device management

### Computer Vision & Image Processing
- **OpenCvSharp4** (v4.11.0.20250507)
  - .NET wrapper for OpenCV (Open Source Computer Vision Library)
  - Used for image processing and manipulation
  - Includes Ubuntu 24.04 x64 runtime support
- **OpenCvSharp4.Extensions** (v4.11.0.20250507)
  - Additional extensions for OpenCvSharp4

### Optical Character Recognition (OCR)
- **PaddleOCR** - Text detection and recognition
  - **Sdcb.PaddleInference** (v3.0.1) - Core inference engine
  - **Sdcb.PaddleInference.runtime.linux-x64** (v3.1.0.54) - Linux x64 runtime
  - **Sdcb.PaddleOCR** (v3.0.1) - OCR implementation
  - **Sdcb.PaddleOCR.Models.Online** (v3.0.1) - Pre-trained OCR models

### Dependency Injection & Configuration
- **Microsoft.Extensions.DependencyInjection** (v10.0.0-preview.7.25380.108)
  - Provides dependency injection container
- **Microsoft.Extensions.Hosting** (v9.0.8)
  - Generic host for console applications
  - Enables background services and lifecycle management
- **Microsoft.Extensions.Configuration**
  - Configuration system supporting JSON files
  - Used for reading `config.json`

### Logging
- **Microsoft.Extensions.Logging** (v9.0.8)
  - Logging abstraction
- **Microsoft.Extensions.Logging.Console** (v9.0.8)
  - Console logging provider

## Development Tools

### IDE & Editor
- **JetBrains Rider / IntelliJ IDEA**
  - Evidenced by `.idea` directory
- **Visual Studio**
  - Supported via `.sln` (solution) file

### Version Control
- **Git** - Source control management
  - `.gitignore` configured for .NET projects
  - `.gitattributes` for line ending normalization

### Build System
- **MSBuild** - .NET build system
  - Solution file: `Umamusume.sln`
  - Project files: `*.csproj`

### Android Tools
- **Android Platform Tools**
  - ADB (Android Debug Bridge) - Command-line tool for Android device communication
  - FastBoot - Flash/boot device images
  - SQLite3 - Database tool
  - etc1tool - ETC1 compression tool

## Project Structure

### Solution Components
1. **UmamusumeCore** - Core library containing:
   - Services (Automation, ADB connectivity, Image processing, Validation)
   - Interfaces (Abstractions for services)
   - Models (Data models and configuration)
   - Assets (Button templates and resources)

2. **UmamusumeCLI** - Command-line interface application:
   - Console host application
   - Runner service for orchestration
   - Entry point (Program.cs)

### Configuration
- **JSON Configuration** (`config.json`)
  - ADB device connection settings
  - Automation parameters (wait times, attempts, coordinates)
  - Filter settings (rarity, speciality)

## Architecture Patterns

### Design Patterns
- **Dependency Injection** - For loose coupling and testability
- **Service Layer Pattern** - Business logic separated into services
- **Repository Pattern** - Interface-based abstractions
- **Hosted Services** - Background task execution

### Project Type
- Console Application with automated UI interaction
- Game automation tool
- Image recognition and OCR-based automation

## Target Platform
- **Android Devices** - The automation targets Android devices/emulators
- **Linux** - Specific runtime support for Ubuntu 24.04 x64

## Key Features
- Automated game interaction via ADB
- Screen capture and image processing
- OCR-based text detection for UI navigation
- Configurable automation workflows
- Template matching for button recognition
