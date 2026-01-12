# Tech Stack and Dependencies

## Core Technology Stack
- **.NET 8.0**: Modern C# runtime with latest language features
- **C# Language Features**: 
  - Implicit usings enabled
  - Nullable reference types enabled
  - Top-level statements and modern syntax

## Key Dependencies

### Mobile Automation
- **adb (33.0.3)**: Android Debug Bridge for device communication
- **AdvancedSharpAdbClient (3.4.14)**: C# wrapper for ADB operations

### Computer Vision & OCR
- **OpenCvSharp4 (4.11.0.20250507)**: OpenCV bindings for C#
- **OpenCvSharp4.Extensions**: Additional OpenCV utilities
- **OpenCvSharp4.unofficial.runtime.ubuntu.24.04-x64 (4.12.0.20250708)**: Linux-specific OpenCV runtime
- **OpenCvSharpExtern (1.0.0)**: Native OpenCV bindings

### Machine Learning & OCR
- **Sdcb.PaddleInference (3.0.1)**: PaddlePaddle inference engine
- **Sdcb.PaddleInference.runtime.linux-x64 (3.1.0.54)**: Linux runtime for Paddle
- **Sdcb.PaddleInference.runtime.win64.mkl (3.1.0.54)**: Windows runtime (cross-platform support)
- **Sdcb.PaddleOCR (3.0.1)**: PaddleOCR for text recognition
- **Sdcb.PaddleOCR.Models.Online (3.0.1)**: Online OCR models

### Microsoft Extensions
- **Microsoft.Extensions.Logging (9.0.8)**: Structured logging framework
- **Microsoft.Extensions.Logging.Console (9.0.8)**: Console logging provider
- **Microsoft.Extensions.DependencyInjection**: Dependency injection container

## Platform-Specific Libraries
- **Ubuntu 24.04-x64 specific**: Native libraries for Linux deployment
- **Cross-platform support**: Windows and Linux runtimes included
- **Native Dependencies**: Extensive Linux native libraries (libtbb, libopenvino, etc.)