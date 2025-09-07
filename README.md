# Arcsettle

An ambitious 3D kingdom-building game created with Unreal Engine 5. Players will build and manage a settlement, from a humble village to a thriving kingdom, in a fully 3D world.

## Core Features

- 3D World: A dynamic 3D environment to explore and build in.
- Infrastructure Development: Construct a variety of structures including homes, farms, sawmills, markets, and garrisons.
- Resource Management: Assign villagers to gather natural resources from the environment.
- Economy: Establish trade routes and manage your kingdom's economy.
- Defense: Build walls and train units to defend your kingdom from threats.

## Tech Stack

- Game Engine: Unreal Engine 5
- IDE: Visual Studio 2022
- Programming: C++ and Blueprints

## Getting Started

Prerequisites
- Unreal Engine 5.x installed (via Epic Games Launcher)
- Visual Studio 2022 with workloads "Game development with C++" and "Desktop development with C++"
- Git and Git LFS installed

First-time setup
1) Clone the repository
   - Using Visual Studio: Git > Clone Repository (paste repo URL)
   - Or CLI: `git clone <your-repo-url>`

2) Enable Git LFS
   - `git lfs install`
   - `git lfs pull` (ensures large assets are fetched)

3) Open the Unreal project
   - If Arcsettle.uproject exists: right-click it and choose "Generate Visual Studio project files", then open Arcsettle.sln via File > Open > Project/Solution.
   - If you are starting fresh: create a new UE5 project named "Arcsettle" inside this repo folder (Games > Blank or Third Person), then right-click Arcsettle.uproject and "Generate Visual Studio project files".

Build and run
- In Visual Studio: Build > Build Solution
- Run in Unreal Editor by double-clicking Arcsettle.uproject, or from the Editor: Platforms > your target > Play/Package.

Notes
- Do not commit DerivedDataCache, Intermediate, Binaries, or Saved; they are ignored.
- Engine source should not be committed. Use the launcher-installed UE or a separate Engine checkout.

## Contributing

- Create feature branches from main.
- Submit pull requests with a brief description and screenshots/video when relevant.

## License

Choose a license (e.g., MIT, Apache-2.0) and add it as LICENSE in the repo root.
