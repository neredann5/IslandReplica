# Island Replica — Windows 11

A small WPF desktop prototype that builds automatically on GitHub Actions.

## Build an EXE
1. Push this repository to GitHub on the `main` branch.
2. Open **Actions** → **Build Windows app**.
3. If asked, enable GitHub Actions for the repository.
4. Select **Run workflow** if no build started automatically.
5. Open the completed run and download `IslandReplica-Windows-x64` under **Artifacts**.
6. Extract the ZIP and run `IslandReplica.exe` on Windows 11.

The workflow publishes a self-contained Windows x64 executable, so .NET does not need to be installed on the target PC.

## Current scope
This is an initial desktop-shell prototype: topmost pill, expand/collapse panel, clock/date, and dragging. It is not yet a feature-complete replacement for Island. Media-session integration, real Windows notifications, wallpaper/video support, weather, settings, startup registration, and final polish remain to be implemented and tested.

## Requirements
Windows 11 x64 to run the published application. GitHub Actions builds it on a Windows runner.
