# Project Description

## Umamusume Game Automation Platform

**Software Developer & Automation Engineer**  
**Technologies:** .NET 8.0 (C#), Android Debug Bridge (ADB), OpenCV, PaddleOCR, Dependency Injection

**Development Period:** 2024 – 2025

### Key Achievements

• Architected and implemented a robust automation framework using .NET 8.0 with Clean Architecture principles, featuring service-layer patterns, dependency injection, and interface-based abstractions for maintainability and testability.

• Integrated advanced computer vision capabilities using OpenCV (OpenCvSharp4) and PaddleOCR for real-time image processing, text recognition, and automated UI interaction, achieving reliable OCR-based navigation and decision-making.

• Developed comprehensive Android device integration using AdvancedSharpAdbClient, enabling seamless ADB connectivity, remote device control, screen capture, and automated tap/gesture interactions for game automation workflows.

### Technical Highlights

- **Clean Architecture Implementation**: Separated concerns into Core library (services, interfaces, models) and CLI application with hosted background services
- **Advanced OCR Integration**: Leveraged PaddleOCR with online model downloading for multi-language text detection and recognition
- **Configuration-Driven Automation**: JSON-based configuration system for device addresses, automation timing, filter settings, and coordinate mappings
- **Logging & Monitoring**: Integrated Microsoft.Extensions.Logging for comprehensive console-based logging and error tracking
- **Cross-Platform Support**: Built with Linux runtime support (Ubuntu 24.04 x64) for deployment flexibility
- **Modular Design**: Interface-based service architecture (IAutomation, IADBConnect, IImageProcessor, IValidator) enabling easy testing and extension

### Core Components

1. **UmamusumeCore Library**
   - Automation service with OCR-based text finding and clicking
   - ADB connection management with device pairing and connectivity validation
   - Image processing pipeline (capture → process → OCR → action)
   - Configuration validation and error handling

2. **UmamusumeCLI Application**
   - Console host with dependency injection container
   - Background runner service for orchestration
   - Configuration file management
   - Lifecycle management using Generic Host pattern

### Technologies & Tools

- **Framework**: ASP.NET Core 8.0, C# with nullable reference types
- **Computer Vision**: OpenCV (OpenCvSharp4 v4.11.0) for image manipulation
- **OCR**: PaddleOCR (Sdcb.PaddleOCR v3.0.1) with PaddleInference runtime
- **Android Integration**: AdvancedSharpAdbClient v3.4.14 for ADB communication
- **Architecture**: Microsoft.Extensions.* (DI, Hosting, Logging, Configuration)
- **Build System**: MSBuild with .NET SDK, Visual Studio solution structure
- **Version Control**: Git with comprehensive .gitignore for .NET projects
- **Development Environment**: JetBrains Rider / Visual Studio support
