# Deployment Guide

## Prerequisites
- Unity 2021.3 or later
- Visual Studio or Rider for C# development
- Git installed

## Build Steps

### 1. Code Preparation
```
git pull origin main
```

### 2. Unity Build
1. Open project in Unity
2. Go to File → Build Settings
3. Select target platform (Windows, Mac, Linux)
4. Click "Build"

### 3. Testing
- Run all unit tests
- Test integration between systems
- Verify game mechanics

### 4. Versioning
- Update version number in ProjectSettings/ProjectVersion.txt
- Create git tag for release

### 5. Deployment
- Upload build to distribution platform
- Update release notes
- Announce release

## Testing
- Unit tests: `Tests/Unit/`
- Integration tests: `Tests/Integration/`
- Manual testing: Playtest game mechanics

## Environment Variables
- UNITY_LICENSE_PATH: Path to Unity license file
- GITHUB_TOKEN: Token for automated deployment