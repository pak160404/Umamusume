# Umamusume Game Automation Platform

A sophisticated .NET 8.0 automation framework for the Umamusume mobile game, leveraging computer vision, OCR technology, and Android Debug Bridge for intelligent game interaction.

## 🎯 Project Overview

This automation platform combines advanced image processing, optical character recognition, and Android device control to create an intelligent automation solution. Built with Clean Architecture principles, the project demonstrates enterprise-level software design patterns and modern .NET development practices.

## 🚀 Key Features

- **Intelligent OCR-Based Navigation**: Uses PaddleOCR for text detection and recognition to navigate game interfaces
- **Real-Time Image Processing**: OpenCV integration for screen capture analysis and template matching
- **Android Device Control**: Seamless ADB integration for remote device interaction
- **Configuration-Driven Automation**: JSON-based configuration for flexible automation workflows
- **Clean Architecture**: Separation of concerns with service layers, interfaces, and dependency injection
- **Comprehensive Logging**: Built-in logging system for monitoring and debugging

## 🛠️ Technologies

### Core Framework
- **.NET 8.0** (C#) with implicit usings and nullable reference types
- **ASP.NET Core** architecture patterns

### Key Libraries
- **OpenCvSharp4** (4.11.0) - Computer vision and image processing
- **PaddleOCR** (3.0.1) - Optical character recognition
- **AdvancedSharpAdbClient** (3.4.14) - Android Debug Bridge integration
- **Microsoft.Extensions.*** - DI, Hosting, Logging, Configuration

### Development Tools
- Visual Studio / JetBrains Rider
- .NET SDK 10.0+
- MSBuild
- Git

## 📁 Project Structure

```
Umamusume/
├── UmamusumeCore/              # Core library
│   ├── Services/               # Business logic services
│   │   ├── Automation.cs       # Main automation logic
│   │   ├── ADBConnect.cs       # ADB connection management
│   │   ├── ImageProcessor.cs  # OCR and image processing
│   │   └── Validator.cs        # Configuration validation
│   ├── Interfaces/             # Service abstractions
│   ├── Models/                 # Data models
│   ├── assets/                 # Templates and resources
│   └── platform-tools/         # Android platform tools
├── UmamusumeCLI/              # Console application
│   ├── Program.cs             # Application entry point
│   ├── Runner.cs              # Background service orchestrator
│   └── config.json            # Configuration file
└── Umamusume.sln              # Visual Studio solution
```

## ⚙️ Configuration

The `config.json` file controls automation behavior:

```json
{
  "adb": {
    "device_address": "127.0.0.1:16416",
    "screenshot_path": "./screenshots",
    "template_path": "./assets/templates"
  },
  "automation": {
    "wait_time": {
      "career": 5,
      "next": 0.5,
      "start_career": 1,
      "skip": 1,
      "confirm": 5,
      "loop": 5
    },
    "attempts": {
      "next": 10,
      "next_check": 5
    },
    "manual_choose": true,
    "filter": {
      "rarity": "SSR",
      "speciality": "Speed"
    },
    "coordinates": {
      "tap_after_skip": [249, 948]
    }
  }
}
```

## 🏗️ Architecture

### Design Patterns
- **Dependency Injection**: Loose coupling and testability
- **Service Layer Pattern**: Business logic encapsulation
- **Repository Pattern**: Data access abstraction
- **Hosted Services**: Background task execution
- **Interface Segregation**: Single responsibility per interface

### Service Overview

#### Automation Service
Orchestrates the automation workflow by finding text elements via OCR and executing appropriate actions.

#### ADB Connect Service
Manages Android device connectivity, including server startup, device pairing, and connection validation.

#### Image Processor Service
Handles screen capture from Android devices, image processing with OpenCV, and text recognition using PaddleOCR.

#### Validator Service
Validates configuration settings and ensures proper setup before automation execution.

## 🔧 Building the Project

### Prerequisites
- .NET 8.0 SDK or later
- Android device or emulator
- ADB platform tools (included)

### Build Commands

```bash
# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Run the CLI application
dotnet run --project UmamusumeCLI
```

## 📝 Development

### Adding New Features

1. Define interface in `UmamusumeCore/Interfaces/`
2. Implement service in `UmamusumeCore/Services/`
3. Register in DI container in `Program.cs`
4. Use service via constructor injection

### Example Service Registration

```csharp
services.AddSingleton<IMyService, MyService>();
```

## 🤝 Contributing

This is a personal project demonstrating:
- Clean Architecture implementation in .NET
- Advanced computer vision integration
- OCR-based automation techniques
- Android device automation via ADB
- Modern C# and .NET best practices

## 📄 License

This project is for educational and portfolio purposes.

## 👤 Author

**pak160404**

Demonstrating expertise in:
- .NET Core development
- Computer vision and OCR integration
- Android automation
- Clean Architecture and design patterns
- Dependency injection and SOLID principles

---

*For more technical details, see [TECHNOLOGIES.md](TECHNOLOGIES.md) and [PROJECT_DESCRIPTION.md](PROJECT_DESCRIPTION.md)*
