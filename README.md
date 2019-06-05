# Match3 Core

A minimal Unity match-3 puzzle game template. Playable prototype with grid-based block matching, combos, chains, and local multiplayer support.

## Overview

This project is a self-contained Unity prototype containing core match-3 gameplay: a block grid, horizontal moves, combo and chain logic, objectives, and a simple AI opponent. The game scene is built at runtime; the `Game` scene is empty until Play.

**Included**

- Grid logic, block movement, combos, chains
- Objectives and win/lose conditions
- Local multiplayer (split UI)
- Basic AI opponent
- Touch controls
- Dynamic UI
- Unit tests for core gameplay

**Not included**

- Art assets (sprites, backgrounds, VFX, audio)
- Third-party premium plugins
- Gamepad support
- Menus, dialog system, localization
- Custom editor tools
- Console or mobile build setup

## Requirements

- [Unity](https://unity3d.com/) 2019.4.0f18

## Quick start

1. Open the project in Unity.
2. Open the `Game` scene (under `Assets`).
3. Press Play.

Use the **GAME SETTINGS** GameObject in the scene to adjust players, objectives, grid size, speed, and related options.

## Project structure

- **Core** – Pure C# grid and block logic (testable without Unity).
- **Game** – Unity MonoBehaviours and game flow (`PonGameScript`, `GridScript`, etc.).
- **UI** – In-game UI and dynamic layout for versus mode.

The codebase separates `Block` (core) from `BlockScript` (Unity); some game logic also lives in scripts for historical reasons. Unit tests cover most of the core layer.

## License

See `LICENSE.md` in the repository root.

- Refactor the main entry point to make it easier to test

- Handle the case when the external service returns an empty list

- Bump the Docker base image to get the latest security patches

- Clean up the deprecated alias and point callers to the new name

- Improve test coverage for the helpers module to above 90%

- Fix issue where empty input was not validated before passing to the parser

- Update dependencies and resolve compatibility warning from pytest

- Add integration tests for the new export endpoint

- Bump minimum Python version to 3.10 and update type hints accordingly

- Add a small delay between retries to avoid thundering herd

- Simplify the build script by using the same steps for dev and prod

- Handle the redirect response and follow it to get the final resource

- Simplify the CLI by merging the two similar subcommands into one

- Correct the comparison that was using the wrong operator

- Fix issue where empty input was not validated before passing to the parser
