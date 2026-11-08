# Spider-Man: New York

A mobile-focused Unreal Engine learning project for an original, non-commercial superhero traversal prototype inspired by comic-book city adventures.

## Current status

This repository now contains the initial Unreal Engine C++ project scaffold:
- `SpiderManNewYork.uproject`
- Runtime module and game/editor target rules
- Basic engine configuration
- Unreal-generated-file exclusions in `.gitignore`

**This is a project scaffold, not a playable game yet.** It has not been compiled or opened in Unreal Editor. No character, city map, web-swinging system, animations, or Android package has been created yet.

## Engine target

The project descriptor currently targets Unreal Engine 5.7. Open it with a compatible Unreal Engine 5.7 installation. If using another engine version, update `EngineAssociation` and verify the target rules in the editor/build environment.

## Development roadmap

1. Verify that the project opens and compiles in Unreal Editor.
2. Build a small third-person test area and player controller.
3. Implement safe, controllable traversal mechanics and camera behavior.
4. Create a compact city block before expanding the world.
5. Optimize the mobile rendering and input setup.
6. Package and test an Android build.

## Important

Unreal Editor and Android packaging require a compatible development environment with the Unreal toolchain and Android SDK/NDK. GitHub stores the project source; GitHub Actions alone does not provide the Unreal Editor or guarantee a working Android build.
