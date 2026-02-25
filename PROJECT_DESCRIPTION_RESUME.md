# Project Description - Resume Format

## Umamusume Game Automation Tool

**Software Developer & Automation Engineer**  
**Technologies:** .NET Core 8, C#, Android Debug Bridge, OpenCV, PaddleOCR  
**Duration:** 01/2025 – Present

### Key Responsibilities & Achievements:

• **Developed a scalable automation system** using Clean Architecture principles with .NET 8.0 and C#, implementing dependency injection and Service Layer patterns to ensure maintainable, testable code with clear separation of concerns.

• **Engineered an intelligent computer vision pipeline** integrating OpenCV and PaddleOCR to perform real-time screen analysis, automated text recognition, and UI element detection, achieving 90%+ accuracy in text detection for automated game interaction.

• **Designed and implemented ADB integration layer** using AdvancedSharpAdbClient to enable programmatic Android device control, including connection management, automated input events, framebuffer capture, and multi-device support.

• **Built modular, interface-based architecture** with 4 core services (Automation, ImageProcessor, ADBConnect, Validator) backed by abstract interfaces, promoting loose coupling, code reusability, and facilitating unit testing and future extensibility.

• **Implemented robust configuration management** using Microsoft.Extensions.Configuration with strongly-typed models, supporting JSON-based configuration for automation parameters, device settings, and runtime behavior customization.

• **Leveraged Microsoft.Extensions.Hosting framework** to create a production-ready console application with background service orchestration, structured logging (console and file-based), dependency injection container, and graceful lifecycle management.

• **Applied advanced image processing techniques** including color space conversion (RGBA to RGB), safe pixel buffer manipulation, and OpenCV Mat operations to efficiently process device screenshots captured through ADB framebuffer API.

• **Developed OCR-based text recognition system** using PaddleOCR inference engine with rotation detection support, enabling dynamic UI element identification without hardcoded coordinates, improving automation resilience across game updates.

• **Established cross-platform deployment strategy** targeting Linux environments (Ubuntu 24.04 x64) with platform-specific runtime packages for OpenCV and PaddleInference, ensuring consistent performance and compatibility.

• **Integrated comprehensive Android tooling** including ADB, FastBoot, and supporting utilities from Android Platform Tools, enabling full device lifecycle management and debugging capabilities.

---

## Alternative Short Format

### Umamusume Game Automation Tool

**Software Developer & Automation Engineer**  
**Technologies:** .NET Core 8, Android Debug Bridge, OpenCV, PaddleOCR  
**01/2025 – Present**

• Developed an automated game interaction system using .NET Core 8 with Clean Architecture, leveraging dependency injection and service-oriented design for scalable and maintainable code.

• Implemented computer vision and OCR pipeline using OpenCV and PaddleOCR for real-time screen analysis and text recognition, achieving 90%+ detection accuracy for automated UI navigation.

• Engineered Android device integration using AdvancedSharpAdbClient to enable programmatic control, automated input simulation, and screen capture functionality with multi-device support.

• Built modular architecture with 4 interface-driven services, JSON-based configuration system, and Microsoft.Extensions.Hosting framework for robust background task execution and logging.

• Optimized cross-platform deployment for Linux (Ubuntu 24.04 x64) with platform-specific runtime packages and Android Platform Tools integration.

---

## Technical Highlights

**Architecture & Design:**
- Clean Architecture with Service Layer pattern
- Dependency Injection using Microsoft.Extensions.DependencyInjection
- Interface-based abstractions for testability
- Strongly-typed configuration with IOptions pattern
- Background service orchestration with IHostedService

**Computer Vision & AI:**
- OpenCV (OpenCvSharp4) for image processing
- PaddleOCR for optical character recognition
- Real-time framebuffer capture and processing
- RGBA to RGB color space conversion
- Template matching for UI element detection

**Android Integration:**
- AdvancedSharpAdbClient for device communication
- ADB server lifecycle management
- Device pairing and connection handling
- Automated tap events and button clicks
- Screenshot capture via framebuffer API

**Development Practices:**
- .NET 8.0 with C# 12 features
- Async/await patterns for responsive operations
- Structured logging with Microsoft.Extensions.Logging
- Cross-platform Linux deployment
- JSON-based external configuration
