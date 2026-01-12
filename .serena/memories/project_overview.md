# Uma Musume Automation Project - Overview

## Purpose
This is an **Uma Musume Friend Points Automation** tool written in C# that automates friend point farming in the Uma Musume mobile game. The application connects to Android devices via ADB and uses computer vision (OpenCV) and OCR (PaddleOCR) to automatically interact with the game interface.

## Key Features
- **ADB Device Connection**: Connects to Android devices/emulators via ADB
- **Computer Vision**: Uses OpenCV for image recognition and template matching
- **OCR Text Recognition**: Employs PaddleOCR for reading in-game text
- **UI Automation**: Automated clicking and navigation through game menus
- **Friend Point Farming**: Specifically designed to farm friend points automatically
- **Configurable Parameters**: Extensive configuration for timing, filtering, and behavior
- **Linux Optimized**: Built specifically for Linux deployment (Ubuntu 24.04-x64)

## Target Platform
- **Operating System**: Linux (specifically Ubuntu 24.04-x64)
- **Runtime**: .NET 8.0
- **Device Connection**: Android devices/emulators via ADB

## Project Architecture
- **Multi-Project Solution**: Clean separation between core library and CLI application
- **Dependency Injection**: Uses Microsoft.Extensions.DependencyInjection
- **Interface-Based Design**: Promotes testability and maintainability
- **Configuration-Driven**: JSON-based configuration for all automation parameters