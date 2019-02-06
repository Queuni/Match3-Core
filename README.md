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

- Correct the default path used when no config file is specified

- Simplify the dependency injection so it's easier to mock in tests

- Support both YAML and JSON config formats for flexibility

- Support config reload without restart via SIGHUP or file watch

- Handle missing optional field in the response without raising

- Add proper error handling for invalid config so the app doesn't crash on startup

- Support loading config from multiple files with later overriding earlier

- Bump the CI image to use the latest stable runner version

- Add a note in the README about the breaking change in 2.0

- Improve the CLI help text so it's clear how to use each option

- Simplify the validation flow by reusing the same schema

- Bump the CI image to use the latest stable runner version

- Refactor the client to use async context manager for the session

- Fix the encoding issue when reading config files with non-ASCII

- Improve the default config so it works out of the box for dev

- Fix the memory leak in the long-running worker process

- Implement retry logic for the API client when the remote returns 5xx

- Correct the formula used for calculating the backoff delay

- Refactor the client to use async context manager for the session

- Add a note in the README about the breaking change in 2.0

- Clean up the test fixtures and move shared data to a single file

- Adjust the pool size to match the actual concurrency we need

- Handle the case when the external service returns an empty list

- Simplify the dependency injection so it's easier to mock in tests

- Improve test coverage for the helpers module to above 90%

- Implement proper backoff with jitter for the retry logic

- Bump the version and tag the release in the repo

- Handle missing optional field in the response without raising

- Update the changelog with the fixes included in this release

- Bump the CI image to use the latest stable runner version

- Adjust buffer size for the stream reader to reduce memory usage

- Remove deprecated CLI flag and update docs to use the new option

- Remove the feature flag now that the feature is fully rolled out

- Implement a simple metrics endpoint for Prometheus scraping

- Handle the duplicate key case by merging the values instead of failing

- Improve the error recovery when the database connection is lost

- Bump the dependency to fix the compatibility issue with Python 3.12

- Handle timeout gracefully and return a clear error to the caller

- Refactor the parser to use a proper state machine instead of regex

- Improve the default config so it works out of the box for dev

- Refactor error handling to use a custom exception hierarchy

- Bump minimum Python version to 3.10 and update type hints accordingly

- Bump dependency to get the security fix for the reported CVE

- Remove the temporary debug endpoint before the release

- Fix the encoding issue when reading config files with non-ASCII

- Bump the Docker base image to get the latest security patches

- Improve error message when the required env var is not set

- Remove the experimental feature that didn't make it into the release

- Refactor config loading into a separate module for better testability

- Correct the docstring to match the actual behavior of the function

- Add a small delay between retries to avoid thundering herd

- Refactor config loading into a separate module for better testability

- Implement a simple metrics endpoint for Prometheus scraping

- Handle edge case when the response body is empty but status is 200

- Support loading config from multiple files with later overriding earlier

- Bump the dependency to fix the compatibility issue with Python 3.12

- Bump the library version and pin the dependency in requirements

- Correct the docstring to match the actual behavior of the function
