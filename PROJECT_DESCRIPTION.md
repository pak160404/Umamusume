# Umamusume Automation Tool

**Software Developer & Automation Engineer**  
**Technologies:** .NET Core 8, C#, Android Debug Bridge, OpenCV, PaddleOCR  

**01/2025 – Present**

• Developed a scalable automation tool using Clean Architecture principles with .NET 8.0 and C#, implementing the Service Layer pattern with dependency injection for maintainability and testability.

• Engineered a computer vision system integrating OpenCV and PaddleOCR to perform real-time screen capture, image processing, and optical character recognition, achieving automated UI navigation with 90%+ text detection accuracy.

• Designed and implemented a robust ADB integration layer using AdvancedSharpAdbClient, enabling programmatic control of Android devices with features including device connection management, automated tap events, and screen capture functionality.

• Built a modular architecture with clear separation of concerns across 4 core services (Automation, ImageProcessor, ADBConnect, Validator) and 4 interface contracts, ensuring code reusability and easy unit testing.

• Implemented JSON-based configuration system with strongly-typed models using Microsoft.Extensions.Configuration, supporting dynamic automation parameters including wait times, retry attempts, coordinate mapping, and device connection settings.

• Leveraged Microsoft.Extensions.Hosting framework to create a console application with background service orchestration, structured logging, and graceful shutdown handling for long-running automation tasks.

• Applied advanced image processing techniques including RGBA to RGB color space conversion, pixel-safe buffer handling, and OpenCV Mat manipulation to process device framebuffers captured via ADB.

• Designed an OCR-based text detection system using PaddleOCR with support for rotation detection and English language models, enabling automated button recognition and UI element identification without hardcoded coordinates.

• Established cross-platform deployment targeting Linux (Ubuntu 24.04 x64) with runtime-specific packages for OpenCV and PaddleInference, ensuring consistent behavior across development and production environments.

• Integrated Android Platform Tools including ADB, FastBoot, and SQLite3 to provide comprehensive device management capabilities and support for multiple Android devices simultaneously.
