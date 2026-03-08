# Match3 Core

A minimal Unity match-3 puzzle game template. Playable prototype with grid-based block matching, combos, chains, and local multiplayer support.

## Screenshot

![Game screenshot](tiny-flipon.gif)

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
